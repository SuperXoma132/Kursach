using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Курсовая_работа_БОЯП
{
    public partial class StudentsList : Form
    {
        private SqlConnection sqlConnection = null;
        public StudentsList()
        {
            InitializeComponent();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note FROM Students", sqlConnection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Отчество";
            dataGridView1.Columns[3].HeaderText = "Дата рождения";
            dataGridView1.Columns[4].HeaderText = "Пол";
            dataGridView1.Columns[5].HeaderText = "Номер студенческого билета";
            dataGridView1.Columns[6].HeaderText = "Основа обучения";
            dataGridView1.Columns[7].HeaderText = "Задолженности";
            dataGridView1.Columns[8].HeaderText = "Примечания";
            sqlConnection.Close();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void modificationButton_Click(object sender, EventArgs e)
        {
            StudentsListMod studentsListMod = new StudentsListMod();
            studentsListMod.ShowDialog();
        }
        private void StudentsList_Load(object sender, EventArgs e)
        {
            this.Text = $"Казаков Даниил Валерьевич --- Логин: {SavedUserData.UserLogin} --- Роль: {SavedUserData.UserRole} --- Список группы";
            sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note FROM Students", sqlConnection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Отчество";
            dataGridView1.Columns[3].HeaderText = "Дата рождения";
            dataGridView1.Columns[4].HeaderText = "Пол";
            dataGridView1.Columns[5].HeaderText = "Номер студенческого билета";
            dataGridView1.Columns[6].HeaderText = "Основа обучения";
            dataGridView1.Columns[7].HeaderText = "Задолженности";
            dataGridView1.Columns[8].HeaderText = "Примечания";
            sqlConnection.Close();
            if (SavedUserData.UserRole == "Администратор")
            {
                modificationButton.Enabled = true;
            }
        }
    }
}
