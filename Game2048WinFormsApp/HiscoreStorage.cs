namespace Game2048WinFormsApp
{
    public class HiscoreStorage
    {
        public List<User> UserResults;
        public string Path = @"Hiscore.json";
        public FileHelper FileHelper;
        public HiscoreStorage()
        {
            UserResults = new List<User>();
            FileHelper = new FileHelper(Path);
        }

        public List<User> GetAll()
        {
            if (!File.Exists(Path))
            {
                var nullResult = new List<User>();
                FileHelper.Write(nullResult);
            }
            var users = FileHelper.Read<User>();
            return users;
        }

        public void Save(User user)
        {
            var allResults = GetAll();
            allResults.Add(user);
            FileHelper.Write(allResults);
        }

        internal void Clear()
        {
            var nullResult = new List<User>();
            FileHelper.Write(nullResult);
        }

        internal int GetHiScore()
        {
            var hiscores = GetAll();
            var sortedHiscores = hiscores.OrderByDescending(x => x.Score).ToList();
            if (sortedHiscores.Count == 0)
            {
                return 0;
            }
            else
            {
                return sortedHiscores[0].Score;
            }
        }
    }
}
