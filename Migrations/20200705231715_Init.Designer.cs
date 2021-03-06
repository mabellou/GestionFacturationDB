﻿// <auto-generated />
using System;
using GestionFacturation.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionFacturation.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200705231715_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("GestionFacturation.Api.Models.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Designation")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DevisId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasColumnType("TEXT");

                    b.Property<float>("PrixHT")
                        .HasColumnType("REAL");

                    b.Property<float>("PrixTTC")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantite")
                        .HasColumnType("INTEGER");

                    b.Property<float>("TVA")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("DevisId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.Categorie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Code")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nom")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Adresse")
                        .HasColumnType("TEXT");

                    b.Property<int>("CodePostal")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenom")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telephone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ville")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.Devis", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateLivaraison")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("FactureId")
                        .HasColumnType("TEXT");

                    b.Property<float>("PrixTotal")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("FactureId");

                    b.ToTable("Deviss");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.Facture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateEcheance")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateGeneration")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PaiementId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Statut")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("PaiementId");

                    b.ToTable("Factures");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.Paiement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float>("PrixTTC")
                        .HasColumnType("REAL");

                    b.Property<string>("StatutFacture")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Paiements");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.Produit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CategorieId")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Image")
                        .HasColumnType("BLOB");

                    b.Property<Guid?>("StockId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.HasIndex("StockId");

                    b.ToTable("Produits");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.Stock", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantite")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("ApiAccessLevels")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.Utilisateur", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Adresse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenom")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telephone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.Article", b =>
                {
                    b.HasOne("GestionFacturation.Api.Models.Devis", null)
                        .WithMany("Article")
                        .HasForeignKey("DevisId");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.Devis", b =>
                {
                    b.HasOne("GestionFacturation.Api.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("GestionFacturation.Api.Models.Facture", null)
                        .WithMany("Devis")
                        .HasForeignKey("FactureId");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.Facture", b =>
                {
                    b.HasOne("GestionFacturation.Api.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("GestionFacturation.Api.Models.Paiement", "Paiement")
                        .WithMany()
                        .HasForeignKey("PaiementId");
                });

            modelBuilder.Entity("GestionFacturation.Api.Models.Produit", b =>
                {
                    b.HasOne("GestionFacturation.Api.Models.Categorie", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieId");

                    b.HasOne("GestionFacturation.Api.Models.Stock", "Stock")
                        .WithMany()
                        .HasForeignKey("StockId");
                });
#pragma warning restore 612, 618
        }
    }
}
