using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Utente
    {
        private String username;
        private List<Account> accs;

        public Utente(String username)
        {
            this.username = username;
            this.accs = new List<Account>();
        }

        public string Username { get => username; set => username = value; }
        public List<Account> Accs { get => accs; }

        public Boolean AddAcc(Account a)
        {
            accs.Add(a);
            return true;
        }

        public Boolean RemoveAcc(Account a)
        {
            accs.Remove(a);
            return true;
        }

        public void Cripta(string psd)
        {
            foreach (Account a in accs)
            {
                a.Cripta(psd);
            }
        }

        public void Decripta(string psd)
        {
            foreach (Account a in accs)
            {
                a.Decripta(psd);
            }
        }

        public String Save()
        {
            string ret = username + ":";

            foreach (Account a in accs)
            {
                ret += Normalizzatore.Normalize(a.Save()) + Normalizzatore.DEL;
            }
            return ret;
        }

        public int GetNSameEmails(String email)
        {
            return accs.Count(a => a.Mail.Mail.Equals(email));
        }

        public List<Account> GetSameEmails(String email)
        {
           return accs.Where(a => a.Mail.Mail.Equals(email)).ToList();
        }

        public static Utente Load(String s)
        {
            int i = s.IndexOf(':');

            Utente ret = new Utente(s.Substring(0, i));

            List<String> account = Normalizzatore.Split(s.Substring(i+1));

            foreach (String a in account)
            {
                ret.AddAcc(Account.Load(a));
            }

            return ret;
        }
    }
}
