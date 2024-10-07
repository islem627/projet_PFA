using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_back_.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurantTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<byte>(type: "tinyint", nullable: false)
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
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "EtatCommandes",
                columns: table => new
                {
                    IdEtat = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CommandeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtatCommandes", x => x.IdEtat);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    IdItem = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrixRepas = table.Column<float>(type: "real", nullable: false),
                    IdRepas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.IdItem);
                });

            migrationBuilder.CreateTable(
                name: "Livreurs",
                columns: table => new
                {
                    IdLivreur = table.Column<byte>(type: "tinyint", nullable: false)
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
                    table.PrimaryKey("PK_Livreurs", x => x.IdLivreur);
                });

            migrationBuilder.CreateTable(
                name: "Paniers",
                columns: table => new
                {
                    IdPanier = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NbrArticle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paniers", x => x.IdPanier);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    IdRestaurant = table.Column<byte>(type: "tinyint", nullable: false)
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
                    IdStatus = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusLivraisons", x => x.IdStatus);
                });

            migrationBuilder.CreateTable(
                name: "Commandes",
                columns: table => new
                {
                    NumCom = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePreparation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnregistrement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSuppression = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FK_IdEtat = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commandes", x => x.NumCom);
                    table.ForeignKey(
                        name: "FK_Commandes_EtatCommandes_FK_IdEtat",
                        column: x => x.FK_IdEtat,
                        principalTable: "EtatCommandes",
                        principalColumn: "IdEtat",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    IdMenu = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categories = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FK_IdPanier = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.IdMenu);
                    table.ForeignKey(
                        name: "FK_Menus_Paniers_FK_IdPanier",
                        column: x => x.FK_IdPanier,
                        principalTable: "Paniers",
                        principalColumn: "IdPanier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Livraisons",
                columns: table => new
                {
                    IdLivraison = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionSpec = table.Column<float>(type: "real", nullable: false),
                    DateEnvoi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLivraison = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateArrivee = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FK_IdPanier = table.Column<byte>(type: "tinyint", nullable: false),
                    FK_IdStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    FK_IdLivreur = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livraisons", x => x.IdLivraison);
                    table.ForeignKey(
                        name: "FK_Livraisons_Livreurs_FK_IdLivreur",
                        column: x => x.FK_IdLivreur,
                        principalTable: "Livreurs",
                        principalColumn: "IdLivreur",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Livraisons_Paniers_FK_IdPanier",
                        column: x => x.FK_IdPanier,
                        principalTable: "Paniers",
                        principalColumn: "IdPanier",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Livraisons_StatusLivraisons_FK_IdStatus",
                        column: x => x.FK_IdStatus,
                        principalTable: "StatusLivraisons",
                        principalColumn: "IdStatus",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client_Commandes",
                columns: table => new
                {
                    FK_IdClient = table.Column<byte>(type: "tinyint", nullable: false),
                    FK_NumCom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Commandes", x => new { x.FK_IdClient, x.FK_NumCom });
                    table.ForeignKey(
                        name: "FK_Client_Commandes_Clients_FK_IdClient",
                        column: x => x.FK_IdClient,
                        principalTable: "Clients",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Commandes_Commandes_FK_NumCom",
                        column: x => x.FK_NumCom,
                        principalTable: "Commandes",
                        principalColumn: "NumCom",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant_Commandes",
                columns: table => new
                {
                    FK_IdRestaurant = table.Column<byte>(type: "tinyint", nullable: false),
                    FK_NumCom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant_Commandes", x => new { x.FK_IdRestaurant, x.FK_NumCom });
                    table.ForeignKey(
                        name: "FK_Restaurant_Commandes_Commandes_FK_NumCom",
                        column: x => x.FK_NumCom,
                        principalTable: "Commandes",
                        principalColumn: "NumCom",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Restaurant_Commandes_Restaurants_FK_IdRestaurant",
                        column: x => x.FK_IdRestaurant,
                        principalTable: "Restaurants",
                        principalColumn: "IdRestaurant",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Constituers",
                columns: table => new
                {
                    FK_NumCom = table.Column<int>(type: "int", nullable: false),
                    IdMenu = table.Column<byte>(type: "tinyint", nullable: false),
                    Qte = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constituers", x => new { x.FK_NumCom, x.IdMenu });
                    table.ForeignKey(
                        name: "FK_Constituers_Commandes_FK_NumCom",
                        column: x => x.FK_NumCom,
                        principalTable: "Commandes",
                        principalColumn: "NumCom",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Constituers_Menus_IdMenu",
                        column: x => x.IdMenu,
                        principalTable: "Menus",
                        principalColumn: "IdMenu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menu_Items",
                columns: table => new
                {
                    FK_IdItem = table.Column<byte>(type: "tinyint", nullable: false),
                    FK_IdMenu = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu_Items", x => new { x.FK_IdItem, x.FK_IdMenu });
                    table.ForeignKey(
                        name: "FK_Menu_Items_Items_FK_IdItem",
                        column: x => x.FK_IdItem,
                        principalTable: "Items",
                        principalColumn: "IdItem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menu_Items_Menus_FK_IdMenu",
                        column: x => x.FK_IdMenu,
                        principalTable: "Menus",
                        principalColumn: "IdMenu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_Commandes_FK_NumCom",
                table: "Client_Commandes",
                column: "FK_NumCom");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_FK_IdEtat",
                table: "Commandes",
                column: "FK_IdEtat");

            migrationBuilder.CreateIndex(
                name: "IX_Constituers_IdMenu",
                table: "Constituers",
                column: "IdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Livraisons_FK_IdLivreur",
                table: "Livraisons",
                column: "FK_IdLivreur",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livraisons_FK_IdPanier",
                table: "Livraisons",
                column: "FK_IdPanier");

            migrationBuilder.CreateIndex(
                name: "IX_Livraisons_FK_IdStatus",
                table: "Livraisons",
                column: "FK_IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_Items_FK_IdMenu",
                table: "Menu_Items",
                column: "FK_IdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_FK_IdPanier",
                table: "Menus",
                column: "FK_IdPanier");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_Commandes_FK_NumCom",
                table: "Restaurant_Commandes",
                column: "FK_NumCom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client_Commandes");

            migrationBuilder.DropTable(
                name: "Constituers");

            migrationBuilder.DropTable(
                name: "Livraisons");

            migrationBuilder.DropTable(
                name: "Menu_Items");

            migrationBuilder.DropTable(
                name: "Restaurant_Commandes");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Livreurs");

            migrationBuilder.DropTable(
                name: "StatusLivraisons");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Commandes");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Paniers");

            migrationBuilder.DropTable(
                name: "EtatCommandes");
        }
    }
}
