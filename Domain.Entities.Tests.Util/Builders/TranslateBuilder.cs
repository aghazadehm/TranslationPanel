using System;

namespace Domain.Entities.Tests.Util.Builders
{
    public class TranslateBuilder
    {
        public TranslateBuilder()
        {
            _id = 0;
        }
        private int _id;
        private Phrase _phrase;
        private Language _language;
        private string _translation;

        public TranslateBuilder WithId(int id)
        {
            _id = id;
            return this; 
        }
        public TranslateBuilder WithPhrase(Phrase phrase)
        {
            _phrase = phrase;
            return this;
        }
        public TranslateBuilder WithLanguage(Language language)
        {
            _language = language;
            return this;
        }
        public TranslateBuilder WithTranslation(string translation)
        {
            _translation = translation;
            return this;
        }
        public Translator Build()
        {
            return new Translator(_id, _phrase, _language, _translation);
        }
    }
}