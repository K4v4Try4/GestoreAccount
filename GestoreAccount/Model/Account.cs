namespace Model
{
    public class Account
    {
        private String tipo;
        private Email mail;
        private Password psd;
        private String comments;

        public Account(String tipo, Email mail, Password psd, String comments)
        {
            this.tipo = tipo;
            this.mail = mail;
            this.psd = psd;
            this.comments = comments;
        }

        public Email Mail { get => mail; set => mail = value; }
        public Password Psd { get => psd; set => psd = value; }
        public String Comments { get => comments; set => comments = value; }
        public String Tipo { get => tipo; }

        public void Cripta(String psd)
        {
            this.tipo = Cifer.Cripta(this.tipo, psd);
            this.mail.Cripta(psd);
            this.psd.Cripta(psd);
            this.comments = Cifer.Cripta(this.comments, psd);
        }

        public void Decripta(String psd)
        {
            this.tipo = Cifer.Decripta(this.tipo, psd);
            this.mail.Decripta(psd);
            this.psd.Decripta(psd);
            this.comments = Cifer.Decripta(this.comments, psd);
        }

        public String Save()
        {
            return Normalizzatore.Normalize(tipo) + Normalizzatore.DEL + Normalizzatore.Normalize(mail.Save()) + Normalizzatore.DEL + Normalizzatore.Normalize(psd.Save()) + Normalizzatore.DEL + Normalizzatore.Normalize(comments);
        }

        public static Account Load(String s)
        {
            List<String> lsAttr = Normalizzatore.Split(s);
            Email e = Email.Load(lsAttr[1]);
            Password p = Password.Load(lsAttr[2]);
            return new Account(lsAttr[0], e, p, lsAttr[3]);
        }
    }
}