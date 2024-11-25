namespace Game2048WinFormsApp
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            playButton = new Button();
            continurButton = new Button();
            highscoreButton = new Button();
            closeButton = new Button();
            rulesButton = new Button();
            mapSizeButton = new Button();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            playButton.BackColor = SystemColors.ControlLightLight;
            playButton.Dock = DockStyle.Top;
            playButton.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            playButton.ForeColor = SystemColors.ControlDarkDark;
            playButton.Location = new Point(60, 40);
            playButton.Margin = new Padding(6);
            playButton.MinimumSize = new Size(180, 30);
            playButton.Name = "playButton";
            playButton.Size = new Size(287, 60);
            playButton.TabIndex = 0;
            playButton.Text = "РЕСТАРТ";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += playButton_Click;
            // 
            // continurButton
            // 
            continurButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            continurButton.BackColor = SystemColors.ControlLightLight;
            continurButton.Dock = DockStyle.Top;
            continurButton.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            continurButton.FlatStyle = FlatStyle.Flat;
            continurButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            continurButton.ForeColor = SystemColors.ControlDarkDark;
            continurButton.Location = new Point(60, 100);
            continurButton.Margin = new Padding(6);
            continurButton.MinimumSize = new Size(180, 30);
            continurButton.Name = "continurButton";
            continurButton.Size = new Size(287, 60);
            continurButton.TabIndex = 0;
            continurButton.Text = "ПРОДОЛЖИТЬ";
            continurButton.UseVisualStyleBackColor = false;
            continurButton.Click += continurButton_Click;
            // 
            // highscoreButton
            // 
            highscoreButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            highscoreButton.BackColor = SystemColors.ControlLightLight;
            highscoreButton.Dock = DockStyle.Top;
            highscoreButton.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            highscoreButton.FlatStyle = FlatStyle.Flat;
            highscoreButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            highscoreButton.ForeColor = SystemColors.ControlDarkDark;
            highscoreButton.Location = new Point(60, 160);
            highscoreButton.Margin = new Padding(6);
            highscoreButton.MinimumSize = new Size(180, 30);
            highscoreButton.Name = "highscoreButton";
            highscoreButton.Size = new Size(287, 60);
            highscoreButton.TabIndex = 0;
            highscoreButton.Text = "РЕКОРДЫ";
            highscoreButton.UseVisualStyleBackColor = false;
            highscoreButton.Click += highscoreButton_Click;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.BackColor = SystemColors.ControlLightLight;
            closeButton.Dock = DockStyle.Bottom;
            closeButton.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            closeButton.ForeColor = SystemColors.ControlDarkDark;
            closeButton.Location = new Point(60, 397);
            closeButton.Margin = new Padding(4);
            closeButton.MinimumSize = new Size(180, 30);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(287, 60);
            closeButton.TabIndex = 0;
            closeButton.Text = "ВЫХОД ИЗ ИГРЫ";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // rulesButton
            // 
            rulesButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rulesButton.BackColor = SystemColors.ControlLightLight;
            rulesButton.Dock = DockStyle.Top;
            rulesButton.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            rulesButton.FlatStyle = FlatStyle.Flat;
            rulesButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            rulesButton.ForeColor = SystemColors.ControlDarkDark;
            rulesButton.Location = new Point(60, 220);
            rulesButton.Margin = new Padding(6);
            rulesButton.MinimumSize = new Size(180, 30);
            rulesButton.Name = "rulesButton";
            rulesButton.Size = new Size(287, 60);
            rulesButton.TabIndex = 0;
            rulesButton.Text = "ПРАВИЛА";
            rulesButton.UseVisualStyleBackColor = false;
            rulesButton.Click += rulesButton_Click;
            // 
            // mapSizeButton
            // 
            mapSizeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mapSizeButton.BackColor = SystemColors.ControlLightLight;
            mapSizeButton.Dock = DockStyle.Top;
            mapSizeButton.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            mapSizeButton.FlatStyle = FlatStyle.Flat;
            mapSizeButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            mapSizeButton.ForeColor = SystemColors.ControlDarkDark;
            mapSizeButton.Location = new Point(60, 280);
            mapSizeButton.Margin = new Padding(6);
            mapSizeButton.MinimumSize = new Size(180, 30);
            mapSizeButton.Name = "mapSizeButton";
            mapSizeButton.Size = new Size(287, 60);
            mapSizeButton.TabIndex = 1;
            mapSizeButton.Text = "РАЗМЕР ПОЛЯ";
            mapSizeButton.UseVisualStyleBackColor = false;
            mapSizeButton.Click += mapSizeButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = continurButton;
            ClientSize = new Size(407, 497);
            Controls.Add(mapSizeButton);
            Controls.Add(closeButton);
            Controls.Add(rulesButton);
            Controls.Add(highscoreButton);
            Controls.Add(continurButton);
            Controls.Add(playButton);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MenuForm";
            Padding = new Padding(60, 40, 60, 40);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playButton;
        private Button continurButton;
        private Button highscoreButton;
        private Button closeButton;
        private Button rulesButton;
        private Button mapSizeButton;
    }
}