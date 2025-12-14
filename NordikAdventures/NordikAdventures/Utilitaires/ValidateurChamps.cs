using System;
using System.Net.Mail;

namespace NordikAdventures.Utilitaires
{
    internal static class ValidateurChamps
    {
        public static bool ValiderCourriel(string courriel)
        {
            try
            {
                if (courriel == "" || courriel == " ")
                    return false;
                MailAddress ma = new MailAddress(courriel);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool ValiderChampsCommun(string str)
        {
            if(str == "" || str == " ")
                return false;
            return true;
        }

        public static bool ValiderTel(string tel)
        {
            try
            {
                int.Parse(tel);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
