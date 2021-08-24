using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ISP
{
    interface IWindowEvents
    {
        public void OnWindowClose();
        public void OnWindowResized();
        public void OnWindowRendered();
    }
}
