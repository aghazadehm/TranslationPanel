using System;
using System.Linq;
using Domain.Entities;

namespace InfraStructure.Repository
{
    public class TranslationRepository
    {
        private readonly AuctionDbContext _dbContext;

        public TranslationRepository(AuctionDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Save(Translator translatedPhrase)
        {
            _dbContext.TranslatedPhrases.Add(translatedPhrase);
            _dbContext.SaveChanges();
        }

        public Translator GetById(int id)
        {
            return _dbContext.TranslatedPhrases.FirstOrDefault(x => x.Id == id);
        }
    }
}