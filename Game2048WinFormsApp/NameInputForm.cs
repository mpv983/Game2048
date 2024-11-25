namespace Game2048WinFormsApp
{
    public partial class NameInputForm : Form
    {
        public User user;
        public NameInputForm()
        {
            InitializeComponent();
            user = new User("Неизвестно");
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            var check_nameInputTextBox = Validation.GetUserText(nameInputTextBox.Text, out var userName, out string errorMessageText);
            if (!check_nameInputTextBox)
            {
                MessageBox.Show(errorMessageText + " Введите имя.");
            }
            else
            {
                user.Name = userName;
                Close();
            }
        }
    }
}
