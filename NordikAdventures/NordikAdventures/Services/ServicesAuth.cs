using NordikAdventures.Modeles.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NordikAdventures.Services
{
    public class ServicesAuth
    {
        private readonly HttpClient _http;
        public ServicesAuth()
        {
            _http = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7000/api/auth/")
            };
            _http.DefaultRequestHeaders.Add("CleAPI", ConfigAPI.cle);
        }

        public async Task<string> ConnexionClient(string courriel, string mdp)
        {
            ConnexionDTO infoConn = new ConnexionDTO(courriel, mdp);

            var json = JsonSerializer.Serialize(infoConn);
            StringContent contenu = new StringContent(json, Encoding.UTF8, "application/json");

            var reponse = await _http.PostAsync("client", contenu);

            if (reponse.IsSuccessStatusCode)
            {
                var reponseBody = await reponse.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<string>(reponseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            return "";
        }
    }
}
