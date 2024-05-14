using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3____more_forms
{
    public partial class VIrtualDemo : Form
    {
        public VIrtualDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseClass bc = new DerivedClass("Message initialized");
            MessageBox.Show(bc.Method1());
            MessageBox.Show(bc.Method2());
        }
    }
}
