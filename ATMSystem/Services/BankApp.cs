
using ATMSystem.Business.Abstract;
using ATMSystem.Business.Concrete;
using ATMSystem.Entities;
using ATMSystem.UI;
using ATMSystem.Utilities;

namespace ATMSystem.Services
{
    public class BankApp
    {
        private readonly IATMService _service;
        public BankApp(IATMService service)
        {
            _service = service;
        }
        public void Execute()
        {
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
        }



        private  void CheckCardNoPassword()
        {
            bool pass = false;
            Card selectedCard = new Card();
            while (!pass)
            {


                Console.WriteLine("\nNot: Lütfen Kart Numaranızı Doğru Bir Şekilde Giriniz");
                var cardNumber = InputFunc.GetValidInt64Input("ATM Kart Numaranızı");

                Console.Write("Şifrenizi Girin: ");
                var pinCode = Convert.ToInt32(InputFunc.GetHiddenConsoleInput());

                Console.Write("\nLütfen Bekleyin! Bilgileriniz Kontrol Ediliyor.\n");
                InputFunc.Animation();
                _service.CheckCardNoPassword(cardNumber, pinCode, ref pass, ref selectedCard);
                Console.ReadKey();
            }



        }
    }
}