using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Translation.Application.Tests.Unit
{
    public class FakeData
    {
        private PhraseType _infoType;
        private Language _language;
        private List<Translator> _translates;
        public FakeData()
        {

        }
        public FakeData(PhraseType infoType, Language language):base()
        {
            _infoType = infoType;
            _language = language;
            var types = new PhraseTypes();
            var commodity = types[7];
            var langs = new Languages();
            var arabic = langs[2];
            var english = langs[1];
            _translates = new List<Translator>();
            _translates.Add(new Translator(1, new Phrase(1, "قیر", commodity), arabic, ""));
            _translates.Add(new Translator(2, new Phrase(2, "گندم", commodity), arabic, ""));
            _translates.Add(new Translator(3, new Phrase(3, "طلا", commodity), arabic, ""));
            _translates.Add(new Translator(4, new Phrase(4, "باقر", commodity), english, ""));
            _translates.Add(new Translator(5, new Phrase(5, "تیم ملی", commodity), english, ""));
            _translates.Add(new Translator(6, new Phrase(6, "تیرآهن", commodity), arabic, ""));
            _translates.Add(new Translator(7, new Phrase(7, "شیر", commodity), arabic, ""));
            _translates.Add(new Translator(8, new Phrase(8, "مرغ", commodity), english, ""));
            _translates.Add(new Translator(9, new Phrase(9, "جون", commodity), english, ""));
            _translates.Add(new Translator(10, new Phrase(10, "آدمیزاد", commodity), arabic, ""));
            _translates.Add(new Translator(1, new Phrase(1, "قیر", commodity), english, ""));
            _translates.Add(new Translator(2, new Phrase(2, "گندم", commodity), english, ""));
        }

        internal IEnumerable<Language> GetLanguages()
        {
            var langs = new Languages();
            return langs.Items;
        }

        public IEnumerable<Translator> GetPhrases()
        {
            return _translates.FindAll(x => x.Language.EnglishAbbrevation == _language.EnglishAbbrevation);
        }

        public IEnumerable<PhraseType> GetPhraseTypes()
        {
            var types = new PhraseTypes();
            return types.Items;
        }
    }
}