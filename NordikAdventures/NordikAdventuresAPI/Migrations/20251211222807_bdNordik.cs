using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NordikAdventuresAPI.Migrations
{
    /// <inheritdoc />
    public partial class bdNordik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TablesCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomCategorie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablesClients",
                columns: table => new
                {
                    ClientID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mdp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Courriel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statut = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Satisfaction = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesClients", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "TablesEmployes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccesProduits = table.Column<bool>(type: "bit", nullable: false),
                    AccesFinances = table.Column<bool>(type: "bit", nullable: false),
                    AccesClient = table.Column<bool>(type: "bit", nullable: false),
                    Admin = table.Column<bool>(type: "bit", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mdp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Courriel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesEmployes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablesFournisseurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RistourneFournisseur = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesFournisseurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablesParamFisc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TauxTaxe = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesParamFisc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablesFacturesClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdClient = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SousTotal = table.Column<double>(type: "float", nullable: false),
                    Taxes = table.Column<double>(type: "float", nullable: false),
                    MontantDu = table.Column<double>(type: "float", nullable: false),
                    Statut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateLimitePaiement = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesFacturesClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablesFacturesClients_TablesClients_IdClient",
                        column: x => x.IdClient,
                        principalTable: "TablesClients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TableActivitesClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdClient = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdEmploye = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableActivitesClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableActivitesClients_TablesClients_IdClient",
                        column: x => x.IdClient,
                        principalTable: "TablesClients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TableActivitesClients_TablesEmployes_IdEmploye",
                        column: x => x.IdEmploye,
                        principalTable: "TablesEmployes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TablesPayes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmploye = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Paye = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesPayes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablesPayes_TablesEmployes_IdEmploye",
                        column: x => x.IdEmploye,
                        principalTable: "TablesEmployes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TablesCommandesFournisseurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdFournisseur = table.Column<int>(type: "int", nullable: false),
                    Valider = table.Column<bool>(type: "bit", nullable: false),
                    Statut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateLimitePaiements = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontantDu = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesCommandesFournisseurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablesCommandesFournisseurs_TablesFournisseurs_IdFournisseur",
                        column: x => x.IdFournisseur,
                        principalTable: "TablesFournisseurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TablesProduits",
                columns: table => new
                {
                    SKU = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CodeFournisseur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomProduit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statut = table.Column<bool>(type: "bit", nullable: false),
                    Poids = table.Column<float>(type: "real", nullable: false),
                    CoutAchat = table.Column<double>(type: "float", nullable: false),
                    PrixVente = table.Column<double>(type: "float", nullable: false),
                    IdFournisseur = table.Column<int>(type: "int", nullable: false),
                    IdCategorie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesProduits", x => x.SKU);
                    table.ForeignKey(
                        name: "FK_TablesProduits_TablesCategories_IdCategorie",
                        column: x => x.IdCategorie,
                        principalTable: "TablesCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TablesProduits_TablesFournisseurs_IdFournisseur",
                        column: x => x.IdFournisseur,
                        principalTable: "TablesFournisseurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TablesPaiementsClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFacture = table.Column<int>(type: "int", nullable: false),
                    montantPayer = table.Column<double>(type: "float", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesPaiementsClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablesPaiementsClients_TablesFacturesClients_IdFacture",
                        column: x => x.IdFacture,
                        principalTable: "TablesFacturesClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TablesPaiementsFournisseurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCommande = table.Column<int>(type: "int", nullable: false),
                    Paiement = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesPaiementsFournisseurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablesPaiementsFournisseurs_TablesCommandesFournisseurs_IdCommande",
                        column: x => x.IdCommande,
                        principalTable: "TablesCommandesFournisseurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TableAchats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKU = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Qte = table.Column<int>(type: "int", nullable: false),
                    CoutHistorique = table.Column<double>(type: "float", nullable: false),
                    IdCommandeFournisseur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableAchats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableAchats_TablesCommandesFournisseurs_IdCommandeFournisseur",
                        column: x => x.IdCommandeFournisseur,
                        principalTable: "TablesCommandesFournisseurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TableAchats_TablesProduits_SKU",
                        column: x => x.SKU,
                        principalTable: "TablesProduits",
                        principalColumn: "SKU");
                });

            migrationBuilder.CreateTable(
                name: "TableActivitesStocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKU = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Qte = table.Column<int>(type: "int", nullable: false),
                    Raison = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableActivitesStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableActivitesStocks_TablesProduits_SKU",
                        column: x => x.SKU,
                        principalTable: "TablesProduits",
                        principalColumn: "SKU",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TablesStocks",
                columns: table => new
                {
                    SKU = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Qte = table.Column<int>(type: "int", nullable: false),
                    QteReserve = table.Column<int>(type: "int", nullable: false),
                    SeuilReaprovisionnement = table.Column<int>(type: "int", nullable: false),
                    SeuilMinimun = table.Column<int>(type: "int", nullable: false),
                    DelaiLivraison = table.Column<int>(type: "int", nullable: false),
                    Entrepot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateEntree = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesStocks", x => x.SKU);
                    table.ForeignKey(
                        name: "FK_TablesStocks_TablesProduits_SKU",
                        column: x => x.SKU,
                        principalTable: "TablesProduits",
                        principalColumn: "SKU",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TablesVentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKU = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Qte = table.Column<int>(type: "int", nullable: false),
                    PrixVenteHistorique = table.Column<double>(type: "float", nullable: false),
                    IdFacture = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesVentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablesVentes_TablesFacturesClients_IdFacture",
                        column: x => x.IdFacture,
                        principalTable: "TablesFacturesClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TablesVentes_TablesProduits_SKU",
                        column: x => x.SKU,
                        principalTable: "TablesProduits",
                        principalColumn: "SKU",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TableAchats_IdCommandeFournisseur",
                table: "TableAchats",
                column: "IdCommandeFournisseur");

            migrationBuilder.CreateIndex(
                name: "IX_TableAchats_SKU",
                table: "TableAchats",
                column: "SKU");

            migrationBuilder.CreateIndex(
                name: "IX_TableActivitesClients_IdClient",
                table: "TableActivitesClients",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_TableActivitesClients_IdEmploye",
                table: "TableActivitesClients",
                column: "IdEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_TableActivitesStocks_SKU",
                table: "TableActivitesStocks",
                column: "SKU");

            migrationBuilder.CreateIndex(
                name: "IX_TablesCommandesFournisseurs_IdFournisseur",
                table: "TablesCommandesFournisseurs",
                column: "IdFournisseur");

            migrationBuilder.CreateIndex(
                name: "IX_TablesFacturesClients_IdClient",
                table: "TablesFacturesClients",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_TablesPaiementsClients_IdFacture",
                table: "TablesPaiementsClients",
                column: "IdFacture");

            migrationBuilder.CreateIndex(
                name: "IX_TablesPaiementsFournisseurs_IdCommande",
                table: "TablesPaiementsFournisseurs",
                column: "IdCommande");

            migrationBuilder.CreateIndex(
                name: "IX_TablesPayes_IdEmploye",
                table: "TablesPayes",
                column: "IdEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_TablesProduits_IdCategorie",
                table: "TablesProduits",
                column: "IdCategorie");

            migrationBuilder.CreateIndex(
                name: "IX_TablesProduits_IdFournisseur",
                table: "TablesProduits",
                column: "IdFournisseur");

            migrationBuilder.CreateIndex(
                name: "IX_TablesVentes_IdFacture",
                table: "TablesVentes",
                column: "IdFacture");

            migrationBuilder.CreateIndex(
                name: "IX_TablesVentes_SKU",
                table: "TablesVentes",
                column: "SKU");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableAchats");

            migrationBuilder.DropTable(
                name: "TableActivitesClients");

            migrationBuilder.DropTable(
                name: "TableActivitesStocks");

            migrationBuilder.DropTable(
                name: "TablesPaiementsClients");

            migrationBuilder.DropTable(
                name: "TablesPaiementsFournisseurs");

            migrationBuilder.DropTable(
                name: "TablesParamFisc");

            migrationBuilder.DropTable(
                name: "TablesPayes");

            migrationBuilder.DropTable(
                name: "TablesStocks");

            migrationBuilder.DropTable(
                name: "TablesVentes");

            migrationBuilder.DropTable(
                name: "TablesCommandesFournisseurs");

            migrationBuilder.DropTable(
                name: "TablesEmployes");

            migrationBuilder.DropTable(
                name: "TablesFacturesClients");

            migrationBuilder.DropTable(
                name: "TablesProduits");

            migrationBuilder.DropTable(
                name: "TablesClients");

            migrationBuilder.DropTable(
                name: "TablesCategories");

            migrationBuilder.DropTable(
                name: "TablesFournisseurs");
        }
    }
}
