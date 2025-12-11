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

                //Vérifiez que le courriel n'est pas déjà utilisé !

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //Nom, mdp, 
        public static bool ValiderChampsCommun(string str)
        {
            if(str == "" || str == " ")
                return false;
            return true;
        }

        public static bool ValiderTel(string tel)
        {
            return true;
        }
    }
}
