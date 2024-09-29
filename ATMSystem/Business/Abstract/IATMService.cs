

using ATMSystem.Entities;

namespace ATMSystem.Business.Abstract
{
    public interface IATMService
    {
        void CheckCardNoPassword(long cardNumber, int pinCode, ref bool pass, ref Card card);
    }
}