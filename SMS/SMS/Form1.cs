using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class Form1 : Form
    {
        public int studentId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string email = textBox2.Text;
                string address = textBox3.Text;
                string query = "";

                query = "Insert into student values('" + name + "','" + email + "','" + address + "')";

                DBConnection db = new DBConnection();
                db.ExecuteQuery(query);

                MessageBox.Show("Save Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select * from student where id=" + studentId;
            DBConnection db = new DBConnection();
            DataTable dt = db.GetData(query);
        }
    }
}
