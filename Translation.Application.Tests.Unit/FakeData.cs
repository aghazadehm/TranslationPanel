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
        private List<PhraseType> _phraseTypes;
        public FakeData()
        {
            _phraseTypes = new List<PhraseType>();
            _phraseTypes.Add(new PhraseType("commodity"));
            _phraseTypes.Add(new PhraseType("broker"));
            _phraseTypes.Add(new PhraseType("commodity main group"));
            _phraseTypes.Add(new PhraseType("commodity middle group"));
            _phraseTypes.Add(new PhraseType("commodity sub group"));
            _phraseTypes.Add(new PhraseType("currency"));
            _phraseTypes.Add(new PhraseType("measurement unit"));
        }
        public FakeData(PhraseType infoType, Language language):base()
        {
            _infoType = infoType;
            _language = language;
            _translates = new List<Translator>();
            _translates.Add(new Translator(1, new Phrase(1, "قیر", new PhraseType("commodity")), new Language("Arabic","Ar"),""));
            _translates.Add(new Translator(2, new Phrase(2, "گندم", new PhraseType("commodity")), new Language("Arabic", "Ar"), ""));
            _translates.Add(new Translator(3, new Phrase(3, "طلا", new PhraseType("commodity")), new Language("Arabic", "Ar"), ""));
            _translates.Add(new Translator(4, new Phrase(4, "باقر", new PhraseType("commodity")), new Language("English", "En"), ""));
            _translates.Add(new Translator(5, new Phrase(5, "تیم ملی", new PhraseType("commodity")), new Language("English", "En"), ""));
            _translates.Add(new Translator(6, new Phrase(6, "تیرآهن", new PhraseType("commodity")), new Language("Arabic", "Ar"), ""));
            _translates.Add(new Translator(7, new Phrase(7, "شیر", new PhraseType("commodity")), new Language("Arabic", "Ar"), ""));
            _translates.Add(new Translator(8, new Phrase(8, "مرغ", new PhraseType("commodity")), new Language("English", "En"), ""));
            _translates.Add(new Translator(9, new Phrase(9, "جون", new PhraseType("commodity")), new Language("English", "En"), ""));
            _translates.Add(new Translator(10, new Phrase(10, "آدمیزاد", new PhraseType("commodity")), new Language("Arabic", "Ar"), ""));
            _translates.Add(new Translator(1, new Phrase(1, "قیر", new PhraseType("commodity")), new Language("English", "En"), ""));
            _translates.Add(new Translator(2, new Phrase(2, "گندم", new PhraseType("commodity")), new Language("English", "En"), ""));
        }

        public IEnumerable<Translator> GetPhrases()
        {
            return _translates.FindAll(x => x.Language.Abbrevation == _language.Abbrevation);
        }

        public IEnumerable<PhraseType> GetPhraseTypes()
        {
            return _phraseTypes;
        }
    }
}