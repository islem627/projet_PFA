using Microsoft.EntityFrameworkCore;
using RestaurantApi.Models;
using System.Numerics;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Compte> Comptes { get; set; }
    public DbSet<Client> Clients { get; set; }
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
}
