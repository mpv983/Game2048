using System.Drawing;

namespace Game2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private Label[,] labelsMap;
        public int MapSize = 4;
        private int labelSize = 100;
        int padding = 20;
        int topPanel = 60;
        private int margin = 10;
        private Single fontSize = 16F;

        private static Random random = new Random();
        public int Score = 0;
        public int HiScore = 0;
        private MenuForm menu;
        public User User;
        public HiscoreStorage HiscoreStorage;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menu = new MenuForm(this);
            User = new User("Ќеизвестно");
            HiscoreStorage = new HiscoreStorage();
            GameStart();
        }

        private void MainWindowSize()
        {
            var x = padding + MapSize * (labelSize + margin) + padding - margin;
            var y = topPanel + padding + MapSize * (labelSize + margin) + footerPanel.Height + padding - margin;
            this.ClientSize = new Size(x, y);
        }

        private void ShowScore()
        {
            scoreLabel.Text = Score.ToString();
            if (Score >= HiScore)
            {
                HiScore = Score;
            }
            highscoreLabel.Text = HiScore.ToString();
        }

        private bool EndGame()
        {
            var countFullCells = 0;
            foreach (var label in labelsMap)
            {
                if (label.Text != string.Empty)
                {
                    countFullCells++;
                }
            }
            if (countFullCells == MapSize * MapSize)
            {
                return true;
            }
            return false;
        }

        private void GenerateNumber()
        {
            var number = RandomNumber.GetRandomNumber();
            while (true)
            {
                var randomNamberLabel = random.Next(MapSize * MapSize);
                var indexRow = randomNamberLabel / MapSize;
                var indexColumn = randomNamberLabel % MapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    labelsMap[indexRow, indexColumn].Text = number.ToString();
                    labelsMap[indexRow, indexColumn].BackColor = SetColor(number);

                    break;
                }
            }
        }

        private void InitMap()
        {
            labelsMap = new Label[MapSize, MapSize];
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    this.Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }


        private Label CreateLabel(int indexRow, int indexColumn)
        {
            Label label = new Label();
            label.BackColor = SetColor(0);
            label.Font = new Font("Segoe UI", fontSize, FontStyle.Bold);
            label.Size = new Size(labelSize, labelSize);
            label.TextAlign = ContentAlignment.MiddleCenter;
            var x = padding + indexColumn * (labelSize + margin);
            var y = topPanel + padding + indexRow * (labelSize + margin);
            label.Location = new Point(x, y);
            label.TextChanged += Label_TextChanged;

            return label;
        }

        private void Label_TextChanged(object? sender, EventArgs e)
        {
            var label = (Label)sender;
            if (label.Text != "")
            {
                label.BackColor = SetColor(Convert.ToInt32(label.Text));
            }
            else label.BackColor = SetColor(0);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            var isChanged = false;
            if (e.KeyCode == Keys.Escape)
            {
                //menu.Size = this.Size;
                menu.ShowDialog();
            }
            if (e.KeyCode == Keys.Left)
            {
                isChanged = true;
                //сложение €чеек
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = 0; j < MapSize; j++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k < MapSize; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = Convert.ToInt32(labelsMap[i, j].Text) * 2;
                                        Score += number;
                                        labelsMap[i, j].Text = number.ToString();
                                        labelsMap[i, k].Text = string.Empty;
                                        //j = -1;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                //сдвиг €чеек
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = 0; j < MapSize; j++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j + 1; k < MapSize; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                isChanged = true;
                //сложение €чеек
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = MapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = Convert.ToInt32(labelsMap[i, j].Text) * 2;
                                        Score += number;
                                        labelsMap[i, j].Text = number.ToString();
                                        labelsMap[i, k].Text = string.Empty;

                                        //j = mapSize;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                //сдвиг €чеек
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = MapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }

            }
            if (e.KeyCode == Keys.Up)
            {
                isChanged = true;
                //сложение €чеек
                for (int j = 0; j < MapSize; j++)
                {
                    for (int i = 0; i < MapSize; i++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i + 1; k < MapSize; k++)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                    {
                                        var number = Convert.ToInt32(labelsMap[i, j].Text) * 2;
                                        Score += number;
                                        labelsMap[i, j].Text = number.ToString();
                                        labelsMap[k, j].Text = string.Empty;
                                        //i = -1;
                                    }
                                    break;
                                }

                            }
                        }
                    }
                }
                //сдвиг €чеек
                for (int j = 0; j < MapSize; j++)
                {
                    for (int i = 0; i < MapSize; i++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i + 1; k < MapSize; k++)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }

            }
            if (e.KeyCode == Keys.Down)
            {
                isChanged = true;
                //сложение €чеек
                for (int j = 0; j < MapSize; j++)
                {
                    for (int i = MapSize - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                    {
                                        var number = Convert.ToInt32(labelsMap[i, j].Text) * 2;
                                        Score += number;
                                        labelsMap[i, j].Text = number.ToString();
                                        labelsMap[k, j].Text = string.Empty;
                                        //i = mapSize;
                                    }
                                    break;
                                }

                            }
                        }
                    }
                }
                //сдвиг €чеек
                for (int j = 0; j < MapSize; j++)
                {
                    for (int i = MapSize - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }

            }

            ShowScore();
            if (!EndGame())
            {
                if (isChanged)
                {
                    GenerateNumber();
                }
            }
            else
            {
                User.Score = Score;
                var nameInputForm = new NameInputForm();
                nameInputForm.ShowDialog();
                User.Name = nameInputForm.user.Name;
                HiscoreStorage.Save(User);
                GameReset();
            }

        }

        private static Color SetColor(int number)
        {
            switch (number)
            {
                case 2: return Color.FromArgb(216, 243, 220);
                case 4: return Color.FromArgb(183, 228, 199);
                case 8: return Color.FromArgb(149, 213, 178);
                case 16: return Color.FromArgb(116, 198, 157);
                case 32: return Color.FromArgb(82, 183, 136);
                case 64: return Color.FromArgb(255, 204, 213);
                case 128: return Color.FromArgb(255, 143, 163);
                case 256: return Color.FromArgb(255, 117, 143);
                case 512: return Color.FromArgb(255, 77, 109);
                case 1024: return Color.FromArgb(255, 214, 10);
                case 2048: return Color.FromArgb(255, 183, 3);
                case 4096: return Color.FromArgb(251, 133, 0);
                case 8192: return Color.FromArgb(251, 133, 0);
                case 16384: return Color.FromArgb(251, 133, 0);
                case 32768: return Color.FromArgb(251, 133, 0);
                default: return Color.FromArgb(240, 240, 240);
            }
        }

        public void GameStart()
        {
            MainWindowSize();
            InitMap();
            GenerateNumber();
            HiScore = HiscoreStorage.GetHiScore();
            Score = 0;
            ShowScore();
        }

        public void GameReset()
        {
            ClearMap();
            GameStart();
        }
        public void ClearMap()
        {
            foreach (var label in labelsMap)
            {
                Controls.Remove(label);
            }
        }
    }
}
