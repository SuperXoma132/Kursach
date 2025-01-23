namespace Курсовая_работа_БОЯП
{
    partial class StudentsListMod
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
            closeButton = new Button();
            numberCheckerBox = new TextBox();
            label1 = new Label();
            firstNameBox = new TextBox();
            lastNameBox = new TextBox();
            middleNameBox = new TextBox();
            creditsCountBox = new TextBox();
            noteBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            modButton = new Button();
            searchButton = new Button();
            sexBox = new ComboBox();
            label10 = new Label();
            educationCostBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Location = new Point(339, 398);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(113, 40);
            closeButton.TabIndex = 0;
            closeButton.Text = "Назад";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // numberCheckerBox
            // 
            numberCheckerBox.Location = new Point(157, 26);
            numberCheckerBox.Name = "numberCheckerBox";
            numberCheckerBox.Size = new Size(124, 23);
            numberCheckerBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 8);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите номер студенческого";
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(12, 116);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(124, 23);
            firstNameBox.TabIndex = 4;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(157, 116);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(124, 23);
            lastNameBox.TabIndex = 5;
            // 
            // middleNameBox
            // 
            middleNameBox.Location = new Point(328, 116);
            middleNameBox.Name = "middleNameBox";
            middleNameBox.Size = new Size(124, 23);
            middleNameBox.TabIndex = 6;
            // 
            // creditsCountBox
            // 
            creditsCountBox.Location = new Point(157, 211);
            creditsCountBox.Name = "creditsCountBox";
            creditsCountBox.Size = new Size(148, 23);
            creditsCountBox.TabIndex = 10;
            // 
            // noteBox
            // 
            noteBox.Location = new Point(328, 211);
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(124, 23);
            noteBox.TabIndex = 11;
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
            label3.Location = new Point(157, 98);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 13;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 98);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 14;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 193);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 15;
            label5.Text = "Дата рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 296);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 16;
            label6.Text = "Пол";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(157, 193);
            label8.Name = "label8";
            label8.Size = new Size(153, 15);
            label8.TabIndex = 18;
            label8.Text = "Количество задолжностей";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(328, 193);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 19;
            label9.Text = "Примечание";
            // 
            // modButton
            // 
            modButton.Location = new Point(12, 398);
            modButton.Name = "modButton";
            modButton.Size = new Size(113, 40);
            modButton.TabIndex = 20;
            modButton.Text = "Изменить";
            modButton.UseVisualStyleBackColor = true;
            modButton.Click += modButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(181, 55);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 21;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // sexBox
            // 
            sexBox.FormattingEnabled = true;
            sexBox.Location = new Point(331, 314);
            sexBox.Name = "sexBox";
            sexBox.Size = new Size(121, 23);
            sexBox.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 293);
            label10.Name = "label10";
            label10.Size = new Size(123, 15);
            label10.TabIndex = 24;
            label10.Text = "Стоимость обучения";
            // 
            // educationCostBox
            // 
            educationCostBox.FormattingEnabled = true;
            educationCostBox.Location = new Point(12, 311);
            educationCostBox.Name = "educationCostBox";
            educationCostBox.Size = new Size(121, 23);
            educationCostBox.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 211);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // StudentsListMod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(educationCostBox);
            Controls.Add(label10);
            Controls.Add(sexBox);
            Controls.Add(searchButton);
            Controls.Add(modButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(noteBox);
            Controls.Add(creditsCountBox);
            Controls.Add(middleNameBox);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            Controls.Add(label1);
            Controls.Add(numberCheckerBox);
            Controls.Add(closeButton);
            Name = "StudentsListMod";
            Load += StudentsListMod_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private TextBox numberCheckerBox;
        private Label label1;
        private TextBox firstNameBox;
        private TextBox lastNameBox;
        private TextBox middleNameBox;
        private TextBox creditsCountBox;
        private TextBox noteBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Button modButton;
        private Button searchButton;
        private ComboBox sexBox;
        private Label label10;
        private ComboBox educationCostBox;
        private DateTimePicker dateTimePicker1;
    }
}