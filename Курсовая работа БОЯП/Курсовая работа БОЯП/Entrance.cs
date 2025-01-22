using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Курсовая_работа_БОЯП
{
    public partial class Entrance : Form
    {
        private SqlConnection sqlConnection= null;
        public Entrance()
        {
            InitializeComponent();
        }
        private void authButton_Click(object sender, EventArgs e) //авторизация
        {
            sqlConnection.Open();
            if (authLoginBox.Text == "" || authPasswordBox.Text == "")
            {
                MessageBox.Show("Необходимо заполнить поля");
            }
            else
            {
                SqlCommand usersCountCommand = new SqlCommand($"SELECT COUNT(*) FROM Users WHERE Login = N'{authLoginBox.Text}' AND Password = N'{authPasswordBox.Text}'", sqlConnection);
                object usersCount = usersCountCommand.ExecuteScalar();
                if (Convert.ToInt32(usersCount.ToString()) == 1)
                {
                    SqlCommand userRole = new SqlCommand($"SELECT Role FROM Users WHERE Login = N'{authLoginBox.Text}' AND Password = N'{authPasswordBox.Text}'", sqlConnection);
                    CurrentUserData.UserRole = userRole.ExecuteScalar().ToString().Trim();
                    SqlCommand userId = new SqlCommand($"SELECT Id FROM Users WHERE Login = N'{authLoginBox.Text}' AND Password = N'{authPasswordBox.Text}'", sqlConnection);
                    CurrentUserData.UserId = userId.ExecuteScalar().ToString().Trim();
                    SqlCommand userLogin = new SqlCommand($"SELECT Login FROM Users WHERE Login = N'{authLoginBox.Text}' AND Password = N'{authPasswordBox.Text}'", sqlConnection);
                    CurrentUserData.UserLogin = userLogin.ExecuteScalar().ToString().Trim();
                    MainPage main = new MainPage(CurrentUserData.UserLogin, CurrentUserData.UserRole);
                    this.Hide();
                    main.Show();
                    main.FormClosed += (object s, FormClosedEventArgs ev) => this.Show();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
            sqlConnection.Close();
        }
        private void regButton_Click(object sender, EventArgs e) //регистрация
        {
            sqlConnection.Open();
            if (regPasswordBox.Text == "" || regLoginBox.Text == "")
            {
                MessageBox.Show("Заполните все поля для регистрации!");
            }
            else
            {
                SqlCommand usersCountCommand = new SqlCommand($"SELECT COUNT(*) FROM Users WHERE Login = N'{regLoginBox.Text}'", sqlConnection);
                object usersCount = usersCountCommand.ExecuteScalar();
                if (Convert.ToInt32(usersCount.ToString()) == 0)
                {
                    if (!(new Regex(@"[A-Z]+").IsMatch(regPasswordBox.Text)) || !(new Regex(@".{6,25}").IsMatch(regPasswordBox.Text)) || !(new Regex(@"[0-9]+")).IsMatch(regPasswordBox.Text) ||
                        !(new Regex(@"[!@#$%^]").IsMatch(regPasswordBox.Text)))
                    {
                        MessageBox.Show("Пароль не соответствует требованиям");
                    }
                    else
                    {
                        SqlCommand getIdFromDB = new SqlCommand($"SELECT COUNT(*) FROM Users", sqlConnection);
                        string id = (Convert.ToInt32(getIdFromDB.ExecuteScalar()) + 1).ToString();
                        SqlCommand addUserToDB = new SqlCommand($"INSERT INTO Users (Id, Login, Password, Role) VALUES (N'{id}', N'{regLoginBox.Text}', N'{regPasswordBox.Text}', N'Гость')", sqlConnection);
                        addUserToDB.ExecuteNonQuery();
                        CurrentUserData.UserId = id;
                        CurrentUserData.UserRole = "Гость";
                        CurrentUserData.UserLogin = regLoginBox.Text.Trim();
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
            sqlConnection.Close();
       }
         private void Enter_Load(object sender, EventArgs e) //добавление студентов и пользователей
         {
            sqlConnection = new SqlConnection(CurrentUserData.ConnectionString);
            sqlConnection.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Корнеев', N'Александр', N'Александрович', N'2005-09-06', N'Мужской', 11, N'Бюджетная основа', 4, N'-')", sqlConnection);
            SqlCommand command2 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Казаков', N'Даниил', N'Валерьевич', '2005-07-12', N'Мужской', 8, N'Бюджетная основа', 3, N'-')", sqlConnection);
            SqlCommand command3 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Холомонов', N'Ярослав', N'Дмитриевич', '2005-06-27', N'Мужской', 27, N'Бюджетная основа', 0, N'-')", sqlConnection);
            SqlCommand command4 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Тимонин', N'Даниил', N'Максимович', '2004-08-24', N'Мужской', 25, N'Бюджетная основа', 2, N'-')", sqlConnection);
            SqlCommand command5 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Лебедев', N'Константин', N'Александрович', '2005-11-08', N'Мужской', 12, N'Платная основа', 5, N'-')", sqlConnection);
            SqlCommand command6 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Маслов', N'Егор', N'Викторович', '2005-11-23', N'Мужской', 13, N'Бюджетная основа', 0, N'-')", sqlConnection);
            SqlCommand command7 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Давыдкин', N'Дмитрий', N'Александрович', '2005-06-17', N'Мужской', 2, N'Бюджетная основа', 0, N'-')", sqlConnection);
            SqlCommand command8 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Жаркова', N'Екатерина', N'Игоревна', '2005-10-25', N'Женский', 4, N'Бюджетная основа', 0, N'-')", sqlConnection);
            SqlCommand command9 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Грасмик', N'Валерия', N'Сергеевна', '2005-03-29', N'Женский', 1, N'Бюджетная основа', 0, N'-')", sqlConnection);
            SqlCommand command10 = new SqlCommand("INSERT INTO Students (FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note) VALUES (N'Зацепин', N'Кирилл', N'Иванович', '2005-08-06', N'Мужской', 5, N'Бюджетная основа', 0, N'-')", sqlConnection);
            SqlCommand command11 = new SqlCommand("INSERT INTO Users (Id, Login, Password, Role) VALUES (N'1', N'Admin', N'123456789A', N'Администратор')", sqlConnection);
            SqlCommand command12 = new SqlCommand("INSERT INTO Users (Id, Login, Password, Role) VALUES (N'2', N'User', N'123456789U', N'Пользователь')", sqlConnection);
            SqlCommand command13 = new SqlCommand("INSERT INTO Users (Id, Login, Password, Role) VALUES (N'3', N'Guest', N'123456789G', N'Гость')", sqlConnection);
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
            command11.ExecuteNonQuery();
            command12.ExecuteNonQuery();
            command13.ExecuteNonQuery();
            this.FormClosed += (object s, FormClosedEventArgs ev) => Application.Exit();
            sqlConnection.Close();
        }
        private void Enter_FormClosing(object sender, FormClosingEventArgs e) // очистка баз данных
        {
            sqlConnection.Open();
            SqlCommand deleteStudents = new SqlCommand($"DELETE FROM Students", sqlConnection);
            deleteStudents.ExecuteNonQuery();
            SqlCommand deleteUsers = new SqlCommand($"DELETE FROM Users", sqlConnection);
            deleteUsers.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}

