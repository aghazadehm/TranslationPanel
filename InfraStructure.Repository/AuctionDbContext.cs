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
            optionsBuilder.UseSqlServer(@"*************************");
        }
    }
}
