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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.TopLevel = true;
            mainPage.Show();
            mainPage.FormClosed += (object s, FormClosedEventArgs ev) => this.Close();
        }
    }
}
