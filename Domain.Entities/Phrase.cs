using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Phrase
    {
        public Phrase(int id, string text, PhraseType phraseType)
        {
            Id = id;
            Text = text;
            PhraseType = phraseType;
        }
        public int Id { get; set; }
        public string Text { get; set; }
        public PhraseType PhraseType { get; set; }
    }
}
