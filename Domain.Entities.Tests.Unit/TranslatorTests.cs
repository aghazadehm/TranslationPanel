using Domain.Entities.Tests.Util.Builders;
using Domain.Entities.Tests.Util.EqualityComparers;
using System.Collections.Generic;
using Xunit;

namespace Domain.Entities.Tests.Unit
{
    public class TranslatorTests
    {
        private readonly TranslateBuilder _sutBuilder;
        public TranslatorTests()
        {
            _sutBuilder = new TranslateBuilder();
        }
        [Fact]
        public void When_create_translator_shoud_be_created()
        {
            var langs = new Languages();
            int languageId = langs[1].Id;
            int phreaseId = 1;
            int phraseTypeId = 7;
            var translatedPhrase = new TranslatedPhraseBuilder()
                .WithLanguageId(languageId)
                .WithPhraseId(phreaseId)
                .WithPhraseTypeId(phraseTypeId)
                .WithTranlate("Wheat").Build();
            int id = 1;
            var translations = new List<Translation>(){ 
                new Translation(0, lang, "Wheat")
            };
            Translator sut = _sutBuilder.WithId(id).WithPhrase(phrase).WithTranslations(translations).Build();
            Translator expected = new Translator(id, phrase, translations);

            Assert.Equal(expected, sut, new TranslatorEqualityComparer());
        }
    }
}
