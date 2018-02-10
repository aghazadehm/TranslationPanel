using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.WebApp.Models
{
    public class TranslateViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public string Translation { get; set; }
    }
}
