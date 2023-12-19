using bankapplicationc_.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankapplicationc.classes
{
    public class Customer
    {
        [Required]
        public int CustomerID { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public int AccountNumber { get; set; }

        [Required]
        public string AccountType { get; set; }
       
        public string Gender { get; set; }  

        public DateTime DateofBirth { get; set; }
        public string Nationality { get; set;}
        public string Email { get; set; }
        public string PhoneNumber { get; set;}
        public string SSN { get; set; }
        public string Occupation { get; set;}
     
        public virtual List<Account> CustomerAccounts { get; set; }
        public virtual CustomerImage CustomerImageID { get; set; }
    }
}
