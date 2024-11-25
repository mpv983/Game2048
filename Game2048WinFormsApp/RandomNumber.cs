namespace Game2048WinFormsApp
{
    public class RandomNumber
    {
        public static int GetRandomNumber()
        {
            var random = new Random();
            var rundomNUmber = random.Next(4);
            if (rundomNUmber < 3)
            {
                return 2;
            }
            else
            {
                return 4;
            }
        }
    }
}

