using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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
            sqlConnection1 = new SqlConnection(CurrentUserData.ConnectionString);
            sqlConnection1.Open();
            DataTable table = new DataTable();
            string id = textBox2.Text.Trim();

            SqlCommand getInfoCommand = new SqlCommand($"SELECT FirstName, LastName, MiddleName, Birthday, Sex, Id, EducationCost, CreditsCount, Note FROM Students WHERE Id = N'{id}'", sqlConnection1);
            SqlDataReader getInfo = getInfoCommand.ExecuteReader();
            while (getInfo.Read())
            {
                textBox1.Text = getInfo[0].ToString();
                textBox3.Text = getInfo[1].ToString();
                textBox4.Text = getInfo[2].ToString();
                textBox5.Text = getInfo[3].ToString();
                comboBox1.Text = getInfo[4].ToString();
                textBox7.Text = getInfo[5].ToString();
                textBox6.Text = getInfo[6].ToString();
                textBox8.Text = getInfo[7].ToString();
                textBox9.Text = getInfo[8].ToString();
            }


        }

        private void StudentsChange_Load(object sender, EventArgs e)
        {
            this.Text = $" Корнеев Александр Александрович, Логин: {CurrentUserData.UserLogin}, Роль: {CurrentUserData.UserRole}, Список группы";
        }
    }
}
