using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Language
    {
        public Language(int id,string origibName, string persianName, string englishAbbrevation)
        {
            Id = id;
            OriginName = origibName;
            PersianName = persianName;
            EnglishAbbrevation = englishAbbrevation;
        }

        public int Id { get; set; }
        public string OriginName { get; set; }
        public string PersianName { get; set; }
        public string EnglishAbbrevation { get; set; }
    }
}
