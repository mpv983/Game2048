namespace Game2048WinFormsApp
{
    public class User
    {
        public string Name { get; set; }
        public int Score { get; set; } = 0;

        public User(string name)
        {
            Name = name;
        }
    }
}

