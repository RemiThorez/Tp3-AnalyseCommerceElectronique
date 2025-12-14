using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventures.Modeles.DTOs
{
    public class CommandeClientDTO
    {
        public CommandeClientDTO() { }
        public CommandeClientDTO(Clients client)
        {
            foreach (Paniers p in client.Paniers)
            {
                Paniers.Add(new ProduitQteDTO(p));
            }

            Satisfaction = client.Satisfaction;
        }

        public List<ProduitQteDTO> Paniers { get; set; } = new List<ProduitQteDTO>();
        public int Satisfaction { get; set; }
    }
}
