using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOANS.Decorator
{
    class FilterDecorator : Decorator
    {
        public IComponent Component { get; set; }
        string rule;



        public void SetStringValue(string strVal)
        {
            this.rule = strVal;
        }

        public string ShowMessage()
        {

            return Component.ShowMessage().Replace(rule, "");

        }
    }
}
