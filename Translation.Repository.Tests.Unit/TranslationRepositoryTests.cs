
using Domain.Entities;
using Domain.Entities.Tests.Util.Builders;
using Domain.Entities.Tests.Util.EqualityComparers;
using InfraStructure.Repository;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Translation.Repository.Tests.Unit
{
    public class TranslationRepositoryTests : BasePersistenceTest<AuctionDbContext>
    {
        //usage
        //[Theory]
        //[MemberData(nameof(ValidPhraseTypes))]
        //public void ...(int id, string name, string title)
        public static IEnumerable<object[]> ValidPhraseTypes()
        {
            yield return new object[] { 7, "commodity", "کالا" };
            yield return new object[] { 1, "broker", "کارگزاری" };
            yield return new object[] { 11, "currency", "واحد ارز" };
        }
        
        [Fact]
        public void Repository_should_save_translate()
        {
            var repository = new TranslationRepository(DbContext);

            var phraseType = new PhraseType(7, "commodity", "کالا");
            var phrase = new Phrase(15, "گندم", phraseType);
            var language = new Language(1, "انگلیسی", "English", "EN");
            var translations = new List<Domain.Entities.Translation>()
            {
                new Domain.Entities.Translation(0, language, "Wheat")
            };
            var translatedPhrase = new TranslateBuilder()
                .WithPhrase(phrase)
                .WithTranslations(translations).Build();
            repository.Save(translatedPhrase);

            var id = translatedPhrase.Id;
            DbContext.ClearChangeTracker();


            var result = repository.GetById(id);
            Assert.Equal(result, translatedPhrase, new TranslatorEqualityComparer());
        }


    }
}
