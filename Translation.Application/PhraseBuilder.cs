using Domain.Entities;
using System;

namespace Translation.Application
{
    public class PhraseBuilder
    {
        private int _id;
        private string _text;
        private PhraseType _phraseType;
        public PhraseBuilder()
        {
            _id = 0;
            _phraseType = new PhraseTypeBuilder().Build();
        }

        public PhraseBuilder WithId(int id)
        {
            _id = id;
            return this;
        }

        public PhraseBuilder WithText(string text)
        {
            _text = text;
            return this;
        }

        public PhraseBuilder WithPhraseType(PhraseType phraseType)
        {
            _phraseType = phraseType;
            return this;
        }

        public Phrase Build()
        {
            return new Phrase(_id, _text, _phraseType);
        }
    }
}