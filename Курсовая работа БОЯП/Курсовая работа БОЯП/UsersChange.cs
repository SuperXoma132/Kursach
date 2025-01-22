using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Text = $"Корнеев Александр Александрович, Логин: {CurrentUserData.UserLogin}, Роль: {CurrentUserData.UserRole}, Редактирование пользователей";
            Role.DropDownStyle = ComboBoxStyle.DropDown;
            Role.Items.Add("Администратор");
            Role.Items.Add("Пользователь");
            Role.Items.Add("Гость");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection1 = new SqlConnection(CurrentUserData.ConnectionString);
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
            sqlConnection1 = new SqlConnection(CurrentUserData.ConnectionString);
            sqlConnection1.Open();
            int number;
            if (!(Login.Text.IsNullOrEmpty() || Password.Text.IsNullOrEmpty()) && (Role.Text == "Администратор" || Role.Text == "Пользователь" || Role.Text == "Гость"))
            {
                sqlConnection1 = new SqlConnection(CurrentUserData.ConnectionString);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
