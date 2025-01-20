using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа_БОЯП
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.FormClosed += (object s, FormClosedEventArgs ev) => Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.TopLevel = true;
            addStudent.Show();
        }
    }
}
