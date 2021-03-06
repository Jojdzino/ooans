﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Decorator
{
    class HeaderDecorator : Decorator
    {
        public IComponent Component { get; set; }
        private string strVal;
        public void SetStringValue(string strVal)
        {
            this.strVal = strVal;
        }

        public string ShowMessage()
        {
            return strVal + Component.ShowMessage();
        }
    }
}
