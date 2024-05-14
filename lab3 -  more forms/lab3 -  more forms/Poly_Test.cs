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
    public partial class Poly_Test : Form
    {
        public Poly_Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parent c = new Child();
            string msg = c.Play();
            MessageBox.Show(msg);
            MessageBox.Show(c.Eat());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IShape c = new Circle();
            MessageBox.Show(c.Draw());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IShape r = new Rectangle();
            MessageBox.Show(r.Draw());
        }
    }
}
