using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace postgre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Datacontext db = new Datacontext())
            {
                Student student1 = new Student
                {
                    Name = $"{textBox2.Text}",
                    LastName = $"{textBox1.Text}",
                    Age = textBox3.Text,
                    University =$"{textBox4.Text}"
                };
                Student student2 = new Student
                {
                    Name = "",
                    LastName = "",
                    Age = "",
                    University = ""
                };
                db.Users.AddRange(student1, student2);
                db.SaveChanges();
                var students = db.Users.ToList();
                if (students.Contains(student1))
                {
                    label6.Text = "DONE";
                }
                else { label6.Text = "Something went wrong"; }
                

            }
        }
    }
}
