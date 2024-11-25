namespace Game2048WinFormsApp
{
    partial class MainForm
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
            titleHighscoreLabel = new Label();
            highscoreLabel = new Label();
            scoreLabel = new Label();
            titleScoreLabel = new Label();
            label1 = new Label();
            footerPanel = new Panel();
            label2 = new Label();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleHighscoreLabel
            // 
            titleHighscoreLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            titleHighscoreLabel.AutoSize = true;
            titleHighscoreLabel.Location = new Point(273, 5);
            titleHighscoreLabel.Margin = new Padding(2, 0, 2, 0);
            titleHighscoreLabel.Name = "titleHighscoreLabel";
            titleHighscoreLabel.Size = new Size(46, 15);
            titleHighscoreLabel.TabIndex = 0;
            titleHighscoreLabel.Text = "Рекорд";
            // 
            // highscoreLabel
            // 
            highscoreLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            highscoreLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            highscoreLabel.ForeColor = Color.FromArgb(255, 183, 3);
            highscoreLabel.Location = new Point(215, 20);
            highscoreLabel.Margin = new Padding(2, 0, 2, 0);
            highscoreLabel.Name = "highscoreLabel";
            highscoreLabel.Size = new Size(114, 27);
            highscoreLabel.TabIndex = 0;
            highscoreLabel.Text = "012328";
            highscoreLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // scoreLabel
            // 
            scoreLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            scoreLabel.ForeColor = SystemColors.ControlDarkDark;
            scoreLabel.Location = new Point(10, 20);
            scoreLabel.Margin = new Padding(2, 0, 2, 0);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(100, 27);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "0";
            scoreLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // titleScoreLabel
            // 
            titleScoreLabel.AutoSize = true;
            titleScoreLabel.Location = new Point(12, 5);
            titleScoreLabel.Margin = new Padding(2, 0, 2, 0);
            titleScoreLabel.Name = "titleScoreLabel";
            titleScoreLabel.Size = new Size(39, 15);
            titleScoreLabel.TabIndex = 0;
            titleScoreLabel.Text = "Очки:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(11, 3);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "Esc";
            // 
            // footerPanel
            // 
            footerPanel.Controls.Add(label2);
            footerPanel.Controls.Add(label1);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 320);
            footerPanel.Margin = new Padding(2, 2, 2, 2);
            footerPanel.MaximumSize = new Size(0, 24);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(340, 24);
            footerPanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(35, 3);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 0;
            label2.Text = "для выхода в меню";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(340, 344);
            Controls.Add(titleHighscoreLabel);
            Controls.Add(footerPanel);
            Controls.Add(highscoreLabel);
            Controls.Add(scoreLabel);
            Controls.Add(titleScoreLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            footerPanel.ResumeLayout(false);
            footerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label titleScoreLabel;
        private Label titleHighscoreLabel;
        private Label scoreLabel;
        private Label highscoreLabel;
        private Label label1;
        private Panel footerPanel;
        private Label label2;
    }
}
