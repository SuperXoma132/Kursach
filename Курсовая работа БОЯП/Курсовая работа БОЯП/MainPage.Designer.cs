namespace Курсовая_работа_БОЯП
{
    partial class MainPage
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
            CloseButton = new Button();
            StudentsListButton = new Button();
            SortingButton = new Button();
            AddStudentButton = new Button();
            UsersListButton = new Button();
            StudentsListAdmin = new Button();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(333, 382);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(134, 56);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "На окно входа";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // StudentsListButton
            // 
            StudentsListButton.Location = new Point(333, 173);
            StudentsListButton.Name = "StudentsListButton";
            StudentsListButton.Size = new Size(134, 56);
            StudentsListButton.TabIndex = 1;
            StudentsListButton.Text = "Просмотр списка группы";
            StudentsListButton.UseVisualStyleBackColor = true;
            StudentsListButton.Click += StudentsListButton_Click;
            // 
            // SortingButton
            // 
            SortingButton.Location = new Point(333, 111);
            SortingButton.Name = "SortingButton";
            SortingButton.Size = new Size(134, 56);
            SortingButton.TabIndex = 2;
            SortingButton.Text = "Отбор данных";
            SortingButton.UseVisualStyleBackColor = true;
            SortingButton.Click += SortingButton_Click;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(333, 49);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(134, 56);
            AddStudentButton.TabIndex = 3;
            AddStudentButton.Text = "Добавление студента";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // UsersListButton
            // 
            UsersListButton.Location = new Point(333, 235);
            UsersListButton.Name = "UsersListButton";
            UsersListButton.Size = new Size(134, 56);
            UsersListButton.TabIndex = 4;
            UsersListButton.Text = "Просмотр списка пользователей";
            UsersListButton.UseVisualStyleBackColor = true;
            UsersListButton.Click += UsersListButton_Click;
            // 
            // StudentsListAdmin
            // 
            StudentsListAdmin.Location = new Point(333, 297);
            StudentsListAdmin.Name = "StudentsListAdmin";
            StudentsListAdmin.Size = new Size(134, 56);
            StudentsListAdmin.TabIndex = 5;
            StudentsListAdmin.Text = "Редактирование списка группы";
            StudentsListAdmin.UseVisualStyleBackColor = true;
            StudentsListAdmin.Click += StudentsListAdmin_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StudentsListAdmin);
            Controls.Add(UsersListButton);
            Controls.Add(AddStudentButton);
            Controls.Add(SortingButton);
            Controls.Add(StudentsListButton);
            Controls.Add(CloseButton);
            Name = "MainPage";
            Text = "Form4";
            Load += MainPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button CloseButton;
        private Button StudentsListButton;
        private Button SortingButton;
        private Button AddStudentButton;
        private Button UsersListButton;
        private Button StudentsListAdmin;
    }
}