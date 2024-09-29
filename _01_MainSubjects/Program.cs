// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ".PadRight(32, '-'));
for (int i = 0; i < 15; i++)
{
    if(i == 7)
    {
         Console.Write("{0,-12}", "*");
         Console.ForegroundColor = ConsoleColor.DarkMagenta;
         Console.Write("{0}","İKRA LİYA");
         Console.ResetColor();
         Console.WriteLine("{0,12}","*");
    }
    Console.WriteLine("{0}{1, 32}", "*", "*");
}
Console.WriteLine(" ".PadRight(32, '-'));