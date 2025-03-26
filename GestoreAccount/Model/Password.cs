using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    public  class Password
    {
        private String psd;

        public Password(String psd)
        {
            this.psd = psd;
        }

        public String Psd { get => psd; set => psd = value; }

        public static string GeneratePassword(int length)
        {
            string password = "";
            if (length >= 8)
            {
                string lowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
                string upperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string numbers = "0123456789";
                string specialCharacters = "@#§£$%&=";

                Random random = new Random();

                bool containsLowerCase = false;
                bool containsUpperCase = false;
                bool containsNumber = false;
                bool containsSpecialChar = false;

                while (password.Length < length || !containsLowerCase || !containsUpperCase || !containsNumber || !containsSpecialChar)
                {
                    password = "";
                    containsLowerCase = false;
                    containsUpperCase = false;
                    containsNumber = false;
                    containsSpecialChar = false;

                    for (int i = 0; i < length; i++)
                    {
                        int category = random.Next(4);
                        if (category == 0)
                        {
                            password += lowerCaseLetters[random.Next(lowerCaseLetters.Length)];
                            containsLowerCase = true;
                        }
                        else if (category == 1)
                        {
                            password += upperCaseLetters[random.Next(upperCaseLetters.Length)];
                            containsUpperCase = true;
                        }
                        else if (category == 2)
                        {
                            password += numbers[random.Next(numbers.Length)];
                            containsNumber = true;
                        }
                        else
                        {
                            password += specialCharacters[random.Next(specialCharacters.Length)];
                            containsSpecialChar = true;
                        }
                    }
                }

                if (!IsAcceptable(password))
                {
                    password = GeneratePassword(length);
                }

                return password;
            }
            return password;
        }

        public static Boolean IsAcceptable(String psd)
        {
            if (Regex.Match(psd, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\d\w]).{8,}$").Success)
            {
                return true;
            }
            return false;
        }

        public void Cripta(String psd)
        {
            this.psd = Cifer.Cripta(this.psd, psd);
        }

        public void Decripta(String psd)
        {
            this.psd = Cifer.Decripta(this.psd, psd);
        }

        public String Save()
        {
            return Normalizzatore.Normalize(psd) + Normalizzatore.DEL;
        }

        public static Password Load(String s)
        {
            return new Password(Normalizzatore.Split(s)[0]);
        }

        public override string ToString()
        {
            return psd;
        }
    }
}
