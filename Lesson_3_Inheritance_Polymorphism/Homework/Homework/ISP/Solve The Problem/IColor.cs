using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ISP
{
    interface IColor
    {
        public void SetRgbColor(int r, int g, int b);
        public void SetHsvColor(int h, int s, int v);
    }
}
