using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Translation.Application
{
    public class ToTranslateRequest
    {
        public ToTranslateRequest(PhraseType phraseType, Language language)
        {
            PhraseType = phraseType;
            Language = language;
        }

        public PhraseType PhraseType { get; set; }
        public Language Language { get; set; }
    }
}
