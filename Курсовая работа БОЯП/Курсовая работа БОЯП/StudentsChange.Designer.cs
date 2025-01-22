namespace Курсовая_работа_БОЯП
{
    partial class StudentsChange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            id_checker = new TextBox();
            label1 = new Label();
            Firstname = new TextBox();
            LastName = new TextBox();
            MiddleName = new TextBox();
            ID = new TextBox();
            CreditsCount = new TextBox();
            Note = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            button3 = new Button();
            Sex = new ComboBox();
            label10 = new Label();
            EducationCost = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(675, 398);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // id_checker
            // 
            id_checker.Location = new Point(12, 34);
            id_checker.Name = "id_checker";
            id_checker.Size = new Size(124, 23);
            id_checker.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите ID";
            // 
            // Firstname
            // 
            Firstname.Location = new Point(12, 116);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(124, 23);
            Firstname.TabIndex = 4;
            // 
            // LastName
            // 
            LastName.Location = new Point(181, 116);
            LastName.Name = "LastName";
            LastName.Size = new Size(124, 23);
            LastName.TabIndex = 5;
            // 
            // MiddleName
            // 
            MiddleName.Location = new Point(350, 116);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(124, 23);
            MiddleName.TabIndex = 6;
            // 
            // ID
            // 
            ID.Enabled = false;
            ID.Location = new Point(181, 248);
            ID.Name = "ID";
            ID.Size = new Size(124, 23);
            ID.TabIndex = 9;
            ID.TextChanged += ID_TextChanged;
            // 
            // CreditsCount
            // 
            CreditsCount.Location = new Point(350, 248);
            CreditsCount.Name = "CreditsCount";
            CreditsCount.Size = new Size(124, 23);
            CreditsCount.TabIndex = 10;
            // 
            // Note
            // 
            Note.Location = new Point(521, 248);
            Note.Name = "Note";
            Note.Size = new Size(124, 23);
            Note.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 12;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 98);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 13;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 98);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 14;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(521, 98);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 15;
            label5.Text = "Дата рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 230);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 16;
            label6.Text = "Пол";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(181, 230);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 17;
            label7.Text = "Номер билета";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(350, 230);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 18;
            label8.Text = "Количество долгов";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(521, 230);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 19;
            label9.Text = "Примечание";
            // 
            // button2
            // 
            button2.Location = new Point(324, 398);
            button2.Name = "button2";
            button2.Size = new Size(113, 40);
            button2.TabIndex = 20;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(142, 33);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 21;
            button3.Text = "Поиск";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Sex
            // 
            Sex.FormattingEnabled = true;
            Sex.Location = new Point(12, 248);
            Sex.Name = "Sex";
            Sex.Size = new Size(121, 23);
            Sex.TabIndex = 22;
            Sex.SelectedIndexChanged += Sex_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 330);
            label10.Name = "label10";
            label10.Size = new Size(123, 15);
            label10.TabIndex = 24;
            label10.Text = "Стоимость обучения";
            // 
            // EducationCost
            // 
            EducationCost.FormattingEnabled = true;
            EducationCost.Location = new Point(12, 348);
            EducationCost.Name = "EducationCost";
            EducationCost.Size = new Size(121, 23);
            EducationCost.TabIndex = 25;
            EducationCost.SelectedIndexChanged += EducationCost_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(521, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // StudentsChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(EducationCost);
            Controls.Add(label10);
            Controls.Add(Sex);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Note);
            Controls.Add(CreditsCount);
            Controls.Add(ID);
            Controls.Add(MiddleName);
            Controls.Add(LastName);
            Controls.Add(Firstname);
            Controls.Add(label1);
            Controls.Add(id_checker);
            Controls.Add(button1);
            Name = "StudentsChange";
            Text = "StudentsChange";
            Load += StudentsChange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox id_checker;
        private Label label1;
        private TextBox Firstname;
        private TextBox LastName;
        private TextBox MiddleName;
        private TextBox ID;
        private TextBox CreditsCount;
        private TextBox Note;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button2;
        private Button button3;
        private ComboBox Sex;
        private Label label10;
        private ComboBox EducationCost;
        private DateTimePicker dateTimePicker1;
    }
}