using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Game2048WinFormsApp
{
    public partial class MapSizeForm : Form
    {
        MainForm mainForm;
        MenuForm menuForm;
        public List<RadioButton> RadioButtons { get; set; }

        public MapSizeForm(MainForm mainForm, MenuForm menuForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.menuForm = menuForm;
            radioButton_4x4.Checked = true;
            RadioButtons = new List<RadioButton>()
            {
                radioButton_3x3,
                radioButton_4x4,
                radioButton_5x5,
                radioButton_6x6,
            };
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var mapSize = CheckedMapSize();
            mainForm.MapSize = mapSize;
            mainForm.GameReset();
            menuForm.Close();
            Close();
        }

        private int CheckedMapSize()
        {
            int number = 0;
            foreach (RadioButton radioButton in RadioButtons)
            {
                if (radioButton.Checked)
                {
                    number = Convert.ToInt32(radioButton.Text[0].ToString());
                }
            }
            return number;
        }
    }
}
