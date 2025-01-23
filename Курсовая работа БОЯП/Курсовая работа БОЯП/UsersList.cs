using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Курсовая_работа_БОЯП
{
    public partial class UsersList : Form
    {
        SqlConnection sqlConnection1 = null;
        public UsersList()
        {
            InitializeComponent();
        }
        private void UsersList_Load(object sender, EventArgs e)
        {
            this.Text = $" Корнеев Александр Александрович, Логин: {SavedUserData.UserLogin}, Роль: {SavedUserData.UserRole}, Список пользователей";
            sqlConnection1 = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection1.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Login, Password, Role FROM Users", sqlConnection1);
            adapter.Fill(table);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Password";
            dataGridView1.Columns[3].HeaderText = "Role";
            sqlConnection1.Close();
            if (SavedUserData.UserRole == "Администратор")
            {
                button3.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = $" Корнеев Александр Александрович, Логин: {SavedUserData.UserLogin}, Роль: {SavedUserData.UserRole}, Список пользователей";
            sqlConnection1 = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection1.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Login, Password, Role FROM Users", sqlConnection1);
            adapter.Fill(table);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Password";
            dataGridView1.Columns[3].HeaderText = "Role";
            sqlConnection1.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UsersChange usersChange = new UsersChange();
            usersChange.Show();
        }
    }
}
