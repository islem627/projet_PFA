using Microsoft.EntityFrameworkCore;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Définition des DbSets pour chaque entité
    
    public DbSet<Compte> Comptes { get; set; }
    public DbSet<Client> Clients { get; set; }
    // Autres DbSets...

    
   
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Livreur> Livreurs { get; set; }
    public DbSet<Commande> Commandes { get; set; }
    public DbSet<EtatCommande> EtatCommandes { get; set; }
    public DbSet<Constituer> Constituers { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<Items> Items { get; set; }
    public DbSet<Panier> Paniers { get; set; }
    public DbSet<Livraison> Livraisons { get; set; }
    public DbSet<StatusLivraison> StatusLivraisons { get; set; }

    // Méthode OnModelCreating pour les configurations Fluent API
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Exemple de configuration pour la table "Clients"
        modelBuilder.Entity<Client>().ToTable("Clients");

        // Configuration des relations entre les entités
        modelBuilder.Entity<Commande>()
            .HasOne(c => c.Client)
            .WithMany(c => c.Commandes)
            .HasForeignKey(c => c.IdClient);

        modelBuilder.Entity<Commande>()
            .HasOne(c => c.Restaurant)
            .WithMany(r => r.Commandes)
            .HasForeignKey(c => c.IdRestaurant);

        modelBuilder.Entity<Commande>()
            .HasOne(c => c.Livreur)
            .WithMany(l => l.Commandes)
            .HasForeignKey(c => c.IdLivreur);

        modelBuilder.Entity<Commande>()
            .HasOne(c => c.EtatCommande)
            .WithMany(e => e.Commandes)
            .HasForeignKey(c => c.IdEtat);

        modelBuilder.Entity<Commande>()
            .HasOne(c => c.StatusLivraison)
            .WithMany(s => s.Commandes)
            .HasForeignKey(c => c.IdStatus);

        // Configurations pour d'autres entités si nécessaire...
    }
}
