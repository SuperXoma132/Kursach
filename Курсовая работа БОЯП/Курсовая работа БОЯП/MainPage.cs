using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Курсовая_работа_БОЯП
{
    public partial class MainPage : Form
    {
        public MainPage(string login, string role)
        {
            InitializeComponent();
            this.Text = $"Корнеев Александр ЭПИ-211, Логин: {login}, Роль: {role}";
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

        private void button2_Click(object sender, EventArgs e)
        {
            StudentsList studentsList = new StudentsList();
            studentsList.TopLevel = true;
            studentsList.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sorting sorting = new Sorting();
            sorting.TopLevel = true;
            sorting.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UsersList usersList = new UsersList();
            usersList.TopLevel = true;
            usersList.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UsersChange usersChange = new UsersChange();
            usersChange.TopLevel = true;
            usersChange.Show();
        }
    }
}
