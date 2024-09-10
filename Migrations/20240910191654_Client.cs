using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantApi.Migrations
{
    /// <inheritdoc />
    public partial class Client : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comptes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumTel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comptes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Constituers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qte = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constituers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EtatCommandes",
                columns: table => new
                {
                    IdEtat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumCom = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtatCommandes", x => x.IdEtat);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    IdMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrixRepas = table.Column<float>(type: "real", nullable: false),
                    IdRepas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.IdMenu);
                });

            migrationBuilder.CreateTable(
                name: "Livraisons",
                columns: table => new
                {
                    IdLivraison = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLivreur = table.Column<int>(type: "int", nullable: false),
                    TransactionSpec = table.Column<float>(type: "real", nullable: false),
                    NumCom = table.Column<int>(type: "int", nullable: false),
                    DateEnvoi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLivraison = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateArrivee = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livraisons", x => x.IdLivraison);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    IdMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categories = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRestaurant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.IdMenu);
                });

            migrationBuilder.CreateTable(
                name: "Paniers",
                columns: table => new
                {
                    IdPanier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NbrArticle = table.Column<int>(type: "int", nullable: false),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    NumCom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paniers", x => x.IdPanier);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    IdRestaurant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Horaire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NumTel = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.IdRestaurant);
                });

            migrationBuilder.CreateTable(
                name: "StatusLivraisons",
                columns: table => new
                {
                    IdLivraison = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdStatus = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusLivraisons", x => x.IdLivraison);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IdClient = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Horaire = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Comptes_Id",
                        column: x => x.Id,
                        principalTable: "Comptes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Livreurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IdLivreur = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Horaire = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livreurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livreurs_Comptes_Id",
                        column: x => x.Id,
                        principalTable: "Comptes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commandes",
                columns: table => new
                {
                    NumCom = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePreparation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdRestaurant = table.Column<int>(type: "int", nullable: false),
                    IdStatus = table.Column<int>(type: "int", nullable: false),
                    IdLivreur = table.Column<int>(type: "int", nullable: false),
                    IdEtat = table.Column<int>(type: "int", nullable: false),
                    DateEnregistrement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSuppression = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commandes", x => x.NumCom);
                    table.ForeignKey(
                        name: "FK_Commandes_Clients_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commandes_EtatCommandes_IdEtat",
                        column: x => x.IdEtat,
                        principalTable: "EtatCommandes",
                        principalColumn: "IdEtat",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commandes_Livreurs_IdLivreur",
                        column: x => x.IdLivreur,
                        principalTable: "Livreurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commandes_Restaurants_IdRestaurant",
                        column: x => x.IdRestaurant,
                        principalTable: "Restaurants",
                        principalColumn: "IdRestaurant",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commandes_StatusLivraisons_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "StatusLivraisons",
                        principalColumn: "IdLivraison",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_IdClient",
                table: "Commandes",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_IdEtat",
                table: "Commandes",
                column: "IdEtat");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_IdLivreur",
                table: "Commandes",
                column: "IdLivreur");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_IdRestaurant",
                table: "Commandes",
                column: "IdRestaurant");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_IdStatus",
                table: "Commandes",
                column: "IdStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commandes");

            migrationBuilder.DropTable(
                name: "Constituers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Livraisons");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Paniers");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "EtatCommandes");

            migrationBuilder.DropTable(
                name: "Livreurs");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "StatusLivraisons");

            migrationBuilder.DropTable(
                name: "Comptes");
        }
    }
}
