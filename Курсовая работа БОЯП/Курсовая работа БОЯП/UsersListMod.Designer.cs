namespace Курсовая_работа_БОЯП
{
    partial class UsersListMod
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
            searchButton = new Button();
            changeButton = new Button();
            label1 = new Label();
            idCheckerBox = new TextBox();
            closeButton = new Button();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            roleBox = new ComboBox();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Location = new Point(142, 35);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 45;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(12, 256);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(113, 40);
            changeButton.TabIndex = 44;
            changeButton.Text = "Изменить";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
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
            // idCheckerBox
            // 
            idCheckerBox.Location = new Point(12, 36);
            idCheckerBox.Name = "idCheckerBox";
            idCheckerBox.Size = new Size(124, 23);
            idCheckerBox.TabIndex = 28;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(228, 256);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(113, 40);
            closeButton.TabIndex = 27;
            closeButton.Text = "Назад";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // loginBox
            // 
            loginBox.Location = new Point(12, 108);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(152, 23);
            loginBox.TabIndex = 48;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(189, 108);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(152, 23);
            passwordBox.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 90);
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
            label4.Location = new Point(115, 182);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 53;
            label4.Text = "Role";
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.Location = new Point(115, 200);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(121, 23);
            roleBox.TabIndex = 54;
            // 
            // UsersListMod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 308);
            Controls.Add(roleBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(searchButton);
            Controls.Add(changeButton);
            Controls.Add(label1);
            Controls.Add(idCheckerBox);
            Controls.Add(closeButton);
            Name = "UsersListMod";
            Load += UsersChange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private Button changeButton;
        private Label label1;
        private TextBox idCheckerBox;
        private Button closeButton;
        private TextBox loginBox;
        private TextBox passwordBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox roleBox;
    }
}