using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
if(textBox1.Text == "moha" && textBox2.Text == "111")
    MessageBox.Show("مرحبا بك");
                else
    MessageBox.Show("خطا في الادخال");
        }
            else{
                MessageBox.Show("الرجاء المحاولة مرة اخري");
            }
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, " تسجيل خروج");
            toolTip1.SetToolTip(button1, " تسجيل دخول");
            toolTip1.SetToolTip(textBox1," ادخل الاسم");
            toolTip1.SetToolTip(textBox2, " ;كلمة المرور");

        }
    }
}
