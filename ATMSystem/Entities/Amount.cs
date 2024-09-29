using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATMSystem.Entities
{
    public class Amount
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int UserId { get; set; }
        public string AmountNo { get; set; }
        public string BranchNo { get; set; }
        public double Remnant { get; set; }



        public User User { get; set; }
        public Card Card { get; set; }
    }
}