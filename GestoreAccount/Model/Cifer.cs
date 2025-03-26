using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cifer
    {     
        public static String Cripta(String msg, String psd)
        {
            String ret = "";
            int conta = psd.Length - 1;
            for (int i = 0; i < msg.Length; i++)
            {
                if (conta < 0)
                {
                    conta = psd.Length - 1;
                }
                ret += (char)(((int)msg[i] + (int)psd[conta]) % 256); //256 valori possibili
                conta--;
            }
            return ret;
        }

        public static String Decripta(String msg, String psd)
        {
            String ret = "";
            int conta = psd.Length - 1;
            for (int i = 0; i < msg.Length; i++)
            {
                if (conta < 0)
                {
                    conta = psd.Length - 1;
                }
                ret += (char)(((int)msg[i] - (int)psd[conta] + 256) % 256); //gestione dei valori negativi
                conta--;
            }
            return ret;
        }
    }
}
