using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Курсовая_работа_БОЯП
{
    public partial class Enter : Form
    {
        private SqlConnection sqlConnection1 = null;
        public SqlConnection sqlConnection2 = null;
        public Enter()
        {
            InitializeComponent();
            this.FormClosed += (object s, FormClosedEventArgs ev) => Application.Exit();
        }
        private void Enter_Load(object sender, EventArgs e)
        {
            //подключение к серверу
            sqlConnection1 = new SqlConnection(CurrentUserData.ConnectionString);
            sqlConnection1.Open();
            //добавление студентов
            SqlCommand command1 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Корнеев', N'Александр', N'Александрович', N'2005-09-06', N'Мужской', 11, N'Бюджетная основа', 4, N'-')", sqlConnection1);
            SqlCommand command2 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Казаков', N'Даниил', N'Валерьевич', '2005-07-12', N'Мужской', 8, N'Бюджетная основа', 3, N'-')", sqlConnection1);
            SqlCommand command3 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Холомонов', N'Ярослав', N'Дмитриевич', '2005-06-27', N'Мужской', 27, N'Бюджетная основа', 0, N'-')", sqlConnection1);
            SqlCommand command4 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Тимонин', N'Даниил', N'Максимович', '2004-08-24', N'Мужской', 25, N'Бюджетная основа', 2, N'-')", sqlConnection1);
            SqlCommand command5 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Лебедев', N'Константин', N'Александрович', '2005-11-08', N'Мужской', 12, N'Платная основа', 5, N'-')", sqlConnection1);
            SqlCommand command6 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Маслов', N'Егор', N'Викторович', '2005-11-23', N'Мужской', 13, N'Бюджетная основа', 0, N'-')", sqlConnection1);
            SqlCommand command7 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Давыдкин', N'Дмитрий', N'Александрович', '2005-06-17', N'Мужской', 2, N'Бюджетная основа', 0, N'-')", sqlConnection1);
            SqlCommand command8 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Жаркова', N'Екатерина', N'Игоревна', '2005-10-25', N'Женский', 4, N'Бюджетная основа', 0, N'-')", sqlConnection1);
            SqlCommand command9 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Грасмик', N'Валерия', N'Сергеевна', '2005-03-29', N'Женский', 1, N'Бюджетная основа', 0, N'-')", sqlConnection1);
            SqlCommand command10 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Зацепин', N'Кирилл', N'Иванович', '2005-08-06', N'Мужской', 5, N'Бюджетная основа', 0, N'-')", sqlConnection1);
            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            command3.ExecuteNonQuery();
            command4.ExecuteNonQuery();
            command5.ExecuteNonQuery();
            command6.ExecuteNonQuery();
            command7.ExecuteNonQuery();
            command8.ExecuteNonQuery();
            command9.ExecuteNonQuery();
            command10.ExecuteNonQuery();
            //добавление пользователей
            SqlCommand command11 = new SqlCommand("INSERT INTO Users (Id, Login, Password, Role) VALUES (N'1', N'Admin', N'123456789A', N'Администратор')", sqlConnection1);
            SqlCommand command12 = new SqlCommand("INSERT INTO Users (Id, Login, Password, Role) VALUES (N'2', N'User', N'123456789U', N'Пользователь')", sqlConnection1);
            SqlCommand command13 = new SqlCommand("INSERT INTO Users (Id, Login, Password, Role) VALUES (N'3', N'Guest', N'123456789G', N'Гость')", sqlConnection1);
            command11.ExecuteNonQuery();
            command12.ExecuteNonQuery();
            command13.ExecuteNonQuery();
        }
        private void Enter_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlCommand command1 = new SqlCommand($"DELETE FROM Students", sqlConnection1);
            SqlCommand command2 = new SqlCommand($"DELETE FROM Users", sqlConnection1);
            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            sqlConnection1.Close();

        }
        private void button1_Click(object sender, EventArgs e) //авторизация
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля");
            }
            else
            {
                SqlCommand goodUsersCountCommand = new SqlCommand($"SELECT COUNT(*) FROM Users WHERE Login = N'{textBox1.Text}' AND Password = N'{textBox2.Text}'", sqlConnection1);
                object goodUsersCount = goodUsersCountCommand.ExecuteScalar();
                if (Convert.ToInt32(goodUsersCount.ToString()) == 1)
                {
                    SqlCommand goodUserRole = new SqlCommand($"SELECT Role FROM Users WHERE Login = N'{textBox1.Text}' AND Password = N'{textBox2.Text}'", sqlConnection1);
                    SqlCommand goodUserId = new SqlCommand($"SELECT Id FROM Users WHERE Login = N'{textBox1.Text}' AND Password = N'{textBox2.Text}'", sqlConnection1);
                    SqlCommand goodUserName = new SqlCommand($"SELECT Login FROM Users WHERE Login = N'{textBox1.Text}' AND Password = N'{textBox2.Text}'", sqlConnection1);
                    CurrentUserData.UserId = goodUserId.ExecuteScalar().ToString().Trim();
                    CurrentUserData.UserRole = goodUserRole.ExecuteScalar().ToString().Trim();
                    CurrentUserData.UserLogin = goodUserName.ExecuteScalar().ToString().Trim();
                    MainPage mainPage = new MainPage(CurrentUserData.UserLogin, CurrentUserData.UserRole);
                    this.Hide();
                    mainPage.Show();
                    mainPage.FormClosed += (object s, FormClosedEventArgs ev) => this.Show();
                }
                else
                {
                    MessageBox.Show("Введен неверный логин или пароль");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e) //регистрация
        {
            if (textBox4.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Заполните все поля для регистрации!");
            }
            else
            {
                SqlCommand goodUsersCountCommand = new SqlCommand($"SELECT COUNT(*) FROM Users WHERE Login = N'{textBox3.Text}'", sqlConnection1);
                object goodUsersCount = goodUsersCountCommand.ExecuteScalar();
                if (Convert.ToInt32(goodUsersCount.ToString()) == 0)
                {
                    if (!(new Regex(@"[A-Z]+").IsMatch(textBox4.Text)) || !(new Regex(@".{6,30}").IsMatch(textBox4.Text)) || !(new Regex(@"[0-9]+")).IsMatch(textBox4.Text) ||
                        !(new Regex(@"[!@#$%^]").IsMatch(textBox4.Text)))
                    {
                        MessageBox.Show("Пароль не соответствует требованиям");
                    }
                    else
                    {
                        SqlCommand getIdFromDB = new SqlCommand($"SELECT COUNT(*) FROM Users", sqlConnection1);
                        string id = (Convert.ToInt32(getIdFromDB.ExecuteScalar()) + 1).ToString();
                        SqlCommand addUserToDB = new SqlCommand($"INSERT INTO Users (Id, Login, Password, Role) VALUES (N'{id}', N'{textBox3.Text}', N'{textBox4.Text}', N'Гость')", sqlConnection1);
                        addUserToDB.ExecuteNonQuery();
                        CurrentUserData.UserId = id;
                        CurrentUserData.UserRole = "Гость";
                        CurrentUserData.UserLogin = textBox3.Text.Trim();
                        MainPage mainPage = new MainPage(CurrentUserData.UserLogin, CurrentUserData.UserRole);
                        this.Hide();
                        mainPage.Show();
                        mainPage.FormClosed += (object s, FormClosedEventArgs ev) => this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
                }
            }
        }
    }
}

