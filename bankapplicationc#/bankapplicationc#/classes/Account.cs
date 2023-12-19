using bankapplicationc.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankapplicationc_.classes
{
    public class Account
    {
        [Required]
        public int AccountID {  get; set; }

        [Required]
        public int AccountNumber{ get; set; }

        [Required]
        public string AccountType { get; set; }
       
        public string CustomerName { get; set; }

        public float Balance { get; set; }
        public int CustomerID { get; set; } 
        public virtual Customer Customer { get; set; }
        public override string ToString()
        {
            return $"{AccountNumber} - {CustomerName}"; // veya istediğiniz özellikleri kullanarak bir string döndürebilirsiniz
        }
            //public List<TransactionLog> TransactionLogs { get; set; }

        //public virtual ICollection<Transfer> SourceTransfers { get; set; }
        //public virtual ICollection<Transfer> DestinationTransfers { get; set; }
    }
}
