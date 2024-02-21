using System.Text;

namespace PreguntasPreguntables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                ShowOptions();
                key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        HistoryTopic();
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        GeograpyTopic();
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        ScienceTopic();
                        break;
                    case ConsoleKey.D0:
                        MsgNextScreen("Press any key to exit");
                        break;
                    default:
                        MsgNextScreen("Error. Press any key to return to the menu");
                        break;
                }

            } while (key.Key != ConsoleKey.D0);
        }

        public static void ShowOptions()
        {
            Console.Clear();
            Console.WriteLine("1 - History");
            Console.WriteLine("2 - Sport");
            Console.WriteLine("3 - Music");
            Console.WriteLine("4 - Geography");
            Console.WriteLine("5 - Movies");
            Console.WriteLine("6 - Science");
        }

        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        public static void ShowQuestion(string fileName, int nQuestion)
        {
            StreamReader sr = new StreamReader(fileName);

            bool trobat = false;
            string linea = null;
            int nLinea = 1;

            while (!trobat)
            {
                if (nLinea == nQuestion) trobat = true;
                else nLinea++;

                linea = sr.ReadLine();
            }

            Console.WriteLine(linea);
        }

        public static string ShowAnswers(string fileName, int nQuestion)
        {
            StreamReader sr = new StreamReader($"{fileName}-answers.txt");
            int nLinea = 1;
            bool trobat = false;

            string linea = null;
            while (!trobat)
            {
                if (nLinea == nQuestion) trobat = true;
                else nLinea++;

                linea = sr.ReadLine();
            }

            return linea;
        }

        public static void HistoryTopic()
        {
            Console.Clear();
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo key;
            string answers;
            string[] fields;
            string[] fields2;

            for (int i = 1; i <= 5; i++)
            {
                Console.Clear();
                answers = ShowAnswers("history", i);
                fields = answers.Split(":");
                fields2 = fields[0].Split(",");
                for (int j = 0; j < fields2.Length; j++)
                {
                    sb.Append($"{j + 1}.{fields2[j]} ");
                }
                bool correcte = false;
                do
                {
                    ShowQuestion("history.txt", i);
                    Console.WriteLine(sb.ToString());
                    key = Console.ReadKey();
                    Console.Clear();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                            if (fields2[0] == fields[1]) {
                                MsgNextScreen("Correcte. Press any key to return to the menu");
                                correcte = true;
                            }
                            else MsgNextScreen("Incorrect. Press any key to return to the menu");
                            break;
                        case ConsoleKey.D2:
                            if (fields2[1] == fields[1])
                            {
                                MsgNextScreen("Correcte. Press any key to return to the menu");
                                correcte = true;
                            }
                            else MsgNextScreen("Incorrect. Press any key to return to the menu");
                            break;
                        case ConsoleKey.D3:
                            if (fields2[2] == fields[1])
                            {
                                MsgNextScreen("Correcte. Press any key to return to the menu");
                                correcte = true;
                            }
                            else MsgNextScreen("Incorrect. Press any key to return to the menu");
                            break;
                        case ConsoleKey.D4:
                            if (fields2[3] == fields[1])
                            {
                                Console.WriteLine("Correcte. Press any key to return to the menu");
                                correcte = true;
                            }
                            else MsgNextScreen("Incorrect. Press any key to return to the menu");
                            break;
                        default:
                            MsgNextScreen("Error. Press any key to return to the menu");
                            break;
                    }

                } while (!correcte);
                sb.Clear();
            }
        
        }
        public static void ScienceTopic()
        {
            Console.Clear();
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo key;
            string answers;
            string[] fields;
            string[] fields2;

            for (int i = 1; i <= 5; i++)
            {
                Console.Clear();
                answers = ShowAnswers("science", i);
                fields = answers.Split(":");
                fields2 = fields[0].Split(",");
                for (int j = 0; j < fields2.Length; j++)
                {
                    sb.Append($"{j + 1}.{fields2[j]} ");
                }
                bool correcte = false;
                do
                {
                    ShowQuestion("science.txt", i);
                    Console.WriteLine(sb.ToString());
                    key = Console.ReadKey();
                    Console.Clear();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                            if (fields2[0] == fields[1])
                            {
                                MsgNextScreen("Correcte. Press any key to return to the menu");
                                correcte = true;
                            }
                            else MsgNextScreen("Incorrect. Press any key to return to the menu");
                            break;
                        case ConsoleKey.D2:
                            if (fields2[1] == fields[1])
                            {
                                MsgNextScreen("Correcte. Press any key to return to the menu");
                                correcte = true;
                            }
                            else MsgNextScreen("Incorrect. Press any key to return to the menu");
                            break;
                        case ConsoleKey.D3:
                            if (fields2[2] == fields[1])
                            {
                                MsgNextScreen("Correcte. Press any key to return to the menu");
                                correcte = true;
                            }
                            else MsgNextScreen("Incorrect. Press any key to return to the menu");
                            break;
                        case ConsoleKey.D4:
                            if (fields2[3] == fields[1])
                            {
                                Console.WriteLine("Correcte. Press any key to return to the menu");
                                correcte = true;
                            }
                            else MsgNextScreen("Incorrect. Press any key to return to the menu");
                            break;
                        default:
                            MsgNextScreen("Error. Press any key to return to the menu");
                            break;
                    }

                } while (!correcte);
                sb.Clear();
            }

        }
        public static void GeograpyTopic()
        {
            Console.Clear();
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo key;
            string answers;
            string[] fields;
            string[] fields2;

            for (int i = 1; i <= 5; i++)
            {
                Console.Clear();
                answers = ShowAnswers("geograpy", i);
                fields = answers.Split(":");
                fields2 = fields[0].Split(",");
                for (int j = 0; j < fields2.Length; j++)
                {
                    sb.Append($"{j + 1}.{fields2[j]} ");
                }
                bool correcte = false;
                do
                {
                    ShowQuestion("geograpy.txt", i);
                    Console.WriteLine(sb.ToString());
                    key = Console.ReadKey();
                    Console.Clear();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                            if (fields2[0] == fields[1])
                            {
                                MsgNextScreen("Correcte. Press any key to return to the menu");
                                correcte = true;
                            }
                            else MsgNextScreen("Incorrect. Press any key to return to the menu");
                            break;
                        case ConsoleKey.D2:
                            if (fields2[1] == fields[1])
                            {
                                MsgNextScreen("Correcte. Press any key to return to the menu");
                                correcte = true;
                            }
                            else MsgNextScreen("Incorrect. Press any key to return to the menu");
                            break;
                        case ConsoleKey.D3:
                            if (fields2[2] == fields[1])
                            {
                                MsgNextScreen("Correcte. Press any key to return to the menu");
                                correcte = true;
                            }
                            else MsgNextScreen("Incorrect. Press any key to return to the menu");
                            break;
                        case ConsoleKey.D4:
                            if (fields2[3] == fields[1])
                            {
                                Console.WriteLine("Correcte. Press any key to return to the menu");
                                correcte = true;
                            }
                            else MsgNextScreen("Incorrect. Press any key to return to the menu");
                            break;
                        default:
                            MsgNextScreen("Error. Press any key to return to the menu");
                            break;
                    }

                } while (!correcte);
                sb.Clear();
            }

        }
    }
}