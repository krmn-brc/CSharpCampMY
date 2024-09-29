

namespace ATMSystem.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string NationalyId { get; set; }
        public List<Amount> Amounts { get; set; }
    }
}