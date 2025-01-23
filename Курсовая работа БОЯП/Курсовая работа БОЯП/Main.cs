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
    public partial class Main : Form
    {
        public Main(string login, string role)
        {
            InitializeComponent();
            this.Text = $"Казаков Даниил Валерьевич ЭПИ-211 --- Логин: {login} --- Роль: {role}";
        }
        private void studentsListButton_Click(object sender, EventArgs e)
        {
            StudentsList studentsList = new StudentsList();
            studentsList.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void dataProcessingButton_Click(object sender, EventArgs e)
        {
            DataProcessing dataProcessing = new DataProcessing();
            dataProcessing.Show();
        }

        private void usersListButton_Click(object sender, EventArgs e)
        {
            UsersList usersList = new UsersList();
            usersList.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if (SavedUserData.UserRole == "Пользователь")
            {
                usersListButton.Enabled = false;
                usersListButton.Visible = false;
            }
            else if (SavedUserData.UserRole == "Гость")
            {
                addStudentButton.Enabled = false;
                addStudentButton.Visible = false;
                dataProcessingButton.Enabled = false;
                dataProcessingButton.Visible = false;
                usersListButton.Enabled = false;
                usersListButton.Visible = false;
            }
        }
    }
}
