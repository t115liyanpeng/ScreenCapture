using System;
using System.Collections.Generic;
using System.Configuration;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
//using System.Net;
//using System.Text;
using System.Text.RegularExpressions;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Threading;
using System.Threading.Tasks;



namespace screencapture
{
    public partial class ScreenCapture : Form
    {
        private static object ob = new object();
        public Screen[] Screens;

        private DateTime restartDt;
        //所有屏幕的下拉列表
        public List<ScreenInfo> ScreenInfos = new List<ScreenInfo>();
        /// <summary>
        /// 添加的配置信息队列
        /// </summary>
        public List<ScreenConfig> Configs = new List<ScreenConfig>();

        private ZipImg zip = new ZipImg();

        public static string xmlpath = "";

        private System.Timers.Timer restarTimer = new System.Timers.Timer();

        private System.Threading.Timer clock;

        private int ziplevel = 0;

        private AutoResetEvent startSingle = new AutoResetEvent(true);
        private AutoResetEvent waitThread = new AutoResetEvent(false);
        //public LogHelper log;
        public ScreenCapture()
        {
            InitializeComponent();
            //log=new LogHelper();
            xmlpath = Application.StartupPath + "\\config.xml";
            if (!Directory.Exists(Application.StartupPath + "\\Picture\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Picture\\");
            }
            
            imgfromat.SelectedIndex = 0;
            Screens = Screen.AllScreens;
            dgv_config.AutoGenerateColumns = false;
            restarTimer.Interval = (60 * 1000);
            restarTimer.Elapsed += RestarTimer_Elapsed;

            ziplevel = Convert.ToInt32(ConfigurationManager.AppSettings["zip"]);

            txt_h.Text = ConfigurationManager.AppSettings["hh"];
            txt_m.Text = ConfigurationManager.AppSettings["mm"];
            txtTime.Text= ConfigurationManager.AppSettings["captime"];
            chk_reatart.Checked = bool.Parse(ConfigurationManager.AppSettings["autorestart"]);
            if (chk_reatart.Checked)
            {
                if (File.Exists("config.xml"))
                {
                    Configs.Clear();
                    dgv_config.DataSource = null;
                    using (XmlReader reader = XmlReader.Create("config.xml"))
                    {
                        XmlSerializer xz = new XmlSerializer(Configs.GetType());
                        Configs = (List<ScreenConfig>)xz.Deserialize(reader);
                        //Console.WriteLine(reader.ToString());
                    }
                    dgv_config.DataSource = Configs;
                    txt_h.Enabled = false;
                    txt_m.Enabled = false;
                    restarTimer.Start();
                   
                    this.WindowState = FormWindowState.Minimized;
                    this.Hide();
                    this.notifyIcon1.Visible = true;
                    btnStart_Click(null, null);
                }
                else
                {
                    MessageBox.Show("没有读取到配置文件！，请先配置好保存后点开始抓屏");
                }
            }


            LogHelper.CreateLogTxt("--->initalize");
        }


        private void ScreenCapture_Load(object sender, EventArgs e)
        {
            //ReadXMLconfig();
            for (int i = 0; i < Screens.Length; i++)
            {
                ScreenInfo info = new ScreenInfo();
                info.ScreenName = Screens[i].DeviceName;
                info.SizeInfo = new SizeInfo() { Heigth = Screens[i].Bounds.Height, Width = Screens[i].Bounds.Width, X = Screens[i].Bounds.X, Y = Screens[i].Bounds.Y };
                ScreenInfos.Add(info);
            }
            cmbScreen.DataSource = ScreenInfos;
            cmbScreen.DisplayMember = "ScreenName";
            cmbScreen.ValueMember = "SizeInfo";
            if (ScreenInfos.Count > 0)
            {
                pciDisplay.Image = CaptureImg(ScreenInfos[0].SizeInfo.Width, ScreenInfos[0].SizeInfo.Heigth,
                    ScreenInfos[0].SizeInfo.X, ScreenInfos[0].SizeInfo.Y);
            }

            //clock.Interval = 1000;
            //clock.Tick += clock_Tick;
            
           
        }


