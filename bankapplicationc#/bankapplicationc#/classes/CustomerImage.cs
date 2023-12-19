using bankapplicationc.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankapplicationc_.classes
{
    public class CustomerImage
    {
        [Required]
        public int CustomerImageID { get; set; }
       
        public byte[]? Image { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
