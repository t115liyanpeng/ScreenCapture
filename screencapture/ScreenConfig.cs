using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screencapture
{
    public class ScreenConfig
    {
        /// <summary>
        /// 计时器
        /// </summary>
        public int LockTime { get; set; }
        /// <summary>
        /// 服务器地址
        /// </summary>
        public string FtpAddress { get; set; }
        /// <summary>
        /// ftp登录名
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 屏幕名称
        /// </summary>
        public string ScreenName { get; set; }
        /// <summary>
        /// 屏幕开始的x点
        /// </summary>
        public int Sx{ get; set; }
        /// <summary>
        /// 屏幕开始的y轴
        /// </summary>
        public int Sy { get; set; }
        /// <summary>
        /// 时间间隔
        /// </summary>
        public int TimeSpan { get; set; }

        public int Width { get; set; }

        public int Heigth { get; set; }
        /// <summary>
        /// 保存的文件名称
        /// </summary>
        public string SaveName { get; set; }
        /// <summary>
        /// 上传到ftp的路径
        /// </summary>
        public string FtpPath { get; set; }
        /// <summary>
        /// 本地文件路径
        /// </summary>
        public string LocalImgPath { get; set; }
    }
}
