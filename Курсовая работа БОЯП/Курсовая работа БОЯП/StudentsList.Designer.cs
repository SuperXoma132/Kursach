namespace Курсовая_работа_БОЯП
{
    partial class StudentsList
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
            dataGridView1 = new DataGridView();
            updateButton = new Button();
            closeButton = new Button();
            modificationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 310);
            dataGridView1.TabIndex = 0;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(91, 319);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(179, 37);
            updateButton.TabIndex = 1;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackgroundImageLayout = ImageLayout.None;
            closeButton.Cursor = Cursors.IBeam;
            closeButton.Location = new Point(276, 319);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(179, 37);
            closeButton.TabIndex = 2;
            closeButton.Text = "Назад";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // modificationButton
            // 
            modificationButton.Enabled = false;
            modificationButton.Location = new Point(461, 319);
            modificationButton.Name = "modificationButton";
            modificationButton.Size = new Size(179, 37);
            modificationButton.TabIndex = 3;
            modificationButton.Text = "Редактировать";
            modificationButton.UseVisualStyleBackColor = true;
            modificationButton.Click += modificationButton_Click;
            // 
            // StudentsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 363);
            Controls.Add(modificationButton);
            Controls.Add(closeButton);
            Controls.Add(updateButton);
            Controls.Add(dataGridView1);
            Name = "StudentsList";
            Load += StudentsList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button updateButton;
        private Button closeButton;
        private Button modificationButton;
    }
}