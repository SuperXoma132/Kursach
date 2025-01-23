using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace Курсовая_работа_БОЯП
{
    public partial class StudentsListMod : Form
    {
        private SqlConnection sqlConnection = null;
        public StudentsListMod()
        {
            InitializeComponent();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection.Open();
            DataTable table = new DataTable();
            string id = numberCheckerBox.Text.Trim();
            SqlCommand getInfoCommand = new SqlCommand($"SELECT FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note FROM Students WHERE Id = N'{id}'", sqlConnection);
            SqlDataReader getInfo = getInfoCommand.ExecuteReader();
            if (getInfo.HasRows)
            {
                while (getInfo.Read())
                {
                    firstNameBox.Text = getInfo[0].ToString();
                    lastNameBox.Text = getInfo[1].ToString();
                    middleNameBox.Text = getInfo[2].ToString();
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss";
                    dateTimePicker1.Value = DateTime.Parse(getInfo[3].ToString());
                    sexBox.Text = getInfo[4].ToString();
                    numberCheckerBox.Text = getInfo[5].ToString();
                    educationCostBox.Text = getInfo[6].ToString();
                    creditsCountBox.Text = getInfo[7].ToString();
                    noteBox.Text = getInfo[8].ToString();
                }
            }
            else
            {
                MessageBox.Show("Студента с таким номером нет в базе");
                firstNameBox.Text = "";
                lastNameBox.Text = "";
                middleNameBox.Text = "";
                sexBox.Text = "";
                numberCheckerBox.Text = "";
                educationCostBox.Text = "";
                creditsCountBox.Text = "";
                noteBox.Text = "";
                dateTimePicker1.CustomFormat = " ";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
            }
        }
        private void modButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection.Open();
            if (!(firstNameBox.Text.IsNullOrEmpty() || lastNameBox.Text.IsNullOrEmpty() || middleNameBox.Text.IsNullOrEmpty() ||
                sexBox.Text.IsNullOrEmpty() || numberCheckerBox.Text.IsNullOrEmpty() || educationCostBox.Text.IsNullOrEmpty() || 
                creditsCountBox.Text.IsNullOrEmpty()) && (numberCheckerBox.Text.All(char.IsDigit) && (educationCostBox.Text == "Бюджетная основа" ||
                educationCostBox.Text == "Платная основа") && (sexBox.Text == "Женский" || sexBox.Text == "Мужской") &&
                DateTime.Compare(dateTimePicker1.Value, DateTime.Today) < 0 && creditsCountBox.Text.All(char.IsDigit)))
            {
                    sqlConnection = new SqlConnection(SavedUserData.ConnectionString);
                    sqlConnection.Open();
                    SqlCommand updateTable = new SqlCommand($"UPDATE Students SET " +
                        $"FirstName = N'{firstNameBox.Text}', " +
                        $"LastName = N'{lastNameBox.Text}', " +
                        $"MiddleName = N'{middleNameBox.Text}', " +
                        $"Birthday = N'{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', " +
                        $"Sex = N'{sexBox.Text}', " +
                        $"Id = N'{numberCheckerBox.Text}', " +
                        $"EducationCost = N'{educationCostBox.Text}', " +
                        $"CreditsCount = N'{creditsCountBox.Text}', " +
                        $"Note = N'{noteBox.Text}' WHERE Id = N'{numberCheckerBox.Text}'", sqlConnection);
                    updateTable.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Заполните все поля правильно");
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void StudentsListMod_Load(object sender, EventArgs e)
        {
            this.Text = $"Казаков Даниил Валерьевич ЭПИ-211 --- Логин: {SavedUserData.UserLogin} --- Роль: {SavedUserData.UserRole} --- Редактирование студентов";
            sexBox.DropDownStyle = ComboBoxStyle.DropDown;
            sexBox.Items.Add("Мужской");
            sexBox.Items.Add("Женский");
            educationCostBox.DropDownStyle = ComboBoxStyle.DropDown;
            educationCostBox.Items.Add("Бюджетная основа");
            educationCostBox.Items.Add("Платная основа");
        }
    }
}
