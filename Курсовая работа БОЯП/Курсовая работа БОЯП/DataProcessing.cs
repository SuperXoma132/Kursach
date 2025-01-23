using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Курсовая_работа_БОЯП
{
    public partial class DataProcessing : Form //нет задолжености, дата рождения по возрастанию
    {
        private SqlConnection sqlConnection = null;
        public DataProcessing()
        {
            InitializeComponent();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DataProcessing_Load(object sender, EventArgs e)
        {
            this.Text = $"Казаков Даниил Валерьевич --- Логин: {SavedUserData.UserLogin} --- Роль: {SavedUserData.UserRole} --- Отбор данных";
            sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note FROM Students WHERE " +
                "CreditsCount = 0 ORDER BY Birthday", sqlConnection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Отчество";
            dataGridView1.Columns[3].HeaderText = "Дата рождения";
            dataGridView1.Columns[4].HeaderText = "Пол";
            dataGridView1.Columns[5].HeaderText = "Номер Студенческого билета";
            dataGridView1.Columns[6].HeaderText = "Основа обучения";
            dataGridView1.Columns[7].HeaderText = "Задолжности";
            dataGridView1.Columns[8].HeaderText = "Примечания";
            sqlConnection.Close();
        }
    }
}
