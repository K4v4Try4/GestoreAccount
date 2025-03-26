using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Normalizzatore
    {
        public const String DEL = "|";  //tube
        public const String LIB = "~";  //tilde

        public static String Normalize(String s) //prepara la str ad essere messa in lista
        {
            s = s.Replace("~", "~~"); //libero i liberatori già presenti
            return s.Replace("|", "~|"); //libero i delimitatori già presenti
        }

        // ~ --> "liberatore": prendi alla lettera il carattere successivo
        // | --> "delimitatore": separa le stringhe

        public static List<String> Split(String s)
        {
            String temp = "";
            List<String> list = new List<String>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('~'))
                {
                    temp += s[i + 1];
                    i++;
                }
                else if (s[i].Equals('|'))
                {
                    list.Add(temp);
                    temp = "";
                }
                else
                {
                    temp += s[i];
                }
            }
            if(temp.Length > 0) //se finisce con "|" non aggiunge un elemento vuoto
            {
                list.Add(temp);
            }
            return list;
        }
    }
}
