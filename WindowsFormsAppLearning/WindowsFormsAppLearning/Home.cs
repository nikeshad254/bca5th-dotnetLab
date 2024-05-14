using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLearning
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent rs = new RegisterStudent();
            rs.Show();
            Hide();
        }
    }
}
