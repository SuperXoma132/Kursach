using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace Курсовая_работа_БОЯП
{
    public partial class UsersChange : Form
    {
        SqlConnection sqlConnection1 = null;
        public UsersChange()
        {
            InitializeComponent();
        }

        private void UsersChange_Load(object sender, EventArgs e)
        {
            this.Text = $"Корнеев Александр Александрович, Логин: {SavedUserData.UserLogin}, Роль: {SavedUserData.UserRole}, Редактирование пользователей";
            Role.DropDownStyle = ComboBoxStyle.DropDown;
            Role.Items.Add("Администратор");
            Role.Items.Add("Пользователь");
            Role.Items.Add("Гость");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection1 = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection1.Open();
            DataTable table = new DataTable();
            string id = id_checker.Text.Trim();
            SqlCommand getInfoCommand = new SqlCommand($"SELECT Id, Login, Password, Role FROM Users WHERE Id = N'{id}'", sqlConnection1);
            SqlDataReader getInfo = getInfoCommand.ExecuteReader();
            if (getInfo.HasRows)
            {
                while (getInfo.Read())
                {
                    Login.Text = getInfo[1].ToString();
                    Password.Text = getInfo[2].ToString();
                    Role.Text = getInfo[3].ToString();

                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким номером не существует");
                Login.Text = "";
                Password.Text = "";
                Role.Text = "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection1 = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection1.Open();
            int number;
            if (!(new Regex(@"[A-Z]+").IsMatch(Password.Text)) || !(new Regex(@".{6,30}").IsMatch(Password.Text)) || !(new Regex(@"[0-9]+")).IsMatch(Password.Text) ||
                        !(new Regex(@"[!@#$%^]").IsMatch(Password.Text)))
            {
                MessageBox.Show("Пароль не соответствует требованиям");
            }
            else
            {
                if (!(Login.Text.IsNullOrEmpty() || Password.Text.IsNullOrEmpty()) && (Role.Text == "Администратор" || Role.Text == "Пользователь" || Role.Text == "Гость"))
                {
                    sqlConnection1 = new SqlConnection(SavedUserData.ConnectionString);
                    sqlConnection1.Open();
                    SqlCommand updateTable = new SqlCommand($"UPDATE Users SET " +
                        $"Login = N'{Login.Text}', " +
                        $"Password = N'{Password.Text}', " +
                        $"Role = N'{Role.Text}' " +
                        $"WHERE Id = N'{id_checker.Text}'", sqlConnection1);
                    updateTable.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Заполните все поля корректно");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
