using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ISP.Violates
{
    //It violates ISP
    interface IUserInterface
    {
        void CreateWindow(int width, int height, int posX, int posY);
        void ShowWindow();
        void HideWindow();
        void SetRgbColor(int r, int g, int b);
        void SetHsvColor(int h, int s, int v);
        void OnWindowClose();
        void OnWindowResized();
        void OnWindowRendered();

    }
}
