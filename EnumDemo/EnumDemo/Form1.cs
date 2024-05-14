using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Roles.SuperAdmin == (Roles)comboBox1.SelectedIndex ) 
            {
                EnumClass enumClass = new EnumClass();
                string m = enumClass.GetEnumMessage();
                MessageBox.Show(m);
            }
            else
            {
                MessageBox.Show("You are not SuperAdmin", "Invalid!!", MessageBoxButtons.OKCancel);
            }
        }
    }
}
