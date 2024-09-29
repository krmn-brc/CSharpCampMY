
using System.Text;

namespace ATMSystem.Utilities
{
    public class InputFunc
    {
        public static void PrintMessage(string message, bool success)
        {
            Console.ForegroundColor = success ? ConsoleColor.Yellow : ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine("Devam etmek için herhangi bir tuşa basın");
            Console.ReadKey();
        }

        public static decimal GetValidDecimalInput(string input)
        {
            bool isValid = false;
            decimal amount = 0;
            string rawInput;
            while (!isValid)
            {
                rawInput = GetRawInput(input);
                isValid = decimal.TryParse(rawInput, out amount);
                if (!isValid)
                    PrintMessage("Geçersiz girdi. Tekrar deneyin.", false);
            }

            return amount;
        }
        public static Int64 GetValidInt64Input(string input)
        {
            bool isValid = false;
            Int64 amount = 0;
            string rawInput;
            while (!isValid)
            {
                rawInput = GetRawInput(input);
                isValid = Int64.TryParse(rawInput, out amount);
                if (!isValid)
                    PrintMessage("Geçersiz girdi. Tekrar deneyin.", false);
            }

            return amount;
        }

        public static string GetRawInput(string message)
        {
            Console.Write($"{message} Girin: ");
            return Console.ReadLine();
        }

        public static string GetHiddenConsoleInput()
        {
            StringBuilder input = new StringBuilder();
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) break;
                if (key.Key == ConsoleKey.Backspace && input.Length > 0) input.Remove(input.Length - 1, 1);
                else if (key.Key != ConsoleKey.Backspace) input.Append(key.KeyChar);
            }
            return input.ToString();
        }

        public static void Animation(int timer = 10)
        {
            for (var x = 0; x < timer; x++)
            {
                Console.Write(">");
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }
    }
}