// See https://aka.ms/new-console-template for more information
using ATMSystem.Data.Concrete;
using ATMSystem.Entities;
using ATMSystem.UI;
using ATMSystem.Utilities;



Screen.WelcomeScreen();
while (true)
{

    switch (InputFunc.GetValidInt64Input("Seçiminizi"))
    {
        case 1:
            {
                CheckCardNoPassword();
            }
            break;
        case 2:
            {
                Environment.Exit(1);
            }
            break;
        default:
            break;
    }
}

static void CheckCardNoPassword()
{
     Card selectedCard;
     bool pass = false;
     Console.WriteLine("\nNot: Lütfen Kart Numaranızı Doğru Bir Şekilde Giriniz");
     var cardNumber = InputFunc.GetValidInt64Input("ATM Kart Numaranızı");

     Console.Write("Şifrenizi Girin: ");
     var pinCode = Convert.ToInt32(InputFunc.GetHiddenConsoleInput());

     Console.Write("\nLütfen Bekleyin! Bilgileriniz Kontrol Ediliyor.\n");
     InputFunc.Animation();

   

}