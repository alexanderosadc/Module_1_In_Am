using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    struct Size
    {
        public int X { set; get; }
        public int Y { set; get; }
    }

    
    abstract class Window : IWindowEvents
    {

        public const string defaultWindowName = "Windows App";

        protected bool isWindowOpened;
        protected string windowName;
        protected bool isWindowFinishedRendering;
        protected Size windowSize;

        public void OnWindowClose()
        {
            isWindowOpened = false;
        }
        public void OnWindowResized()
        {
            isWindowOpened = true;
        }
        public void OnWindowRendered()
        {
            isWindowFinishedRendering = true;
        }

        public void SetWindowName()
        {
            windowName = defaultWindowName;
        }
        public void SetWindowName(string name)
        {
            windowName = name;
        }
        
        public void SetWindowSize(int x, int y)
        {
            windowSize = new Size { X = x, Y = y };
        }
        public virtual void SetWindowSize()
        {
            windowSize = new Size { X = 10, Y = 10 };
        }
    }
}
