using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ISP
{
    class MainWindow : IColor, IWindowEvents, IWindowRender
    {
        public void CreateWindow(int width, int height, int posX, int posY)
        {

        }
        public void ShowWindow()
        {

        }
        public void HideWindow()
        {

        }

        public void OnWindowClose()
        {

        }
        public void OnWindowResized()
        {

        }
        public void OnWindowRendered()
        {

        }

        public void SetRgbColor(int r, int g, int b)
        {

        }
        public void SetHsvColor(int h, int s, int v)
        {

        }
    }
}
