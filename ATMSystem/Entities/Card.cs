
namespace ATMSystem.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public long CardNumber { get; set; }
        public int PinCode { get; set; }
        public bool IsLocked { get; set; }
        public int CCV { get; set; }
        public string EXPDate { get; set; }

        public List<Amount> Amounts { get; set; }
    }
}