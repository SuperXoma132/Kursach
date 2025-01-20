namespace Курсовая_работа_БОЯП
{
    partial class AddStudent
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
            Назад = new Button();
            SuspendLayout();
            // 
            // Назад
            // 
            Назад.Location = new Point(713, 415);
            Назад.Name = "Назад";
            Назад.Size = new Size(75, 23);
            Назад.TabIndex = 1;
            Назад.Text = "Назад";
            Назад.UseVisualStyleBackColor = true;
            Назад.Click += Назад_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Назад);
            Name = "AddStudent";
            Text = "AddStudent";
            ResumeLayout(false);
        }

        #endregion

        private Button Назад;
    }
}