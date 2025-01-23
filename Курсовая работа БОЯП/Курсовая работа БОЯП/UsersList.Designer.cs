namespace Курсовая_работа_БОЯП
{
    partial class UsersList
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
            modButton = new Button();
            closeButton = new Button();
            updateButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // modButton
            // 
            modButton.Enabled = false;
            modButton.Location = new Point(395, 405);
            modButton.Name = "modButton";
            modButton.Size = new Size(179, 37);
            modButton.TabIndex = 7;
            modButton.Text = "Редактировать";
            modButton.UseVisualStyleBackColor = true;
            modButton.Click += modButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(210, 405);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(179, 37);
            closeButton.TabIndex = 6;
            closeButton.Text = "Назад";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(25, 405);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(179, 37);
            updateButton.TabIndex = 5;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(605, 396);
            dataGridView1.TabIndex = 4;
            // 
            // UsersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 449);
            Controls.Add(modButton);
            Controls.Add(closeButton);
            Controls.Add(updateButton);
            Controls.Add(dataGridView1);
            Name = "UsersList";
            Load += UsersList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button modButton;
        private Button closeButton;
        private Button updateButton;
        private DataGridView dataGridView1;
    }
}