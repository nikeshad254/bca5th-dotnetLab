using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class DisplayStudent : Form
    {
        public DisplayStudent()
        {
            InitializeComponent();
        }

        private void DisplayStudent_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void addStuBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(string searchName  = "")
        {
            try
            { 
                DBConnection db = new DBConnection();
                DataTable dt = db.GetData("Select * from Student");
                List<Student> students = new List<Student>();
                foreach (DataRow dr in dt.Rows)
                {
                    Student s = new Student();
                    s.ID = Convert.ToInt32(dr["ID"]);
                    s.Name = Convert.ToString(dr["Name"]);
                    s.Email = Convert.ToString(dr["Email"]);
                    s.Address = Convert.ToString(dr["Address"]);
                    students.Add(s);
                }

                if(!string.IsNullOrEmpty(searchName)) 
                {
                    // using lamda expression
                    // List<Student> searchStudents = students.Where(s => s.Name.Contains(searchName)).ToList();

                    //using linq
                    List<Student> searchStudents = (from s in students where s.Name.Contains(searchName) select s).ToList();
                    dataGridView1.DataSource = searchStudents;
                }
                else
                { 
                    dataGridView1.DataSource = students;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

            // 1 => edit and 0 => delete
            if (e.ColumnIndex == 1)
            {
             
                Form1 f1 = new Form1();
                f1.studentId = id;
                f1.Show();
            }else if(e.ColumnIndex == 0)
            {
                    DialogResult dr = MessageBox.Show("Are you sure?", "Delete Confrim", MessageBoxButtons.OKCancel);

                    if (dr == DialogResult.OK)
                    {
                        string query = "Delete from student where id=" + id;
                        DBConnection db = new DBConnection();
                        db.ExecuteQuery(query);
                        MessageBox.Show("Sucessfully Deleted");
                        LoadData();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = searchBox.Text;
            LoadData(name);
        }
    }
}
