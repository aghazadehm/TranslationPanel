using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraStructure.Repository
{
    public class AuctionDbContext : DbContext
    {
        public DbSet<Translator> TranslatedPhrases { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PhraseType> PhraseTypes { get; set; }

        //public virtual DbSet<Currency> Currencies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=172.16.1.18;Initial Catalog=Auction;Persist Security Info=True;User ID=aghazadeh;Password=ime.2494829");
        }
    }
}
