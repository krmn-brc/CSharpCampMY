

using ATMSystem.Data.Abstract;
using ATMSystem.Entities;

namespace ATMSystem.Data.Concrete
{
    public class UserRepository:RepoistoryBase<User>, IUserRepository
    {
        public UserRepository()
        {
            this.Data = new List<User>()
            {
                new User(){Id = 1, FullName="Ali Kaya", NationalyId = "4537"},
                new User(){Id = 2, FullName="Mustafa Kumaş", NationalyId="6753"},
                new User(){Id = 3, FullName="Yasin Güneş", NationalyId="7632"}
            };
        }
    }
}