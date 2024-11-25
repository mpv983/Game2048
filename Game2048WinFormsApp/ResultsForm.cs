namespace Game2048WinFormsApp
{
    public partial class ResultsForm : Form
    {
        HiscoreStorage hiscoreStorage = new HiscoreStorage();
        User user = new User(string.Empty);
        List<User> hiscores = new List<User>();
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            GetSortedHiScore();
            CreateDataGridView();
        }

        private void GetSortedHiScore()
        {
            hiscores = hiscoreStorage.GetAll().OrderByDescending(x => x.Score).ToList();
        }

        private void CreateDataGridView()
        {
            dataGridView.DataSource = hiscores;
            dataGridView.Columns["Name"].HeaderText = "Имя";
            dataGridView.Columns["Score"].HeaderText = "Очки";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hiscoreStorage.Clear();
            GetSortedHiScore();
            dataGridView.DataSource = hiscores;
        }
    }
}
