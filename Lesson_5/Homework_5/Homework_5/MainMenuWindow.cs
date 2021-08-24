using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    sealed class MainMenuWindow : Window
    {
        
        private readonly int numberOfMainWindowButtons;
        MainMenuWindow()
        {
            
            numberOfMainWindowButtons = 3;
        }

        ~MainMenuWindow()
        {

        }
        public override void SetWindowSize()
        {
            windowSize.X = 1920;
            windowSize.Y = 1080;
        }
    }
}
