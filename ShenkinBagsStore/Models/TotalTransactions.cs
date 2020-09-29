using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShenkinBagsStore.Models
{
    public class TotalTransactions
    {
        public int ID { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
