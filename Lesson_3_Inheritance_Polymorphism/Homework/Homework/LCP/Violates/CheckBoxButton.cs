using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class CheckBoxButton : Button
    {
        public override string GetButtonGroup()
        {
            throw new InvalidOperationException("The Checkbox does not have button group");
        }
    }
}
