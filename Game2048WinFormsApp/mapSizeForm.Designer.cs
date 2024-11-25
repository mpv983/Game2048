namespace Game2048WinFormsApp
{
    partial class MapSizeForm
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
            label1 = new Label();
            radioButton_3x3 = new RadioButton();
            radioButton_4x4 = new RadioButton();
            radioButton_5x5 = new RadioButton();
            radioButton_6x6 = new RadioButton();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 32);
            label1.TabIndex = 0;
            label1.Text = "Выберите размер поля";
            // 
            // radioButton_3x3
            // 
            radioButton_3x3.AutoSize = true;
            radioButton_3x3.Location = new Point(26, 62);
            radioButton_3x3.Name = "radioButton_3x3";
            radioButton_3x3.Size = new Size(76, 36);
            radioButton_3x3.TabIndex = 1;
            radioButton_3x3.TabStop = true;
            radioButton_3x3.Text = "3х3";
            radioButton_3x3.UseVisualStyleBackColor = true;
            // 
            // radioButton_4x4
            // 
            radioButton_4x4.AutoSize = true;
            radioButton_4x4.Checked = true;
            radioButton_4x4.Location = new Point(26, 104);
            radioButton_4x4.Name = "radioButton_4x4";
            radioButton_4x4.Size = new Size(76, 36);
            radioButton_4x4.TabIndex = 1;
            radioButton_4x4.TabStop = true;
            radioButton_4x4.Text = "4х4";
            radioButton_4x4.UseVisualStyleBackColor = true;
            // 
            // radioButton_5x5
            // 
            radioButton_5x5.AutoSize = true;
            radioButton_5x5.Location = new Point(26, 146);
            radioButton_5x5.Name = "radioButton_5x5";
            radioButton_5x5.Size = new Size(76, 36);
            radioButton_5x5.TabIndex = 1;
            radioButton_5x5.TabStop = true;
            radioButton_5x5.Text = "5х5";
            radioButton_5x5.UseVisualStyleBackColor = true;
            // 
            // radioButton_6x6
            // 
            radioButton_6x6.AutoSize = true;
            radioButton_6x6.Location = new Point(26, 188);
            radioButton_6x6.Name = "radioButton_6x6";
            radioButton_6x6.Size = new Size(76, 36);
            radioButton_6x6.TabIndex = 1;
            radioButton_6x6.TabStop = true;
            radioButton_6x6.Text = "6х6";
            radioButton_6x6.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            okButton.Location = new Point(12, 256);
            okButton.Name = "okButton";
            okButton.Size = new Size(140, 40);
            okButton.TabIndex = 2;
            okButton.Text = "ОК";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Location = new Point(165, 256);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(140, 40);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // MapSizeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 308);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(radioButton_6x6);
            Controls.Add(radioButton_5x5);
            Controls.Add(radioButton_4x4);
            Controls.Add(radioButton_3x3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "MapSizeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "mapSizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton_3x3;
        private RadioButton radioButton_4x4;
        private RadioButton radioButton_5x5;
        private RadioButton radioButton_6x6;
        private Button okButton;
        private Button cancelButton;
    }
}