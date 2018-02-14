using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Tests.Util.Builders
{
    public class TranslatedPhraseBuilder
    {
        private int _id;
        private int _languageId;
        private int _phraseId;
        private int _phraseTypeId;
        private string _translate;

        public TranslatedPhraseBuilder()
        {
            _id = 0;
        }

        public TranslatedPhraseBuilder WithId(int id)
        {
            _id = id;
            return this;
        }
        public TranslatedPhraseBuilder WithLanguageId(int languageId)
        {
            _languageId = languageId;
            return this;
        }

        public TranslatedPhraseBuilder WithPhraseId(int phraseId)
        {
            _phraseId = phraseId;
            return this;
        }

        public TranslatedPhraseBuilder WithPhraseTypeId(int phraseTypeId)
        {
            _phraseTypeId = phraseTypeId;
            return this;
        }

        public TranslatedPhraseBuilder WithTranlate(string translate)
        {
            _translate = translate;
            return this;
        }

        public TranslatedPhrase Build()
        {
            return new TranslatedPhrase(_phraseId, _phraseTypeId, _languageId, _translate);
        }
    }
}
