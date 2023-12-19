using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace bankapplicationc_.classes
{
    public class Transfer
    {
        [Key]
        public int TransferID { get; set; }
        public float Amount { get; set; }
        public DateTime TransferDate { get; set; }

        public int? SourceAccountID { get; set; }
        [ForeignKey("SourceAccountID")]
        public virtual Account SourceAccount { get; set; }

        public int? DestinationAccountID { get; set; }
        [ForeignKey("DestinationAccountID")]
        public virtual Account DestinationAccount { get; set; }
        public int? TransactionLogId { get; set; }
        [ForeignKey("TransactionLogId")]
        public virtual TransactionLog TransactionLog { get; set; }
       

    }
}

