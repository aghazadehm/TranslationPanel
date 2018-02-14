using System;
using System.Collections.Generic;

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
        private List<Translation> _translations;

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
        public TranslateBuilder WithTranslations(List<Translation> translations)
        {
            _translations = translations;
            return this;
        }
        public Translator Build()
        {
            return new Translator(_id, _phrase, _translations);
        }
    }
}