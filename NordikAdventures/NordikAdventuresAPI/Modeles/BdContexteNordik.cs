using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NordikAdventuresAPI.Modeles
{
    public partial class BdContexteNordik : DbContext
    {
        private string _stringConnexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Database=BdNordik;";

        public BdContexteNordik() { }

        public BdContexteNordik(string stringConnexion)
        {
            _stringConnexion = stringConnexion;
        }

        public virtual DbSet<Achats> TableAchats { get; set; }
        public virtual DbSet<ActivitesClients> TableActivitesClients { get; set; }
        public virtual DbSet<ActivitesStocks> TableActivitesStocks { get; set; }
        public virtual DbSet<Categories> TablesCategories { get; set; }
        public virtual DbSet<Clients> TablesClients { get; set; }
        public virtual DbSet<Employes> TablesEmployes { get; set; }
        public virtual DbSet<CommandesFournisseurs> TablesCommandesFournisseurs { get; set; }
        public virtual DbSet<FacturesClients> TablesFacturesClients { get; set; }
        public virtual DbSet<Fournisseurs> TablesFournisseurs { get; set; }
        public virtual DbSet<PaiementsClients> TablesPaiementsClients { get; set; }
        public virtual DbSet<PaiementsFournisseurs> TablesPaiementsFournisseurs { get; set; }
        public virtual DbSet<ParamFisc> TablesParamFisc { get; set; }
        public virtual DbSet<Payes> TablesPayes { get; set; }
        public virtual DbSet<Produits> TablesProduits { get; set; }
        public virtual DbSet<Stocks> TablesStocks { get; set; }
        public virtual DbSet<Ventes> TablesVentes { get; set; }

        public BdContexteNordik(DbContextOptions<BdContexteNordik> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(_stringConnexion);

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
