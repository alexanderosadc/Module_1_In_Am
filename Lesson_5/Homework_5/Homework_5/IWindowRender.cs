using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    interface IWindowRender
    {
        public void CreateWindow(int width, int height, int posX, int posY);
        public void ShowWindow();
        public void HideWindow();
    }
}
