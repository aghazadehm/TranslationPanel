using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.WebApp.Models
{
    public class TranslateGroupViewModel
    {
        public InfoTypeViewModel InfoType { get; set; }
        public List<TranslatorViewModel> Translations { get; set; }
    }
}
