﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace Курсовая_работа_БОЯП
{
    public partial class AddStudent : Form
    {
        SqlConnection sqlConnection1 = null;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1 = new SqlConnection(CurrentUserData.ConnectionString);
            sqlConnection1.Open();
            int number; int number1;
            if (ID.Text.All(char.IsDigit))
            {
                SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM Students WHERE Id = N'{ID.Text}'", sqlConnection1);
                object a = command.ExecuteScalar();

                sqlConnection1.Close();
                if (Convert.ToInt32(a.ToString()) == 0)
                {

                    if (!(Firstname.Text.IsNullOrEmpty() || LastName.Text.IsNullOrEmpty() || MiddleName.Text.IsNullOrEmpty() ||
                        Sex.Text.IsNullOrEmpty() || ID.Text.IsNullOrEmpty() || EducationCost.Text.IsNullOrEmpty() || CreditsCount.Text.IsNullOrEmpty()) &&
                        (CreditsCount.Text.All(char.IsDigit) && (EducationCost.Text == "Бюджетная основа" || EducationCost.Text == "Платная основа")
                        && (Sex.Text == "Женский" || Sex.Text == "Мужской") && ID.Text.All(char.IsDigit)) && dateTimePicker1.Value.Year < 2025)
                    {
                        sqlConnection1 = new SqlConnection(CurrentUserData.ConnectionString);
                        sqlConnection1.Open();
                        SqlCommand updateTable = new SqlCommand($"INSERT INTO Students VALUES (" +
                            $"N'{Firstname.Text}', " +
                            $"N'{LastName.Text}', " +
                            $"N'{MiddleName.Text}', " +
                            $"N'{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', " +
                            $"N'{Sex.Text}', " +
                            $"N'{Convert.ToInt32(ID.Text)}', " +
                            $"N'{EducationCost.Text}', " +
                            $"N'{CreditsCount.Text}', " +
                            $"N'{Note.Text}')", sqlConnection1);
                        updateTable.ExecuteNonQuery();
                        MessageBox.Show("Успешно");
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
            this.Text = $" Корнеев Александр Александрович, Логин: {CurrentUserData.UserLogin}, Роль: {CurrentUserData.UserRole}, Редактирование студентов";
            Sex.DropDownStyle = ComboBoxStyle.DropDownList;
            EducationCost.DropDownStyle = ComboBoxStyle.DropDownList;
            Sex.Items.Add("Мужской");
            Sex.Items.Add("Женский");
            EducationCost.Items.Add("Бюджетная основа");
            EducationCost.Items.Add("Платная основа");
        }
    }
}
