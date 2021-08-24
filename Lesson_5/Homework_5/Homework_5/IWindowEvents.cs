using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    interface IWindowEvents
    {
        public void OnWindowClose();
        public void OnWindowResized();
        public void OnWindowRendered();
    }
}
