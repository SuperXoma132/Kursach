using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Курсовая_работа_БОЯП
{
    public partial class UsersList : Form
    {
        SqlConnection sqlConnection = null;
        public UsersList()
        {
            InitializeComponent();
        }
        private void UsersList_Load(object sender, EventArgs e)
        {
            this.Text = $"Казаков Даниил Валерьевич --- Логин: {SavedUserData.UserLogin} --- Роль: {SavedUserData.UserRole} --- Список пользователей";
            sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Login, Password, Role FROM Users", sqlConnection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Password";
            dataGridView1.Columns[3].HeaderText = "Role";
            sqlConnection.Close();
            if (SavedUserData.UserRole == "Администратор")
            {
                modButton.Enabled = true;
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Login, Password, Role FROM Users", sqlConnection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Password";
            dataGridView1.Columns[3].HeaderText = "Role";
            sqlConnection.Close();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void modButton_Click(object sender, EventArgs e)
        {
            UsersListMod usersListMod = new UsersListMod();
            usersListMod.Show();
        }
    }
}
