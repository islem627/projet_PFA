﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using app_back_.Models;

#nullable disable

namespace app_back_.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240930161803_xx")]
    partial class xx
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("app_back_.Models.Client", b =>
                {
                    b.Property<byte>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("IdClient"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Horaire")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NumTel")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdClient");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("app_back_.Models.Client_Commande", b =>
                {
                    b.Property<byte>("FK_IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnOrder(0);

                    b.Property<int>("FK_NumCom")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("FK_IdClient", "FK_NumCom");

                    b.HasIndex("FK_NumCom");

                    b.ToTable("Client_Commandes");
                });

            modelBuilder.Entity("app_back_.Models.Commande", b =>
                {
                    b.Property<int>("NumCom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NumCom"));

                    b.Property<DateTime>("DateEnregistrement")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePreparation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSuppression")
                        .HasColumnType("datetime2");

                    b.Property<byte>("FK_IdEtat")
                        .HasColumnType("tinyint");

                    b.HasKey("NumCom");

                    b.HasIndex("FK_IdEtat");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("app_back_.Models.Constituer", b =>
                {
                    b.Property<int>("FK_NumCom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<byte>("IdMenu")
                        .HasColumnType("tinyint")
                        .HasColumnOrder(1);

                    b.Property<int>("Qte")
                        .HasColumnType("int");

                    b.HasKey("FK_NumCom", "IdMenu");

                    b.HasIndex("IdMenu");

                    b.ToTable("Constituers");
                });

            modelBuilder.Entity("app_back_.Models.EtatCommande", b =>
                {
                    b.Property<byte>("IdEtat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("IdEtat"));

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdEtat");

                    b.ToTable("EtatCommandes");
                });

            modelBuilder.Entity("app_back_.Models.Item", b =>
                {
                    b.Property<byte>("IdItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("IdItem"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdRepas")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("PrixRepas")
                        .HasColumnType("real");

                    b.HasKey("IdItem");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("app_back_.Models.Livraison", b =>
                {
                    b.Property<byte>("IdLivraison")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("IdLivraison"));

                    b.Property<DateTime>("DateArrivee")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEnvoi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLivraison")
                        .HasColumnType("datetime2");

                    b.Property<byte>("FK_IdLivreur")
                        .HasColumnType("tinyint");

                    b.Property<byte>("FK_IdPanier")
                        .HasColumnType("tinyint");

                    b.Property<byte>("FK_IdStatus")
                        .HasColumnType("tinyint");

                    b.Property<float>("TransactionSpec")
                        .HasColumnType("real");

                    b.HasKey("IdLivraison");

                    b.HasIndex("FK_IdLivreur")
                        .IsUnique();

                    b.HasIndex("FK_IdPanier");

                    b.HasIndex("FK_IdStatus");

                    b.ToTable("Livraisons");
                });

            modelBuilder.Entity("app_back_.Models.Livreur", b =>
                {
                    b.Property<byte>("IdLivreur")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("IdLivreur"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Horaire")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NumTel")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdLivreur");

                    b.ToTable("Livreurs");
                });

            modelBuilder.Entity("app_back_.Models.Menu", b =>
                {
                    b.Property<byte>("IdMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("IdMenu"));

                    b.Property<string>("Categories")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte>("FK_IdPanier")
                        .HasColumnType("tinyint");

                    b.HasKey("IdMenu");

                    b.HasIndex("FK_IdPanier");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("app_back_.Models.Menu_Item", b =>
                {
                    b.Property<byte>("FK_IdItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnOrder(0);

                    b.Property<byte>("FK_IdMenu")
                        .HasColumnType("tinyint")
                        .HasColumnOrder(1);

                    b.HasKey("FK_IdItem", "FK_IdMenu");

                    b.HasIndex("FK_IdMenu");

                    b.ToTable("Menu_Items");
                });

            modelBuilder.Entity("app_back_.Models.Panier", b =>
                {
                    b.Property<byte>("IdPanier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("IdPanier"));

                    b.Property<int>("NbrArticle")
                        .HasColumnType("int");

                    b.HasKey("IdPanier");

                    b.ToTable("Paniers");
                });

            modelBuilder.Entity("app_back_.Models.Restaurant", b =>
                {
                    b.Property<byte>("IdRestaurant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("IdRestaurant"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Horaire")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NumTel")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdRestaurant");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("app_back_.Models.Restaurant_Commande", b =>
                {
                    b.Property<byte>("FK_IdRestaurant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnOrder(0);

                    b.Property<int>("FK_NumCom")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("FK_IdRestaurant", "FK_NumCom");

                    b.HasIndex("FK_NumCom");

                    b.ToTable("Restaurant_Commandes");
                });

            modelBuilder.Entity("app_back_.Models.StatusLivraison", b =>
                {
                    b.Property<byte>("IdStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("IdStatus"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdStatus");

                    b.ToTable("StatusLivraisons");
                });

            modelBuilder.Entity("app_back_.Models.Client_Commande", b =>
                {
                    b.HasOne("app_back_.Models.Client", "Client")
                        .WithMany("Client_Commandes")
                        .HasForeignKey("FK_IdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app_back_.Models.Commande", "Commande")
                        .WithMany("Client_Commandes")
                        .HasForeignKey("FK_NumCom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Commande");
                });

            modelBuilder.Entity("app_back_.Models.Commande", b =>
                {
                    b.HasOne("app_back_.Models.EtatCommande", "EtatCommande")
                        .WithMany("Commandes")
                        .HasForeignKey("FK_IdEtat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EtatCommande");
                });

            modelBuilder.Entity("app_back_.Models.Constituer", b =>
                {
                    b.HasOne("app_back_.Models.Commande", "Commande")
                        .WithMany("Constituers")
                        .HasForeignKey("FK_NumCom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app_back_.Models.Menu", "Menu")
                        .WithMany("Constituers")
                        .HasForeignKey("IdMenu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commande");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("app_back_.Models.Livraison", b =>
                {
                    b.HasOne("app_back_.Models.Livreur", "Livreur")
                        .WithOne("Livraison")
                        .HasForeignKey("app_back_.Models.Livraison", "FK_IdLivreur")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app_back_.Models.Panier", "Panier")
                        .WithMany("Livraisons")
                        .HasForeignKey("FK_IdPanier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app_back_.Models.StatusLivraison", "StatusLivraison")
                        .WithMany("Livraisons")
                        .HasForeignKey("FK_IdStatus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livreur");

                    b.Navigation("Panier");

                    b.Navigation("StatusLivraison");
                });

            modelBuilder.Entity("app_back_.Models.Menu", b =>
                {
                    b.HasOne("app_back_.Models.Panier", "Panier")
                        .WithMany("Menus")
                        .HasForeignKey("FK_IdPanier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Panier");
                });

            modelBuilder.Entity("app_back_.Models.Menu_Item", b =>
                {
                    b.HasOne("app_back_.Models.Item", "Item")
                        .WithMany("Menu_Items")
                        .HasForeignKey("FK_IdItem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app_back_.Models.Menu", "Menu")
                        .WithMany("Menu_Items")
                        .HasForeignKey("FK_IdMenu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("app_back_.Models.Restaurant_Commande", b =>
                {
                    b.HasOne("app_back_.Models.Restaurant", "Restaurant")
                        .WithMany("Restaurant_Commandes")
                        .HasForeignKey("FK_IdRestaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app_back_.Models.Commande", "Commande")
                        .WithMany("Restaurant_Commandes")
                        .HasForeignKey("FK_NumCom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commande");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("app_back_.Models.Client", b =>
                {
                    b.Navigation("Client_Commandes");
                });

            modelBuilder.Entity("app_back_.Models.Commande", b =>
                {
                    b.Navigation("Client_Commandes");

                    b.Navigation("Constituers");

                    b.Navigation("Restaurant_Commandes");
                });

            modelBuilder.Entity("app_back_.Models.EtatCommande", b =>
                {
                    b.Navigation("Commandes");
                });

            modelBuilder.Entity("app_back_.Models.Item", b =>
                {
                    b.Navigation("Menu_Items");
                });

            modelBuilder.Entity("app_back_.Models.Livreur", b =>
                {
                    b.Navigation("Livraison")
                        .IsRequired();
                });

            modelBuilder.Entity("app_back_.Models.Menu", b =>
                {
                    b.Navigation("Constituers");

                    b.Navigation("Menu_Items");
                });

            modelBuilder.Entity("app_back_.Models.Panier", b =>
                {
                    b.Navigation("Livraisons");

                    b.Navigation("Menus");
                });

            modelBuilder.Entity("app_back_.Models.Restaurant", b =>
                {
                    b.Navigation("Restaurant_Commandes");
                });

            modelBuilder.Entity("app_back_.Models.StatusLivraison", b =>
                {
                    b.Navigation("Livraisons");
                });
#pragma warning restore 612, 618
        }
    }
}
