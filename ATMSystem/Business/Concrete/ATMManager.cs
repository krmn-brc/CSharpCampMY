

using ATMSystem.Business.Abstract;
using ATMSystem.Entities;
using ATMSystem.Utilities;

namespace ATMSystem.Business.Concrete
{
    public class ATMManager : IATMService
    {
        private ICardService _cardService;
        private static int tries;
        private const int maxTries = 3;

        public ATMManager(ICardService cardService)
        {
            _cardService = cardService;
        }

        public void CheckCardNoPassword(long cardNumber, int pinCode, ref bool pass, ref Card card)
        {

            card = _cardService.GetByCardNumber(cardNumber);
            if (card is not null)
            {
                if (card.PinCode.Equals(pinCode))
                {
                    if (card.IsLocked)
                        LockAccount();
                    else
                        pass = true;
                }
                else
                {
                    pass = false;
                    tries++;

                    if (tries >= maxTries)
                    {
                        card.IsLocked = true;
                        LockAccount();
                    }
                }
                
            }
            else
              InputFunc.PrintMessage("Kart Numaranız veya Şifreniz Hatalı", false);
                
        }

        private static void LockAccount()
        {
            Console.Clear();
            InputFunc.PrintMessage("Kartınız Bloke Edildi.", true);
            Console.WriteLine("Kartınızın blokesini kaldırmak için en yakın şubemize gidiniz.");

            Console.ReadKey();
            Environment.Exit(1);
        }
    }
}