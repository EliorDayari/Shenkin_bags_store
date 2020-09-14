using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShenkinBagsStore.Models
{
    public class Transaction
    {
        public enum TransactioinType
        {
            Purchased,
            Returned
        }

        public int TransactionId { get; set; } // primary key
        [Display(Name = "Transaction Date")]
        public DateTime TransactionDate { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        
        public ICollection<Product> Products { get; set; } // All transaction items
      //  public float TotalCost { get; set; }
       // [Display(Name = "Transaction TypE")]
       // public TransactioinType TransactionType { get; set; } // 0 = purchase 1 = return
        public Product Product { get; set; }
        public User User { get; set; }
    }
}