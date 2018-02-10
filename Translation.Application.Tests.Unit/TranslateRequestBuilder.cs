using System;
using Domain.Entities;

namespace Translation.Application.Tests.Unit
{
    public class ToTranslateRequestBuilder
    {
        private PhraseType _type;
        private Language _language;

        internal ToTranslateRequestBuilder WithPhraseType(PhraseType type)
        {
            _type = type;
            return this;
        }

        internal ToTranslateRequestBuilder WithLanguage(Language language)
        {
            _language = language;
            return this;
        }

        internal ToTranslateRequest Build()
        {
            return new ToTranslateRequest(_type, _language);
        }
    }
}