        void clock_Tick(object sender)
        {
            //clock.Stop();
            //startSingle.WaitOne();
            clock.Change(-1, 0);
            for (int i = 0; i < Configs.Count; i++)
            {
                CaptureImgAndSave(Configs[i].Width, Configs[i].Heigth, Configs[i].Sx, Configs[i].Sy, Configs[i].LocalImgPath);
                LogHelper.CreateLogTxt("---->capture " + Configs[i].SaveName + " img success");
                if (ziplevel > 0)
                {
                    //压缩
                    zip.GetPicThumbnail(Configs[i].LocalImgPath, Configs[i].LocalImgPath, Configs[i].Heigth, Configs[i].Width,
                        ziplevel);
                }

                #region re send
                //int send = 0;
                //while (!UploadPictureToFtp(Configs[i].FtpAddress, Configs[i].Username, Configs[i].Password, Configs[i].FtpPath,
                //    Configs[i].LocalImgPath))
                //{
                //    if (send == 3)
                //    {
                //        break;
                //    }
                //    LogHelper.CreateLogTxt($"上传图片{Configs[i].LocalImgPath}第{send + 1}次失败！");
                //    send++;
                //}

                //if (send == 0 || send < 3)
                //{
                //    LogHelper.CreateLogTxt($"上传图片{Configs[i].LocalImgPath}成功");
                //}

                //clock.Change(TimeSpan.FromSeconds(config.TimeSpan), TimeSpan.FromSeconds(config.TimeSpan));
                //startSingle.Set();
                //clock.Start();

                #endregion

                string remote = string.Empty;

                if (!string.IsNullOrEmpty(Configs[i].FtpPath))
                {
                    remote = $"{Configs[i].FtpPath}/{Configs[i].SaveName}";
                }
                else
                {
                    remote = Configs[i].SaveName;
                }

                int send = 0;
                while (!FluentFtpHelp.FluentFtpUpLoad(Configs[i].FtpAddress, Configs[i].Username, Configs[i].Password, Configs[i].LocalImgPath,
                    remote))
                {
                    if (send == 3)
                    {
                        break;
                    }
                    LogHelper.CreateLogTxt($"上传图片{Configs[i].LocalImgPath}第{send + 1}次失败！");
                    send++;
                }

                if (send == 0 || send < 3)
                {
                    LogHelper.CreateLogTxt($"上传图片{Configs[i].LocalImgPath}成功");
                }
            }
            clock.Change(TimeSpan.FromSeconds(int.Parse(txtTime.Text)), TimeSpan.FromSeconds(1));

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //if (clock.Enabled)
            //{
            //    clock.Stop();
            //    SetControl(true);
            //    LogHelper.CreateLogTxt("---->capture is stop");
            //}
            clock.Change(-1, 0);
            SetControl(true);
            LogHelper.CreateLogTxt("---->capture is stop");
        }

        private void ScreenCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = true;
            this.Show();
            this.Activate();
            this.WindowState = FormWindowState.Normal;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (dgv_config.RowCount > 0)
            {
                int time = 20;
                if (int.TryParse(txtTime.Text, out time))
                {
                    clock = new System.Threading.Timer(clock_Tick, null, TimeSpan.FromSeconds(1),
                        TimeSpan.FromSeconds(time));
                    SetControl(false);
                }
                else
                {
                    MessageBox.Show("截屏间隔时间不正确！");
                }
            }
            else
            {
                MessageBox.Show("没有配置信息！");
            }
        }

        private bool UploadPictureToFtp(string ftpaddress, string username, string pass, string removepath, string filepath)
        {
            try
            {
                FTPHelper ftp = new FTPHelper(ftpaddress, removepath, username, pass);
                ftp.Upload(filepath);
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.CreateLogTxt(ex.Message);
                return false;
            }
        }

        private Uri StringToUri(string s)
        {
            Uri myUri = new Uri(s);
            return myUri;
        }

        private void SetControl(bool isuse)
        {
            txtremotdir.ReadOnly = !isuse;
            txtPort.ReadOnly = !isuse;
            txtTime.ReadOnly = !isuse;
            txtimgname.ReadOnly = !isuse;
            txtip.ReadOnly = !isuse;
            txtpass.ReadOnly = !isuse;
            txtusername.ReadOnly = !isuse;
            imgfromat.Enabled = isuse;
            cmbScreen.Enabled = isuse;
            btnAddconfig.Enabled = isuse;
            btnStart.Enabled = isuse;
        }

