using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_8
{
    public partial class Form1 : Form
    {
        string[] stdnm = new string[] { "kamran", "ali", "umar", "usama", "asim", "sameer", "ali", "azeem", "salman", "abdullah", "farooqeazam", "umar", "ahad" };
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string combinestring = "";
            var myname = from std in stdnm
                         where std == textBox1.Text
                         orderby std ascending
                         select std;
            foreach(String student in myname)
            {
                combinestring = combinestring + student + "\n";
            }
            result.Text = combinestring;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string combinestring = "";
            foreach(string i in stdnm)
            {
                combinestring = combinestring + i.ToString() + "\n";
            }
            result.Text = combinestring;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string combinestring = "";
            var myname = from student in stdnm
                         where student.StartsWith(textBox2.Text)
                         select student;
            foreach (String student in myname)
            {
                combinestring = combinestring + student + "\n";
            }
            result.Text = combinestring;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string combinestring = "";
            var myname = from word in stdnm
                         where word.Length == int.Parse(textBox3.Text)
                         select word;
            foreach (String student in myname)
            {
                combinestring = combinestring + student + "\n";
            }
            result.Text = combinestring;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string combinestring = "";
            var myname = from student in stdnm
                         where student.Contains(textBox4.Text)
                         select student;
            foreach (String student in myname)
            {
                combinestring = combinestring + student + "\n";
            }
            result.Text = combinestring;
        }
    }
}
