using System;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace Курсовая_работа_БОЯП
{
    public partial class AddStudent : Form
    {
        SqlConnection sqlConnection = null;
        public AddStudent()
        {
            InitializeComponent();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection.Open();
            if (numberBox.Text.All(char.IsDigit))
            {
                SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM Students WHERE Id = N'{numberBox.Text}'", sqlConnection);
                object a = command.ExecuteScalar();

                sqlConnection.Close();
                if (Convert.ToInt32(a.ToString()) == 0)
                {

                    if (!(firstNameBox.Text.IsNullOrEmpty() || lastNameBox.Text.IsNullOrEmpty() || middleNameBox.Text.IsNullOrEmpty() ||
                        sexBox.Text.IsNullOrEmpty() || numberBox.Text.IsNullOrEmpty() || educationCostBox.Text.IsNullOrEmpty() || creditsCountBox.Text.IsNullOrEmpty()) &&
                        (creditsCountBox.Text.All(char.IsDigit) && (educationCostBox.Text == "Бюджетная основа" || educationCostBox.Text == "Платная основа")
                        && (sexBox.Text == "Женский" || sexBox.Text == "Мужской") && numberBox.Text.All(char.IsDigit)) && 
                        DateTime.Compare(dateTimePicker1.Value, DateTime.Today) < 0 )
                    {
                        sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
                        sqlConnection.Open();
                        SqlCommand updateTable = new SqlCommand($"INSERT INTO Students VALUES (" +
                            $"N'{firstNameBox.Text}', " +
                            $"N'{lastNameBox.Text}', " +
                            $"N'{middleNameBox.Text}', " +
                            $"N'{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', " +
                            $"N'{sexBox.Text}', " +
                            $"N'{Convert.ToInt32(numberBox.Text)}', " +
                            $"N'{educationCostBox.Text}', " +
                            $"N'{creditsCountBox.Text}', " +
                            $"N'{noteBox.Text}')", sqlConnection);
                        updateTable.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля корректно");
                    }
                }
                else
                {
                    MessageBox.Show("Номер студенческого билета не уникален");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля корректно");
            }
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {
            this.Text = $"Казаков Даниил Валерьевич ЭПИ-211 --- Логин: {SavedUserData.UserLogin} --- Роль: {SavedUserData.UserRole} --- Добавление студента";
            sexBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sexBox.Items.Add("Мужской");
            sexBox.Items.Add("Женский");
            educationCostBox.DropDownStyle = ComboBoxStyle.DropDownList;
            educationCostBox.Items.Add("Бюджетная основа");
            educationCostBox.Items.Add("Платная основа");
        }
    }
}
