namespace NordikAdventuresAPI.Utilitaires
{
    public static class Generateur
    {
        const int NB_CHIFFRE_12 = 12;
        public static string GenerateurMatricule16Carac(string nom)
        {
            nom = nom.Trim();
            string matricule = "";

            if (nom.Length == 1)
            {
                matricule = nom + nom + nom + nom;
            }
            else if (nom.Length == 0)
            {
                matricule = "erro";
            }
            else
            {
                matricule += nom.Substring(0, 2);
                matricule += nom.Substring(nom.Length - 2, 2);
            }

            Random gene = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < NB_CHIFFRE_12; ++i)
            {
                matricule += gene.Next(0, 9);
            }

            return matricule.ToUpper();
        }
    }
}
