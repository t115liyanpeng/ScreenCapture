using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FluentFTP;

namespace screencapture
{
    public class FluentFtpHelp
    {
        public static bool FluentFtpUpLoad(string ftpServerIP, string ftpUserID, string ftpPassword,string localpath,string removepath)
        {
            bool ret = false;
            try
            {
                string[] addr = ftpServerIP.Split(':');
                FtpClient client = new FtpClient(addr[0]);
                client.Port = int.Parse(addr[1]);
                client.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                client.Connect();
                var a = client.UploadFile(localpath, removepath);
                client.Disconnect();
                ret = a == FtpStatus.Success;
                client.Dispose();
                return ret;
            }
            catch (Exception e)
            {
                LogHelper.CreateLogTxt(e.Message);
                return ret;
            }
            
        }
    }
}
