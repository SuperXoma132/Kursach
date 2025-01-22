namespace Курсовая_работа_БОЯП
{
    partial class Enter
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            tabPage2 = new TabPage();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            tabControl1.SuspendLayout();
            Auth.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Auth);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 15);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(385, 413);
            tabControl1.TabIndex = 2;
            // 
            // Auth
            // 
            Auth.Controls.Add(label2);
            Auth.Controls.Add(label1);
            Auth.Controls.Add(textBox2);
            Auth.Controls.Add(textBox1);
            Auth.Controls.Add(button1);
            Auth.Location = new Point(4, 24);
            Auth.Name = "Auth";
            Auth.Padding = new Padding(3);
            Auth.Size = new Size(377, 385);
            Auth.TabIndex = 0;
            Auth.Text = "Авторизация";
            Auth.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 183);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 105);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(126, 314);
            button1.Name = "button1";
            button1.Size = new Size(117, 43);
            button1.TabIndex = 0;
            button1.Text = "Вход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(377, 385);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Регистрация";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 144);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 9;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 66);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Логин";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(100, 162);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 84);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 23);
            textBox3.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(133, 275);
            button2.Name = "button2";
            button2.Size = new Size(117, 43);
            button2.TabIndex = 5;
            button2.Text = "Регистрация";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Enter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 440);
            Controls.Add(tabControl1);
            Name = "Enter";
            Text = "Welcome";
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
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button2;
    }
}
