using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace bankapplicationc_.classes
{
    public class somekontrols
    {
     
       
        private string musteriadi;
        private string phoneNumber;
        private string ssn;
        private string email;

        public string getmusteriadi()
        {
            return musteriadi;
        }

        public void setmusteriadi(string musteriadip)
        {
            bool kontrol = true;
            Regex regex = new Regex("^[a-zA-Z\\s]+$");
            if (!regex.IsMatch(musteriadip))
            {
                kontrol = false;
            } 
            if (kontrol && musteriadip.Length > 0)
            {
                musteriadi = musteriadip;
            }
            else
                throw new System.ArgumentException("There cannot be any characters other than letters and spaces in the customer name. ");
        }

        public string getphoneNumber()
        {
            return phoneNumber;
        }

        public void setphoneNumber(string phoneNumberp)
        {
            bool kontrol = true;
            // Amerika'daki telefon numarası için regex deseni
            Regex regex = new Regex(@"^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$");
            if (!regex.IsMatch(phoneNumberp))
            {
                kontrol = false;
            }
            if (kontrol && phoneNumberp.Length > 0)
            {
                phoneNumber = phoneNumberp;
            }
            else
                throw new System.ArgumentException("Customer's Phone number is in the wrong format");
        }

        public string getssn()
        {
            return ssn;
        }

        public void setssn(string ssnp)
        {
            bool kontrol = true;
            // Social Security Number için regex deseni
            Regex regex = new Regex(@"^\d{3}-\d{2}-\d{4}$");
            if (!regex.IsMatch(ssnp))
            {
                kontrol=false;  
            }
            if (kontrol && ssnp.Length > 0)
            {
                ssn = ssnp;
            }
            else throw new System.ArgumentException("SSN Format is incorrect. The format should be \"XXX-XX-XXXX\".");
        }

        public string getemail()
        {
            return email;
        }
        public void setemail(string emailp)
        {
            bool kontrol = true;
            // E-posta adresi için basit bir regex deseni
            Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            if (!regex.IsMatch(email))
            {
                kontrol = false;
            }
            if (kontrol && emailp.Length > 0)
            {
                email = emailp;
            }
            else throw new System.ArgumentException("The e-mail format is incorrect. Please enter in the correct format.");
    
        }
    }
}
