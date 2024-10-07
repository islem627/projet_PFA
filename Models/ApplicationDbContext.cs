 using Microsoft.EntityFrameworkCore;
using app_back_.Models;
using Microsoft.EntityFrameworkCore;

namespace app_back_.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Livreur> Livreurs { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<EtatCommande> EtatCommandes { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Livraison> Livraisons { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<StatusLivraison> StatusLivraisons { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Panier> Paniers { get; set; }
        public DbSet<Constituer> Constituers { get; set; }
        public DbSet<Menu_Item> Menu_Items { get; set; }
        public DbSet<Client_Commande> Client_Commandes { get; set; }
        public DbSet<Restaurant_Commande> Restaurant_Commandes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client_Commande>()
    .HasKey(cc => new { cc.FK_IdClient, cc.FK_NumCom });

            modelBuilder.Entity<Client_Commande>()
                .HasOne(cc => cc.Client)
                .WithMany(c => c.Client_Commandes)
                .HasForeignKey(cc => cc.FK_IdClient);

            modelBuilder.Entity<Client_Commande>()
                .HasOne(cc => cc.Commande)
                .WithMany(c => c.Client_Commandes)
                .HasForeignKey(cc => cc.FK_NumCom);
            // Configuration de la clé composite pour la table de jonction
            modelBuilder.Entity<Restaurant_Commande>()
                  .HasKey(rc => new { rc.FK_IdRestaurant, rc.FK_NumCom });

            modelBuilder.Entity<Restaurant_Commande>()
                .HasOne(rc => rc.Restaurant)
                .WithMany(r => r.Restaurant_Commandes)
                .HasForeignKey(rc => rc.FK_IdRestaurant);  // Référence corrigée

            modelBuilder.Entity<Restaurant_Commande>()
                .HasOne(rc => rc.Commande)
                .WithMany(c => c.Restaurant_Commandes)
                .HasForeignKey(rc => rc.FK_NumCom);
            modelBuilder.Entity<Menu_Item>()
               .HasKey(mi => new { mi.FK_IdItem, mi.FK_IdMenu });

            // Relation entre Menu_Item et Item
            modelBuilder.Entity<Menu_Item>()
                .HasOne(mi => mi.Item)
                .WithMany(i => i.Menu_Items)
                .HasForeignKey(mi => mi.FK_IdItem);

            // Relation entre Menu_Item et Menu
            modelBuilder.Entity<Menu_Item>()
                .HasOne(mi => mi.Menu)
                .WithMany(m => m.Menu_Items)
                .HasForeignKey(mi => mi.FK_IdMenu);
            modelBuilder.Entity<Constituer>()
               .HasKey(c => new { c.FK_NumCom, c.IdMenu });

            // Relation entre Constituer et Commande
            modelBuilder.Entity<Constituer>()
                .HasOne(c => c.Commande)
                .WithMany(co => co.Constituers)
                .HasForeignKey(c => c.FK_NumCom);

            // Relation entre Constituer et Menu
            modelBuilder.Entity<Constituer>()
                .HasOne(c => c.Menu)
                .WithMany(m => m.Constituers)
                .HasForeignKey(c => c.IdMenu);
            // Configuration de la relation one-to-many entre Panier et Livraison
            modelBuilder.Entity<Panier>()
                .HasMany(p => p.Livraisons)
                .WithOne(l => l.Panier)
                .HasForeignKey(l => l.FK_IdPanier);

            // Configuration de la relation one-to-many entre Panier et Menu
            modelBuilder.Entity<Panier>()
                .HasMany(p => p.Menus)
                .WithOne(m => m.Panier)
                .HasForeignKey(m => m.FK_IdPanier);
        
        // Configuration de la relation one-to-one entre Livreur et Livraison
        modelBuilder.Entity<Livreur>()
            .HasOne(l => l.Livraison) // Chaque livreur a une livraison
            .WithOne(l => l.Livreur) // Chaque livrsaison a un livreur
            .HasForeignKey<Livraison>(l => l.FK_IdLivreur); // Clé étrangère vers Livreur
                                                            // Configuration de la relation one-to-many entre StatusLivraison et Livraison
            modelBuilder.Entity<StatusLivraison>()
                .HasMany(s => s.Livraisons) // Un StatusLivraison a plusieurs Livraisons
                .WithOne(l => l.StatusLivraison) // Une Livraison a un seul StatusLivraison
                .HasForeignKey(l => l.FK_IdStatus) // Clé étrangère dans Livraison
                .OnDelete(DeleteBehavior.Cascade); // Supprime les Livraisons associées si un StatusLivraison est supprimé
                                                   // Configuration de la relation one-to-many entre EtatCommande et Commande
            modelBuilder.Entity<EtatCommande>()
                .HasMany(e => e.Commandes) // Un EtatCommande a plusieurs Commandes
                .WithOne(c => c.EtatCommande) // Une Commande a un seul EtatCommande
                .HasForeignKey(c => c.FK_IdEtat) // Clé étrangère dans Commande
                .OnDelete(DeleteBehavior.Cascade); // Supprime les Commandes associées si un EtatCommande est supprimé
            modelBuilder.Entity<User>().ToTable("users");
        }
    }
}
