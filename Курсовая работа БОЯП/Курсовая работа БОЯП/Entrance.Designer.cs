namespace Курсовая_работа_БОЯП
{
    partial class Entrance
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Auth = new TabPage();
            label2 = new Label();
            label1 = new Label();
            authPasswordBox = new TextBox();
            authLoginBox = new TextBox();
            authButton = new Button();
            tabPage2 = new TabPage();
            label3 = new Label();
            label4 = new Label();
            regPasswordBox = new TextBox();
            regLoginBox = new TextBox();
            regButton = new Button();
            tabControl1.SuspendLayout();
            Auth.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Auth);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(401, 303);
            tabControl1.TabIndex = 2;
            // 
            // Auth
            // 
            Auth.Controls.Add(label2);
            Auth.Controls.Add(label1);
            Auth.Controls.Add(authPasswordBox);
            Auth.Controls.Add(authLoginBox);
            Auth.Controls.Add(authButton);
            Auth.Location = new Point(4, 24);
            Auth.Name = "Auth";
            Auth.Padding = new Padding(3);
            Auth.Size = new Size(393, 275);
            Auth.TabIndex = 0;
            Auth.Text = "Авторизация";
            Auth.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 107);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 26);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // authPasswordBox
            // 
            authPasswordBox.Location = new Point(101, 125);
            authPasswordBox.Name = "authPasswordBox";
            authPasswordBox.Size = new Size(176, 23);
            authPasswordBox.TabIndex = 2;
            // 
            // authLoginBox
            // 
            authLoginBox.Location = new Point(101, 44);
            authLoginBox.Name = "authLoginBox";
            authLoginBox.Size = new Size(176, 23);
            authLoginBox.TabIndex = 1;
            // 
            // authButton
            // 
            authButton.Location = new Point(130, 206);
            authButton.Name = "authButton";
            authButton.Size = new Size(117, 43);
            authButton.TabIndex = 0;
            authButton.Text = "Авторизация";
            authButton.UseVisualStyleBackColor = true;
            authButton.Click += authButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(regPasswordBox);
            tabPage2.Controls.Add(regLoginBox);
            tabPage2.Controls.Add(regButton);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(393, 275);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Регистрация";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 126);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 9;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 56);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Логин";
            // 
            // regPasswordBox
            // 
            regPasswordBox.Location = new Point(101, 144);
            regPasswordBox.Name = "regPasswordBox";
            regPasswordBox.Size = new Size(176, 23);
            regPasswordBox.TabIndex = 7;
            // 
            // regLoginBox
            // 
            regLoginBox.Location = new Point(101, 74);
            regLoginBox.Name = "regLoginBox";
            regLoginBox.Size = new Size(176, 23);
            regLoginBox.TabIndex = 6;
            // 
            // regButton
            // 
            regButton.Location = new Point(131, 191);
            regButton.Name = "regButton";
            regButton.Size = new Size(117, 43);
            regButton.TabIndex = 5;
            regButton.Text = "Регистрация";
            regButton.UseVisualStyleBackColor = true;
            regButton.Click += regButton_Click;
            // 
            // Entrance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 315);
            Controls.Add(tabControl1);
            Name = "Entrance";
            Text = "Казаков Даниил ЭПИ-211";
            FormClosing += Enter_FormClosing;
            Load += Enter_Load;
            tabControl1.ResumeLayout(false);
            Auth.ResumeLayout(false);
            Auth.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Auth;
        private TabPage tabPage2;
        private Button authButton;
        private Label label2;
        private Label label1;
        private TextBox authPasswordBox;
        private TextBox authLoginBox;
        private Label label3;
        private Label label4;
        private TextBox regPasswordBox;
        private TextBox regLoginBox;
        private Button regButton;
    }
}
