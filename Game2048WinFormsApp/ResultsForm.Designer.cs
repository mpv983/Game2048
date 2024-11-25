namespace Game2048WinFormsApp
{
    partial class ResultsForm
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
            dataGridView = new DataGridView();
            closeButton = new Button();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(13, 14);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(597, 490);
            dataGridView.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            closeButton.Font = new Font("Segoe UI", 11F);
            closeButton.Location = new Point(418, 526);
            closeButton.Margin = new Padding(4, 5, 4, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(192, 68);
            closeButton.TabIndex = 2;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clearButton.Font = new Font("Segoe UI", 11F);
            clearButton.Location = new Point(13, 526);
            clearButton.Margin = new Padding(4, 5, 4, 5);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(192, 68);
            clearButton.TabIndex = 2;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += this.clearButton_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 608);
            Controls.Add(clearButton);
            Controls.Add(closeButton);
            Controls.Add(dataGridView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ResultsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Результаты";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView;
        private Button closeButton;
        private Button clearButton;
    }
}