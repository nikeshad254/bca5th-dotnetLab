using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3____more_forms
{
    public abstract class Parent
    {
        public abstract string Play();
        public string Eat()
        {
            return "Parent Eats Rice";
        }
    }
}
