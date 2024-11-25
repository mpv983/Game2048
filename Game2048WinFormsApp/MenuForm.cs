namespace Game2048WinFormsApp
{
    public partial class MenuForm : Form
    {
        MainForm mainForm;
        private RulesForm RulesForm = new RulesForm();
        public MenuForm()
        {
            InitializeComponent();
        }
        public MenuForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            RulesForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void continurButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            mainForm.GameReset();
            Close();
        }

        private void highscoreButton_Click(object sender, EventArgs e)
        {
            var hiscoreForm = new ResultsForm();
            hiscoreForm.ShowDialog();
        }

        private void mapSizeButton_Click(object sender, EventArgs e)
        {
            var mapSizeForm = new MapSizeForm(mainForm, this);
            mapSizeForm.ShowDialog();
        }
    }
}
