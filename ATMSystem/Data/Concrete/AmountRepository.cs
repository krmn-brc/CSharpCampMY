
using ATMSystem.Data.Abstract;
using ATMSystem.Entities;

namespace ATMSystem.Data.Concrete
{
    public class AmountRepository:RepoistoryBase<Amount>, IAmountRepository
    {
        public AmountRepository()
        {
            Data = new List<Amount>()
            {
                new Amount(){Id = 1, AmountNo ="1212", BranchNo="28", CardId = 1, UserId = 1, Remnant = 100.32},
                new Amount(){Id = 2, AmountNo ="1213", BranchNo="32", CardId = 1, UserId = 1, Remnant = 300.49},
                new Amount(){Id = 3, AmountNo ="1214", BranchNo="32", CardId = 1, UserId = 1, Remnant = 10400.28},
                new Amount(){Id = 4, AmountNo ="1215", BranchNo="41", CardId = 2, UserId = 2, Remnant = 5000.00},
            };
        }
    }
}