using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ShenkinBagsStore.Models
{
    public class User
    {
      //  public enum usertype
        //{
          //  admin,
            //user
        //}
       
    
        public int UserId { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        // [Display(Name = "User Type")]
        //  public UserType? UserTypee { get; set; }


        public ICollection<Transaction> Transactions { get; set; }
    }
}