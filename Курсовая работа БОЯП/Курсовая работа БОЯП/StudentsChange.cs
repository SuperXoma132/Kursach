using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace Курсовая_работа_БОЯП
{
    public partial class StudentsChange : Form
    {
        private SqlConnection sqlConnection1 = null;
        public StudentsChange()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e) // поиск
        {
            sqlConnection1 = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection1.Open();
            DataTable table = new DataTable();
            string id = id_checker.Text.Trim();
            SqlCommand getInfoCommand = new SqlCommand($"SELECT FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note FROM Students WHERE Id = N'{id}'", sqlConnection1);
            SqlDataReader getInfo = getInfoCommand.ExecuteReader();
            if (getInfo.HasRows)
            {
                while (getInfo.Read())
                {
                    Firstname.Text = getInfo[0].ToString();
                    LastName.Text = getInfo[1].ToString();
                    MiddleName.Text = getInfo[2].ToString();
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss";
                    dateTimePicker1.Value = DateTime.Parse(getInfo[3].ToString());
                    Sex.Text = getInfo[4].ToString();
                    ID.Text = getInfo[5].ToString();
                    EducationCost.Text = getInfo[6].ToString();
                    CreditsCount.Text = getInfo[7].ToString();
                    Note.Text = getInfo[8].ToString();
                }
            }
            else
            {
                MessageBox.Show("Студента с таким номером не существует");
                Firstname.Text = "";
                LastName.Text = "";
                MiddleName.Text = "";
                Sex.Text = "";
                ID.Text = "";
                EducationCost.Text = "";
                CreditsCount.Text = "";
                Note.Text = "";
                dateTimePicker1.CustomFormat = " ";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
            }
        }
        private void StudentsChange_Load(object sender, EventArgs e)
        {
            this.Text = $" Корнеев Александр Александрович, Логин: {SavedUserData.UserLogin}, Роль: {SavedUserData.UserRole}, Редактирование студентов";
            Sex.DropDownStyle = ComboBoxStyle.DropDown;
            EducationCost.DropDownStyle = ComboBoxStyle.DropDown;
            Sex.Items.Add("Мужской");
            Sex.Items.Add("Женский");
            EducationCost.Items.Add("Бюджетная основа");
            EducationCost.Items.Add("Платная основа");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection1 = new SqlConnection(SavedUserData.ConnectionString);
            sqlConnection1.Open();
            int number;
            if (!(Firstname.Text.IsNullOrEmpty() || LastName.Text.IsNullOrEmpty() || MiddleName.Text.IsNullOrEmpty() ||
                Sex.Text.IsNullOrEmpty() || ID.Text.IsNullOrEmpty() || EducationCost.Text.IsNullOrEmpty() || CreditsCount.Text.IsNullOrEmpty()) &&
                (ID.Text.All(char.IsDigit) && (EducationCost.Text == "Бюджетная основа" || EducationCost.Text == "Платная основа")
                && (Sex.Text == "Женский" || Sex.Text == "Мужской") && dateTimePicker1.Value.Year < 2025 && CreditsCount.Text.All(char.IsDigit)))
            {
                    sqlConnection1 = new SqlConnection(SavedUserData.ConnectionString);
                    sqlConnection1.Open();
                    SqlCommand updateTable = new SqlCommand($"UPDATE Students SET " +
                        $"FirstName = N'{Firstname.Text}', " +
                        $"LastName = N'{LastName.Text}', " +
                        $"MiddleName = N'{MiddleName.Text}', " +
                        $"Birthday = N'{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', " +
                        $"Sex = N'{Sex.Text}', " +
                        $"Id = N'{ID.Text}', " +
                        $"EducationCost = N'{EducationCost.Text}', " +
                        $"CreditsCount = N'{CreditsCount.Text}', " +
                        $"Note = N'{Note.Text}' WHERE Id = N'{ID.Text}'", sqlConnection1);
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
    }
}
