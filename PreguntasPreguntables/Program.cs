namespace PreguntasPreguntables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            ShowOptions();
            key = Console.ReadKey();
            Console.Clear();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.D5:
                    break;
                case ConsoleKey.D6:
                    break;
                case ConsoleKey.D7:
                    break;
                case ConsoleKey.D8:
                    break;
                case ConsoleKey.D9:
                    break;
                case ConsoleKey.D0:
                    MsgNextScreen("Press any key to exit");
                    break;
                default:
                    MsgNextScreen("Error. Press any key to return to the menu");
                    break;
            }
        }

        public static void ShowOptions()
        {
            Console.Clear();
            Console.WriteLine("1 - History");
            Console.WriteLine("2 - Sports");
            Console.WriteLine("3 - Musics");
            Console.WriteLine("4 - Geography");
            Console.WriteLine("5 - Movies");
            Console.WriteLine("6 - Science");
        }

        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}