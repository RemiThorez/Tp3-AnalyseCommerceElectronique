using NordikAdventures.Modeles;
using NordikAdventures.Modeles.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NordikAdventures.Services
{
    public class ServicesFinances
    {
        private readonly HttpClient _http;
        public ServicesFinances()
        {
            _http = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7000/api/finance/")
            };
            _http.DefaultRequestHeaders.Add("CleAPI", ConfigAPI.cle);
        }

        private void AjouterBearerScheme(string jeton)
        {
            if (!_http.DefaultRequestHeaders.Contains("Authorization"))
                _http.DefaultRequestHeaders.Add("Authorization", $"Bearer {jeton}");
        }

        public async Task<List<FacturesClients>> ObtenirFacturesClient(string jeton)
        {
            AjouterBearerScheme(jeton);
            var reponse = await _http.GetAsync("factsclient");

            if (reponse.IsSuccessStatusCode)
            {
                var reponseBody = await reponse.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<FacturesClients>>(reponseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            return new List<FacturesClients>();
        }

        public async Task<bool> PayerCommandeClient(string jeton, int idFacture, double montantPayer)
        {
            AjouterBearerScheme(jeton);
            PaiementClientDTO paiement = new PaiementClientDTO(idFacture, montantPayer);

            var json = JsonSerializer.Serialize(paiement);
            StringContent contenu = new StringContent(json, Encoding.UTF8, "application/json");

            var reponse = await _http.PutAsync("paiementClient", contenu);

            if (reponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Création de la commande réussi !");
                return true;
            }
            MessageBox.Show("ERREUR! Échec de la confirmation de la commande !");
            return false;
        }
    }
}
