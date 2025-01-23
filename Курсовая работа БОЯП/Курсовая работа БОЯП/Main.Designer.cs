namespace Курсовая_работа_БОЯП
{
    partial class Main
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
            studentsListButton = new Button();
            dataProcessingButton = new Button();
            addStudentButton = new Button();
            usersListButton = new Button();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Location = new Point(73, 325);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(134, 56);
            closeButton.TabIndex = 0;
            closeButton.Text = "На окно входа";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // studentsListButton
            // 
            studentsListButton.Location = new Point(73, 116);
            studentsListButton.Name = "studentsListButton";
            studentsListButton.Size = new Size(134, 56);
            studentsListButton.TabIndex = 1;
            studentsListButton.Text = "Список группы";
            studentsListButton.UseVisualStyleBackColor = true;
            studentsListButton.Click += studentsListButton_Click;
            // 
            // dataProcessingButton
            // 
            dataProcessingButton.Location = new Point(73, 178);
            dataProcessingButton.Name = "dataProcessingButton";
            dataProcessingButton.Size = new Size(134, 56);
            dataProcessingButton.TabIndex = 2;
            dataProcessingButton.Text = "Отбор данных и сортировка";
            dataProcessingButton.UseVisualStyleBackColor = true;
            dataProcessingButton.Click += dataProcessingButton_Click;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(73, 240);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(134, 56);
            addStudentButton.TabIndex = 3;
            addStudentButton.Text = "Добавление студента в базу данных";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // usersListButton
            // 
            usersListButton.Location = new Point(73, 54);
            usersListButton.Name = "usersListButton";
            usersListButton.Size = new Size(134, 56);
            usersListButton.TabIndex = 4;
            usersListButton.Text = "Список пользователей";
            usersListButton.UseVisualStyleBackColor = true;
            usersListButton.Click += usersListButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 450);
            Controls.Add(usersListButton);
            Controls.Add(addStudentButton);
            Controls.Add(dataProcessingButton);
            Controls.Add(studentsListButton);
            Controls.Add(closeButton);
            Name = "Main";
            Text = "Form4";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button closeButton;
        private Button studentsListButton;
        private Button dataProcessingButton;
        private Button addStudentButton;
        private Button usersListButton;
    }
}