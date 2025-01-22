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
        public MainPage(string login, string role)
        {
            InitializeComponent();
            this.Text = $"Корнеев Александр Александрович ЭПИ-211, Логин: {login}, Роль: {role}";
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            if (CurrentUserData.UserRole == "Гость")
            {
                AddStudentButton.Enabled = false;
                AddStudentButton.Visible = false;
                SortingButton.Enabled = false;
                SortingButton.Visible = false;
                UsersListButton.Enabled = false;
                UsersListButton.Visible = false;
                StudentsListAdmin.Enabled = false;
                StudentsListAdmin.Visible = false;
            }
            else if (CurrentUserData.UserRole == "Пользователь")
            {
                UsersListButton.Enabled = false;
                UsersListButton.Visible = false;
                StudentsListAdmin.Enabled = false;
                StudentsListAdmin.Visible = false;
            }
            else if (CurrentUserData.UserRole == "Администратор")
            {
                //можно всё
            }
        }

        private void StudentsListButton_Click(object sender, EventArgs e)
        {
            StudentsList studentsList = new StudentsList();
            studentsList.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentsListAdmin_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void SortingButton_Click(object sender, EventArgs e)
        {
            Sorting sorting = new Sorting();
            sorting.Show();
        }

        private void UsersListButton_Click(object sender, EventArgs e)
        {
            UsersList usersList = new UsersList();
            usersList.Show();
        }
    }
}
