using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3____more_forms
{
    public class BaseClass
    {
        public string message;
        public BaseClass(string message)
        {
            this.message = message;
        }

        public virtual string Method1()
        {
            return "It is a Base Class virtual Method1";
        }

        public virtual string Method2()
        {
            return "It is a Base Class virtual Method2";
        }
    }
}
