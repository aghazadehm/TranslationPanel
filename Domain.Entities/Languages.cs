using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Languages
    {
        public IEnumerable<Language> Items { get { return _languages; } }
        private Language[] _languages = new Language[]
        {
            new Language(0, "پارسی",  "پارسی", "FA"),
            new Language(1, "انگلیسی",  "English", "EN"),
            new Language(2, "عربی",  "العربیه", "AR"),
        };
        public Language this[int index]
        {
            get
            {
                return _languages[index];
            }

            set
            {
                _languages[index] = value;
            }
        }
    }
}
