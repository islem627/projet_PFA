﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace RestaurantApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240910191654_Client")]
    partial class Client
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantApi.Models.Commande", b =>
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

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdEtat")
                        .HasColumnType("int");

                    b.Property<int>("IdLivreur")
                        .HasColumnType("int");

                    b.Property<int>("IdRestaurant")
                        .HasColumnType("int");

                    b.Property<int>("IdStatus")
                        .HasColumnType("int");

                    b.HasKey("NumCom");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdEtat");

                    b.HasIndex("IdLivreur");

                    b.HasIndex("IdRestaurant");

                    b.HasIndex("IdStatus");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("RestaurantApi.Models.Compte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Comptes");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("RestaurantApi.Models.Constituer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Qte")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Constituers");
                });

            modelBuilder.Entity("RestaurantApi.Models.EtatCommande", b =>
                {
                    b.Property<int>("IdEtat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEtat"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumCom")
                        .HasColumnType("int");

                    b.HasKey("IdEtat");

                    b.ToTable("EtatCommandes");
                });

            modelBuilder.Entity("RestaurantApi.Models.Items", b =>
                {
                    b.Property<int>("IdMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMenu"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRepas")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PrixRepas")
                        .HasColumnType("real");

                    b.HasKey("IdMenu");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("RestaurantApi.Models.Livraison", b =>
                {
                    b.Property<int>("IdLivraison")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLivraison"));

                    b.Property<DateTime>("DateArrivee")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEnvoi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLivraison")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdLivreur")
                        .HasColumnType("int");

                    b.Property<int>("NumCom")
                        .HasColumnType("int");

                    b.Property<float>("TransactionSpec")
                        .HasColumnType("real");

                    b.HasKey("IdLivraison");

                    b.ToTable("Livraisons");
                });

            modelBuilder.Entity("RestaurantApi.Models.Menu", b =>
                {
                    b.Property<int>("IdMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMenu"));

                    b.Property<string>("Categories")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRestaurant")
                        .HasColumnType("int");

                    b.HasKey("IdMenu");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("RestaurantApi.Models.Panier", b =>
                {
                    b.Property<int>("IdPanier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPanier"));

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("NbrArticle")
                        .HasColumnType("int");

                    b.Property<int>("NumCom")
                        .HasColumnType("int");

                    b.HasKey("IdPanier");

                    b.ToTable("Paniers");
                });

            modelBuilder.Entity("RestaurantApi.Models.Restaurant", b =>
                {
                    b.Property<int>("IdRestaurant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRestaurant"));

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

            modelBuilder.Entity("RestaurantApi.Models.StatusLivraison", b =>
                {
                    b.Property<int>("IdLivraison")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLivraison"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdStatus")
                        .HasColumnType("int");

                    b.HasKey("IdLivraison");

                    b.ToTable("StatusLivraisons");
                });

            modelBuilder.Entity("RestaurantApi.Models.Client", b =>
                {
                    b.HasBaseType("RestaurantApi.Models.Compte");

                    b.Property<DateTime>("Horaire")
                        .HasColumnType("datetime2");

                    b.Property<byte>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("IdClient"));

                    b.ToTable("Clients", (string)null);
                });

            modelBuilder.Entity("RestaurantApi.Models.Livreur", b =>
                {
                    b.HasBaseType("RestaurantApi.Models.Compte");

                    b.Property<DateTime>("Horaire")
                        .HasColumnType("datetime2");

                    b.Property<byte>("IdLivreur")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("IdLivreur"));

                    b.ToTable("Livreurs");
                });

            modelBuilder.Entity("RestaurantApi.Models.Commande", b =>
                {
                    b.HasOne("RestaurantApi.Models.Client", "Client")
                        .WithMany("Commandes")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantApi.Models.EtatCommande", "EtatCommande")
                        .WithMany("Commandes")
                        .HasForeignKey("IdEtat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantApi.Models.Livreur", "Livreur")
                        .WithMany("Commandes")
                        .HasForeignKey("IdLivreur")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantApi.Models.Restaurant", "Restaurant")
                        .WithMany("Commandes")
                        .HasForeignKey("IdRestaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantApi.Models.StatusLivraison", "StatusLivraison")
                        .WithMany("Commandes")
                        .HasForeignKey("IdStatus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("EtatCommande");

                    b.Navigation("Livreur");

                    b.Navigation("Restaurant");

                    b.Navigation("StatusLivraison");
                });

            modelBuilder.Entity("RestaurantApi.Models.Client", b =>
                {
                    b.HasOne("RestaurantApi.Models.Compte", null)
                        .WithOne()
                        .HasForeignKey("RestaurantApi.Models.Client", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantApi.Models.Livreur", b =>
                {
                    b.HasOne("RestaurantApi.Models.Compte", null)
                        .WithOne()
                        .HasForeignKey("RestaurantApi.Models.Livreur", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantApi.Models.EtatCommande", b =>
                {
                    b.Navigation("Commandes");
                });

            modelBuilder.Entity("RestaurantApi.Models.Restaurant", b =>
                {
                    b.Navigation("Commandes");
                });

            modelBuilder.Entity("RestaurantApi.Models.StatusLivraison", b =>
                {
                    b.Navigation("Commandes");
                });

            modelBuilder.Entity("RestaurantApi.Models.Client", b =>
                {
                    b.Navigation("Commandes");
                });

            modelBuilder.Entity("RestaurantApi.Models.Livreur", b =>
                {
                    b.Navigation("Commandes");
                });
#pragma warning restore 612, 618
        }
    }
}