        private void 停止抓屏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (clock.Enabled)
            //{
            //    clock.Stop();
            //    SetControl(true);
            //}
            clock.Change(-1,0); 
            SetControl(true);
        }

        private void 退出服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CheckNull()
        {
            if (string.IsNullOrEmpty(txtip.Text.Trim()))
            {
                MessageBox.Show("IP地址不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtPort.Text.Trim()))
            {
                MessageBox.Show("端口不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtusername.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtpass.Text.Trim()))
            {
                MessageBox.Show("密码不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtTime.Text.Trim()))
            {
                MessageBox.Show("截图的时间间隔不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtimgname.Text.Trim()))
            {
                MessageBox.Show("保存图片的名称不能为空");
                return false;
            }
            if (cmbScreen.SelectedItem == null)
            {
                MessageBox.Show("必须选中一个屏幕");
                return false;
            }
            return true;
        }

        private void cmbScreen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var imginfo = (SizeInfo)cmbScreen.SelectedValue;
            pciDisplay.Image.Dispose();
            //Image img = CaptureImg(imginfo.Width, imginfo.Heigth, imginfo.X, imginfo.Y);
            pciDisplay.Image = CaptureImg(imginfo.Width, imginfo.Heigth, imginfo.X, imginfo.Y);
        }

        private Image CaptureImg(int Width, int Height, int X, int Y)
        {
            Image bitmap = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                Size s = new Size(Width, Height);
                //s.Width = rc.Size.Width / 2;
                g.CopyFromScreen(X, Y, 0, 0, s, CopyPixelOperation.SourceCopy);
            }
            //bitmap.Save(path + "\\Picture\\" + ImgName + "." + ImgFormat);
            //Image img = bitmap.Clone(Rectangle.FromLTRB(X,Y,X+Width,Y-Height),PixelFormat.Format32bppArgb);

            return bitmap;
        }

        private void CaptureImgAndSave(int w, int h, int x, int y, string path)
        {
            Image img = CaptureImg(w, h, x, y);
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, ImageFormat.Jpeg);
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] buffer = ms.GetBuffer();
                        fs.Write(buffer, 0, buffer.Length);
                        fs.Flush();
                        fs.Close();
                        
                    }
                }

            }
            catch (Exception e)
            {
                LogHelper.CreateLogTxt($"get img err {e.Message}");
            }
            finally
            {
                img.Dispose();
            }


        }

        private void btnAddconfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckNull())
                {
                    if (!Regex.IsMatch(txtip.Text.Trim(),
                        @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$"))
                    {
                        MessageBox.Show("IP地址不规范！");
                        return;
                    }
                    int temp_int = 0;
                    if (!int.TryParse(txtPort.Text.Trim(), out temp_int))
                    {
                        MessageBox.Show("端口必须是整数!");
                        return;
                    }
                    if (temp_int <= 0)
                    {
                        MessageBox.Show("端口必须大于0");
                        return;
                    }
                    int time_int = 0;
                    if (!int.TryParse(txtTime.Text.Trim(), out time_int))
                    {
                        MessageBox.Show("时间间隔必须是整数");
                        return;
                    }
                    if (time_int < 10)
                    {
                        MessageBox.Show("时间间隔必须大于10s");
                        return;
                    }
                    if (time_int > 60)
                    {
                        MessageBox.Show("时间间隔不能大于60s");
                        return;
                    }
                    if (AddConfig())
                    {
                        ClearConfig();
                        dgv_config.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("添加配置信息失败！");
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                LogHelper.CreateLogTxt(ex.Message);
            }
        }

        private bool AddConfig()
        {
            try
            {
                var temp = Configs.Where(x => x.SaveName == txtimgname.Text + "." + imgfromat.Text).ToList();
                if (temp.Count < 1)
                {
                    ScreenConfig config = new ScreenConfig();
                    SizeInfo size = (SizeInfo)cmbScreen.SelectedValue;
                    config.Width = size.Width;
                    config.Heigth = size.Heigth;
                    config.Sx = size.X;
                    config.Sy = size.Y;
                    config.FtpPath = txtremotdir.Text.Trim();
                    config.ScreenName = cmbScreen.Text;
                    config.SaveName = txtimgname.Text + "." + imgfromat.Text;
                    config.LocalImgPath = Application.StartupPath + "\\Picture\\" + config.SaveName;
                    config.FtpAddress = txtip.Text.Trim() + ":" + txtPort.Text.Trim();
                    config.Username = txtusername.Text.Trim();
                    config.Password = txtpass.Text.Trim();
                    config.TimeSpan = int.Parse(txtTime.Text.Trim());
                    Configs.Add(config);
                    //txtTime.Enabled = false;
                    dgv_config.DataSource = null;
                    dgv_config.DataSource = Configs;
                    return true;
                }
                else
                {
                    MessageBox.Show("保存的文件名不能重名");
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogHelper.CreateLogTxt(ex.Message);
                return false;
            }
        }

        private void ClearConfig()
        {
            //ScreenInfos.Remove(ScreenInfos.FirstOrDefault(x => x.ScreenName == cmbScreen.Text));
            //cmbScreen.DataSource = ScreenInfos;
            //pciDisplay.Image = null;
            txtremotdir.Text = "";
            txtimgname.Text = "";
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_config.RowCount > 0 && dgv_config.SelectedRows.Count == 1)
            {
                string savename = dgv_config.SelectedRows[0].Cells["savename"].Value.ToString();
                var temp = Configs.FirstOrDefault(x => x.SaveName == savename);
                Configs.Remove(temp);
            }
            dgv_config.DataSource = null;
            dgv_config.DataSource = Configs;
        }

        private void DeleteLocalFile(string path)
        {
            File.Delete(path);
        }

        private void ReadXMLconfig()
        {
            if (File.Exists(xmlpath))
            {

            }
            else
            {
                XMLHelper.CreateXmlDocument(xmlpath, "root", "1.0", "UTF-8", "yes");
                XMLHelper.CreateXmlNodeByXPath(xmlpath, "/root", "configs", "", "", "");
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            if (dgv_config.RowCount > 0)
            {
                XMLHelper.CreateXmlDocument(xmlpath, "root", "1.0", "UTF-8", "yes");

                if (File.Exists(xmlpath))
                {
                    XmlDocument xd = new XmlDocument();
                    using (StringWriter sw = new StringWriter())
                    {
                        XmlSerializer xz = new XmlSerializer(Configs.GetType());
                        xz.Serialize(sw, Configs);
                        Console.WriteLine(sw.ToString());
                        xd.LoadXml(sw.ToString());
                        xd.Save(xmlpath);
                    }
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("保存失败，config.xml文件不存在");
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "xml|*.xml";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                if (opf.FileName != "")
                {
                    Configs.Clear();
                    dgv_config.DataSource = null;
                    using (XmlReader reader = XmlReader.Create(opf.FileName))
                    {
                        XmlSerializer xz = new XmlSerializer(Configs.GetType());
                        Configs = (List<ScreenConfig>)xz.Deserialize(reader);
                        //Console.WriteLine(reader.ToString());
                    }
                    dgv_config.DataSource = Configs;
                    MessageBox.Show("导入成功！");
                }
            }
        }

        private void RestarTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            var dd = DateTime.Now;
            if (dd.Hour == restartDt.Hour && dd.Minute == restartDt.Minute)
            {
                this.Invoke(new Action(() =>
                {
                    LogHelper.CreateLogTxt("restarting......");
                    Application.Exit();

                    System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                }));
            }
        }
        private bool chekctime(out DateTime dt)
        {
            string time = $"{txt_h.Text}:{txt_m.Text}";
            return DateTime.TryParse(time, out dt);
        }

        private void chk_reatart_Click(object sender, EventArgs e)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (chk_reatart.Checked)
            {
                DateTime dt;
                if (chekctime(out dt))
                {
                    restartDt = dt;
                    cfa.AppSettings.Settings["autorestart"].Value = "true";
                    cfa.AppSettings.Settings["hh"].Value = txt_h.Text;
                    cfa.AppSettings.Settings["mm"].Value = txt_m.Text;
                    restarTimer.Start();

                    txt_h.Enabled = false;
                    txt_m.Enabled = false;

                }
                else
                {
                    MessageBox.Show("时间格式不正确", "错误");
                }
            }
            else
            {
                cfa.AppSettings.Settings["autorestart"].Value = "false";

                restarTimer.Stop();
                txt_h.Enabled = true;
                txt_m.Enabled = true;
            }

            cfa.Save();
        }
    }
}
