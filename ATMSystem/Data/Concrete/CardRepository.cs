

using ATMSystem.Data.Abstract;
using ATMSystem.Entities;

namespace ATMSystem.Data.Concrete
{
    public class CardRepository:RepoistoryBase<Card>, ICardRepository
    {
        public CardRepository()
        {
            Data = new List<Card>()
            {
                new Card() { Id = 1, CardNumber = 121213, PinCode = 1234, CCV = 323, EXPDate = "07/28"},
                new Card() { Id = 2, CardNumber=121214, PinCode = 1235,  CCV = 432, EXPDate="06/29"},
                new Card() { Id = 3, CardNumber=121215, PinCode = 1236, CCV = 789, EXPDate="12/26"},
                new Card() { Id = 4, CardNumber=121216, PinCode = 1237, CCV = 572, EXPDate="10/27"}
            };
        }
    }
}