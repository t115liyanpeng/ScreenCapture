using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screencapture
{
    public class ScreenInfo
    {
        /// <summary>
        /// 屏幕名称
        /// </summary>
        public string ScreenName { get; set; }

        public SizeInfo SizeInfo { get; set; }
    }

    public class SizeInfo
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }

        public int Heigth { get; set; }
    }
}
