using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Translator
    {
        protected Translator() { }
        public Translator(int id, Phrase phrase, Language language, string translation)
        {
            SetProperties(phrase, language, translation);
            Id = id;
        }

        private void SetProperties(Phrase phrase, Language language, string translation)
        {
            //validation and set
            Phrase = phrase;
            Language = language;
            Translation = translation;
        }
        public Phrase Phrase { get; set; }
        public Language Language { get; set; }
        public int Id { get; set; }
        public string Translation { get; set; }

        public void Update(Phrase phrase, Language language, string translation)
        {
            SetProperties(Phrase, Language, Translation);
        }
    }
}
