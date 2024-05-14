using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void catchmeBtn_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int toX = random.Next(Size.Width - 100);
            int toY = random.Next(Size.Height - 100);

            int x = catchmeBtn.Location.X;
            int y = catchmeBtn.Location.Y;

             
              while(toX!=x && toY!=y){
                x = x<toX ? x+1: x-1;
                y = y<toY ? y+1: y-1;
                catchmeBtn.Location = new Point(x, y);
                Thread.Sleep(300);
              };
            
        }
    }
}
