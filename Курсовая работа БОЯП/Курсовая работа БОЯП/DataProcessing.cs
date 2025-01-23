using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Курсовая_работа_БОЯП
{
    public partial class DataProcessing : Form //мужской пол, номер студенческого по возрастанию
    {
        private SqlConnection sqlConnection1 = null;
        public DataProcessing()
        {
            InitializeComponent();
        }
        private void Sorting_Load(object sender, EventArgs e)
        {
            this.Text = $" Корнеев Александр Александрович, Логин: {SavedUserData.UserLogin}, Роль: {SavedUserData.UserRole}, Список группы";
            sqlConnection1 = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection1.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note FROM Students WHERE " +
                "Sex = N'Мужской' ORDER BY Id", sqlConnection1);
            adapter.Fill(table);
            dataGridView1.ReadOnly = false;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Отчество";
            dataGridView1.Columns[3].HeaderText = "Дата рождения";
            dataGridView1.Columns[4].HeaderText = "Пол";
            dataGridView1.Columns[5].HeaderText = "ID Студенческого билета";
            dataGridView1.Columns[6].HeaderText = "Основа обучения";
            dataGridView1.Columns[7].HeaderText = "Долги";
            dataGridView1.Columns[8].HeaderText = "Примечания";
            sqlConnection1.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
