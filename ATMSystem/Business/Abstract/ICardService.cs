

using ATMSystem.Entities;

namespace ATMSystem.Business.Abstract
{
    public interface ICardService
    {
        List<Card> GetCardInclude();
        List<Card> GetCards();
        Card GetByCardNumber(long cardNumber);
    }
}