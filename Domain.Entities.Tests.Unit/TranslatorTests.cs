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
            var lang = new Language("English", "En");
            var type = new PhraseType("commodity");
            var phrase = new Phrase(1, "گندم", type);
            int id = 1;
            string trans = "Wheat";
            Translator sut = _sutBuilder.WithId(id).WithPhrase(phrase).WithLanguage(lang).WithTranslation(trans).Build();
            Translator expected = new Translator(id, phrase, lang, trans);

            Assert.Equal(expected, sut, new TranslatorEqualityComparer());
        }
    }
}
