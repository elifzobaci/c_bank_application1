using bankapplicationc.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankapplicationc_.classes
{
    public class TransactionLog
    {
      
        public int Id { get; set; }
        public int? AccountID { get; set; }
        [ForeignKey("AccountID")]

        public virtual Account Account { get; set; }
        public int? CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        public DateTime TransactionLogDate { get; set; }

        public string OperationType { get; set; }

        public float Amount { get; set; }

        public int? TransferID { get; set; }
        public Transfer? Transfer { get; set; }


    }
}
