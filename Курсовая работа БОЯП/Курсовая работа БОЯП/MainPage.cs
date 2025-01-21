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
            this.Text = $"Корнеев Александр ЭПИ-211, Логин: {login}, Роль: {role}";
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
                UsersChangeButton.Enabled = false;
                UsersChangeButton.Visible = false;
            }
            else if (CurrentUserData.UserRole == "Пользователь")
            {
                UsersListButton.Enabled = false;
                UsersListButton.Visible = false;
                UsersChangeButton.Enabled = false;
                UsersChangeButton.Visible = false;
            }
            else if (CurrentUserData.UserRole == "Администратор")
            {
                //можно всё
            }
        }
    }
}
