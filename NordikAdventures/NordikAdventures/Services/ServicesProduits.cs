using NordikAdventures.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NordikAdventures.Services
{
    public class ServicesProduits
    {
        private readonly HttpClient _http;

        public ServicesProduits()
        {
            _http = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7000/api/produit/")
            };
            _http.DefaultRequestHeaders.Add("CleAPI", ConfigAPI.cle);
        }
        
        private void AjouterBearerScheme(string jeton)
        {
            _http.DefaultRequestHeaders.Add("Authorization", "Bearer " + jeton);
        }

        public async Task<List<Produits>> ObtenirProduits(string jeton)
        {
            AjouterBearerScheme(jeton);

            var reponse = await _http.GetAsync("client");

            if (reponse.IsSuccessStatusCode)
            {
                var reponseBody = await reponse.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Produits>>(reponseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            return new List<Produits>();
        }
    }
}
