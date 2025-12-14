using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventures.Modeles
{
    public class Paniers : INotifyPropertyChanged
    {
        public Paniers(Produits produit, int qte) 
        {
            LeProduits = produit;
            if(qte > produit.QteDisponible)
                Qte = produit.QteDisponible;
            else
                Qte = qte;
        }

        private int _qte;

        public int Qte
        {
            get => _qte;
            set
            {
                if (_qte != value)
                {
                    _qte = value;
                    OnPropertyChanged(nameof(Qte));
                }
            }
        }

        public Produits LeProduits { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string prop)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public override string ToString()
        {
            return $"{LeProduits.NomProduit} | {Qte}";
        }
    }
}
