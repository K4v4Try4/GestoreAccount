using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    public class Email
    {
        private String mail;

        public Email(String mail)
        {
            this.mail = mail;
        }

        public String Mail { get => mail; set => mail = value; }

        public static Boolean IsAcceptable(String mail)
        {
            if (Regex.Match(mail, @"^[\w.-]+@([\w-]+)(.\w{2,3})+$").Success)
            {
                return true;
            }
            return false;
        }

        public void Cripta(String psd)
        {
            this.mail = Cifer.Cripta(this.mail, psd);
        }

        public void Decripta(String psd)
        {
            this.mail = Cifer.Decripta(this.mail, psd);
        }

        public String Save()
        {
            return Normalizzatore.Normalize(mail) + Normalizzatore.DEL;
        }

        public static Email Load(String s)
        {
            return new Email(Normalizzatore.Split(s)[0]);
        }

        public override string ToString()
        {
            return mail;
        }
    }
}
