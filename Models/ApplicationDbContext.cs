using Microsoft.EntityFrameworkCore;

namespace GestionFacturation.Api.Models
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Article> Articles { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Devis> Deviss { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<User> Users { get; set; }
        



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=GestionFacturationDB.db");
        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Client>().ToTable("Clients");
        //    modelBuilder.Entity<Devis>().ToTable("Deviss");
        //    modelBuilder.Entity<Facture>().ToTable("Factures");
        //    modelBuilder.Entity<Paiement>().ToTable("Paiements");
        //    modelBuilder.Entity<Produit>().ToTable("Produits");
        //    modelBuilder.Entity<Utilisateur>().ToTable("Utilisateurs");
        //}


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Devis>()
        //        .HasMany(c => c.Article);
           

        //}

        public void InitDb()
        {
            using var context = new ApplicationDbContext();

            context.Clients.AddRange(new Client[]
            {
                new Client()
                {
                    Prenom = "Askouri",
                    Nom = "Mohamed",
                    Ville = "Köln",
                    Adresse = "Deutz-Kalker-Staße 25",
                    Telephone = "01793226673",
                    CodePostal = 50679,
                    Email = "contact@askouri.de"
                },

                new Client()
                {
                    Prenom = "Bihi",
                    Nom = "Adam",
                    Ville = "Köln",
                    Adresse = "Deutz-Kalker-Staße 24",
                    Telephone = "01746226673",
                    CodePostal = 50679,
                    Email = "contact@askouri.de"
                },

                new Client()
                {
                    Prenom = "Bentahar",
                    Nom = "Anas",
                    Ville = "Köln",
                    Adresse = "Deutz-Kalker-Staße 24",
                    Telephone = "01746226673",
                    CodePostal = 50679,
                    Email = "contact@askouri.de"
                }

            });
            context.SaveChanges();


        }
    }
}
