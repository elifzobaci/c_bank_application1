using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


using System;
using System.Text.RegularExpressions;

namespace bankapplicationc_.classes
{
    internal class somekontrolsnew
    {
        private string phoneNumber;
        private string occupation;

        public string PHONENUMBER
        {
            get { return phoneNumber; }
            set
            {
                bool kontrol = true;
                // Amerika'daki telefon numarası için regex deseni
                Regex regex = new Regex(@"^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$");
                if (!regex.IsMatch(value))
                {
                    kontrol = false;
                }
                if (kontrol && value.Length > 0)
                {
                    this.phoneNumber = value;
                }
                else
                    throw new System.ArgumentException("Customer's Phone number is in the wrong format");
            }
        }


        public string OCCUPATION
        {
            get { return occupation; }
            set
            {
                bool kontrol = true;
                Regex regex = new Regex("^[a-zA-Z\\s]+$");
                if (!regex.IsMatch(value))
                {
                    kontrol = false;
                }
                if (kontrol && value.Length > 0)
                {
                    this.occupation = value;
                }
                else
                    throw new System.ArgumentException("Customer's occupation is in the wrong format");
            }
        }
    }
}
