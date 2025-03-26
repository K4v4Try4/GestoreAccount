using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Gestore
    {
        private List<Utente> utenti;
        private Utente logged;
        private String session;

        public Gestore()
        {
            this.utenti = new List<Utente>();
            this.logged = null;
            this.session = "";
        }

        public List<Utente> Utenti { get => utenti; }
        public Utente Logged { get => logged; }
        public string Session { get => session; set => session = value; }

        public Boolean AddUtente(Utente u)
        {
            utenti.Add(u);
            return true;
        }

        public Boolean RemoveUtente(Utente u)
        {
            return utenti.Remove(u);
        }

        public Boolean AddAccountToUtente(Utente u, Account a)
        {
            return u.AddAcc(a);
        }

        public Boolean RemoveAccountToUtente(Utente u, Account a)
        {
            return u.RemoveAcc(a);
        }

        public void Login(string username, string password)
        {
            foreach (Utente u in utenti)
            {
                if (u.Username.Equals(username))
                {
                    this.logged = u;
                    this.session = password;
                    this.logged.Decripta(this.session);
                    return;
                }
            }
        }

        public void Logout()
        {
            if (this.logged == null) return;
            this.logged.Cripta(this.session);
            this.logged = null;
            this.session = "";
        }

        public String Save()
        {
            Logout();
            String ret = "";
            foreach (Utente u in utenti)
            {
                ret += Normalizzatore.Normalize(u.Save()) + Normalizzatore.DEL;
            }
            return ret;
        }

        public void Load(String s)
        {
            List<String> utenti = Normalizzatore.Split(s);
            this.utenti.Clear();
            foreach(String u in utenti)
            {
                AddUtente(Utente.Load(u));
            }
            this.logged = null;
            this.session = "";
        }
    }
}
