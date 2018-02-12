using Domain.Entities.Tests.Util.Builders;
using Domain.Entities.Tests.Util.EqualityComparers;
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
            var lang = langs[1];
            var type = (new PhraseTypes())[7];
            var phrase = new Phrase(1, "گندم", type);
            int id = 1;
            string trans = "Wheat";
            Translator sut = _sutBuilder.WithId(id).WithPhrase(phrase).WithLanguage(lang).WithTranslation(trans).Build();
            Translator expected = new Translator(id, phrase, lang, trans);

            Assert.Equal(expected, sut, new TranslatorEqualityComparer());
        }
    }
}
