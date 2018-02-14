using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Translator
    {
        protected Translator() { }
        public Translator(int id, Phrase phrase, List<Translation> translations)
        {
            SetProperties(phrase, translations);
            Id = id;
        }

        private void SetProperties(Phrase phrase, List<Translation> translations)
        {
            //validation and set
            Phrase = phrase;
            Translations = translations;
        }
        public Phrase Phrase { get; set; }
        public int Id { get; set; }
        //public string Translation { get; set; }
        public List<Translation> Translations { get; set; }

        public void Update(Phrase phrase, List<Translation> translations)
        {
            SetProperties(phrase, Translations);
        }
    }
}
