namespace Курсовая_работа_БОЯП
{
    partial class UsersChange
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
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            id_checker = new TextBox();
            button1 = new Button();
            Login = new TextBox();
            Password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Role = new ComboBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(142, 35);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 45;
            button3.Text = "Поиск";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(324, 400);
            button2.Name = "button2";
            button2.Size = new Size(113, 40);
            button2.TabIndex = 44;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 29;
            label1.Text = "Введите ID";
            // 
            // id_checker
            // 
            id_checker.Location = new Point(12, 36);
            id_checker.Name = "id_checker";
            id_checker.Size = new Size(124, 23);
            id_checker.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(675, 400);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 27;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            Login.Location = new Point(12, 108);
            Login.Name = "Login";
            Login.Size = new Size(152, 23);
            Login.TabIndex = 48;
            // 
            // Password
            // 
            Password.Location = new Point(285, 108);
            Password.Name = "Password";
            Password.Size = new Size(152, 23);
            Password.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 90);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 51;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 52;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(551, 90);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 53;
            label4.Text = "Role";
            // 
            // Role
            // 
            Role.FormattingEnabled = true;
            Role.Location = new Point(551, 108);
            Role.Name = "Role";
            Role.Size = new Size(121, 23);
            Role.TabIndex = 54;
            // 
            // UsersChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Role);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Password);
            Controls.Add(Login);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(id_checker);
            Controls.Add(button1);
            Name = "UsersChange";
            Text = "UsersChange";
            Load += UsersChange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Label label1;
        private TextBox id_checker;
        private Button button1;
        private TextBox Login;
        private TextBox Password;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox Role;
    }
}