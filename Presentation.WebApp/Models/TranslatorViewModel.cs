using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.WebApp.Models
{
    public class TranslatorViewModel
    {
        public int Id { get; set; }
        public int PhraseId { get; set; }
        public string PhraseText { get; set; }
        public string PhraseTypeName { get; set; }
        public string LanguageAbbr { get; set; }
        public string Translation { get; set; }
    }
}
