using System;
using Domain.Entities;

namespace Translation.Application
{
    public class LanguageBuilder
    {
        private int _id;
        private string _englishName;
        private string _englishAbbrevation;
        private string _originName;
        public LanguageBuilder()
        {
            _id = 0;
        }

        public LanguageBuilder WithName(string englishName)
        {
            _englishName = englishName;
            return this;
        }
        public LanguageBuilder WithOriginName(string originName)
        {
            _originName = originName;
            return this;
        }

        public LanguageBuilder WithAbbrevation(string englishAbbrevation)
        {
            _englishAbbrevation = englishAbbrevation;
            return this;
        }

        public Language Build()
        {
            return new Language(_id, _originName, _englishName, _englishAbbrevation);
        }
    }
}