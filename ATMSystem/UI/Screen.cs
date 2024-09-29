

namespace ATMSystem.UI
{
    public class Screen
    {
        public static void WelcomeScreen()
        {
             Console.Clear();
             string topBottomDraw = " ".PadRight(32, '-');
             string leftRightDraw = "#";
          

             Console.WriteLine(topBottomDraw);
             for (int i = 0; i < 15; i++)
             {
                switch (i)
                {
                    case 4:{
                        Console.Write($"{leftRightDraw, -11}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0}", "Hoşgeldiniz");
                        Console.ResetColor();
                        Console.WriteLine($"{leftRightDraw, 11}");
                    }
                    break;
                    case 8:{
                        Console.Write($"{leftRightDraw, -11}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0}", "1. Kart Girişi");
                        Console.ResetColor();
                        Console.WriteLine($"{leftRightDraw, 8}");
                    }
                    break;
                    case 9:{
                        Console.Write($"{leftRightDraw, -11}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0}", "2. Çıkış Yap");
                        Console.ResetColor();
                        Console.WriteLine($"{leftRightDraw, 10}");
                    }
                    break;
                    default:
                        Console.WriteLine($"{leftRightDraw}{leftRightDraw, 32}");
                    break;
                }
             }
             Console.WriteLine(topBottomDraw);

        }
        public static void MenuScreen()
        {
             Console.Clear();
             string topBottomDraw = " ".PadRight(32, '-');
             string leftRightDraw = "#";
          

             Console.WriteLine(topBottomDraw);
             for (int i = 0; i < 15; i++)
             {
                switch (i)
                {
                    case 3:{
                        Console.Write($"{leftRightDraw, -5}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0}", "1. Bakiye");
                        Console.ResetColor();
                        Console.WriteLine($"{leftRightDraw, 19}");
                    }
                    break;
                    case 4:{
                        Console.Write($"{leftRightDraw, -5}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0}", "2. Para Çekme");
                        Console.ResetColor();
                        Console.WriteLine($"{leftRightDraw, 15}");
                    }
                    break;
                    case 5:{
                        Console.Write($"{leftRightDraw, -5}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0}", "3. Para Yatırma");
                        Console.ResetColor();
                        Console.WriteLine($"{leftRightDraw, 13}");
                    }
                    break;
                    case 6:{
                        Console.Write($"{leftRightDraw, -5}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0}", "4. Para Transferi");
                        Console.ResetColor();
                        Console.WriteLine($"{leftRightDraw, 11}");
                    }
                    break;
                    case 7:{
                        Console.Write($"{leftRightDraw, -5}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0}", "5. Hesap Hareketleri");
                        Console.ResetColor();
                        Console.WriteLine($"{leftRightDraw, 8}");
                    }
                    break;
                    case 9:{
                        Console.Write($"{leftRightDraw, -5}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0}", "6. Çıkış Yap");
                        Console.ResetColor();
                        Console.WriteLine($"{leftRightDraw, 16}");
                    }
                    break;
                    default:
                        Console.WriteLine($"{leftRightDraw}{leftRightDraw, 32}");
                    break;
                }
             }
             Console.WriteLine(topBottomDraw);

        }
    }
}