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
    public partial class UsersListMod : Form
    {
        SqlConnection sqlConnection = null;
        public UsersListMod()
        {
            InitializeComponent();
        }
        private void changeButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection.Open();
            int number;
            if (!(new Regex(@"[A-Z]+").IsMatch(passwordBox.Text)) || !(new Regex(@".{6,30}").IsMatch(passwordBox.Text)) || !(new Regex(@"[0-9]+")).IsMatch(passwordBox.Text) ||
                        !(new Regex(@"[!@#$%^]").IsMatch(passwordBox.Text)))
            {
                MessageBox.Show("Пароль не соответствует требованиям");
            }
            else
            {
                if (!(loginBox.Text.IsNullOrEmpty() || passwordBox.Text.IsNullOrEmpty()) && (roleBox.Text == "Администратор" || roleBox.Text == "Пользователь" || roleBox.Text == "Гость"))
                {
                    sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
                    sqlConnection.Open();
                    SqlCommand updateTable = new SqlCommand($"UPDATE Users SET " +
                        $"Login = N'{loginBox.Text}', " +
                        $"Password = N'{passwordBox.Text}', " +
                        $"Role = N'{roleBox.Text}' " +
                        $"WHERE Id = N'{idCheckerBox.Text}'", sqlConnection);
                    updateTable.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Заполните все поля корректно");
                }
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection.Open();
            DataTable table = new DataTable();
            string id = idCheckerBox.Text.Trim();
            SqlCommand getInfoCommand = new SqlCommand($"SELECT Id, Login, Password, Role FROM Users WHERE Id = N'{id}'", sqlConnection);
            SqlDataReader getInfo = getInfoCommand.ExecuteReader();
            if (getInfo.HasRows)
            {
                while (getInfo.Read())
                {
                    loginBox.Text = getInfo[1].ToString();
                    passwordBox.Text = getInfo[2].ToString();
                    roleBox.Text = getInfo[3].ToString();

                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким номером не существует");
                loginBox.Text = "";
                passwordBox.Text = "";
                roleBox.Text = "";
            }
        }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UsersChange_Load(object sender, EventArgs e)
        {
            this.Text = $"Казаков Даниил Валерьевич --- Логин: {SavedUserData.UserLogin} --- Роль: {SavedUserData.UserRole} --- Редактирование пользователей";
            roleBox.DropDownStyle = ComboBoxStyle.DropDown;
            roleBox.Items.Add("Администратор");
            roleBox.Items.Add("Пользователь");
            roleBox.Items.Add("Гость");
        }
    }
}
