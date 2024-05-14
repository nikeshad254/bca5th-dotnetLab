using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    public class EnumClass
    {
        /// <summary>
        /// It describes Enum wich holds numeric const values
        /// </summary>
        /// <returns>It returns string value</returns>
        public string GetEnumMessage()
        {
            return "It is enum Info.";
        }
    }

    enum Roles
    {
        SuperAdmin,
        Admin,
        User
    }
}
