using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3____more_forms
{
    public class DerivedClass : BaseClass {
        public DerivedClass(string message) : base(message)
        {
        }

        public override string Method1()
        {
            // parent ko call garna base keyword use 
            // return base.Method1();
            return "It is derrived method 1\n Message is: " + message;
        }
    }
}
