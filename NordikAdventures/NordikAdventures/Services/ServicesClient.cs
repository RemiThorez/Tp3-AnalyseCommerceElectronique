using NordikAdventures.Modeles;
using NordikAdventures.Modeles.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NordikAdventures.Services
{
    public class ServicesClient
    {
        private readonly HttpClient _http;
        public ServicesClient() 
        {
            _http = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7000/api/client/")
            };
            _http.DefaultRequestHeaders.Add("CleAPI",ConfigAPI.cle);
        }

        private void AjouterBearerScheme(string jeton)
        {
            if (!_http.DefaultRequestHeaders.Contains("Authorization"))
                _http.DefaultRequestHeaders.Add("Authorization", $"Bearer {jeton}");
        }

        public async Task<bool> CreerClient(CreerClientDTO client)
        {
            var json = JsonSerializer.Serialize(client);
            StringContent contenu = new StringContent(json, Encoding.UTF8, "application/json");

            var reponse = await _http.PostAsync("creer", contenu);

            if (reponse.IsSuccessStatusCode)
            {
                return true;
            }

            if(reponse.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                MessageBox.Show("Le courriel est déjà utilisé !\nVeuillez en choisir un autre.");
            }
            else
            {
                MessageBox.Show("ERREUR! Échec de la création d'un compte client !");
            }
            return true;
        }

        public async Task<Clients> OtenirClient(string jeton)
        {
            AjouterBearerScheme(jeton);

            var reponse = await _http.GetAsync("");

            if (reponse.IsSuccessStatusCode)
            {
                var reponseBody = await reponse.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<Clients>(reponseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            return new Clients();
        }

        public async Task<bool> ConfirmerCommandeClient(string jeton, Clients client)
        {
            AjouterBearerScheme(jeton);
            CommandeClientDTO comm = new CommandeClientDTO(client);

            var json = JsonSerializer.Serialize(comm);
            StringContent contenu = new StringContent(json, Encoding.UTF8, "application/json");

            var reponse = await _http.PostAsync("commande", contenu);

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
