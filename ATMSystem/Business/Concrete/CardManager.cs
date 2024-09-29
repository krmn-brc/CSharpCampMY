

using ATMSystem.Business.Abstract;
using ATMSystem.Data.Abstract;
using ATMSystem.Data.Concrete;
using ATMSystem.Entities;

namespace ATMSystem.Business.Concrete
{
    public class CardManager : ICardService
    {
        private readonly ICardRepository _cardRepository;

        public CardManager(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public Card GetByCardNumber(long cardNumber)
        {
            return _cardRepository.Find(x => x.CardNumber == cardNumber)!;
        }

        public List<Card> GetCardInclude()
        {
            throw new NotImplementedException();
        }

        public List<Card> GetCards()
        {
            throw new NotImplementedException();
        }
    }
}