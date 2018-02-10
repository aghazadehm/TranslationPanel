using System;
using Domain.Entities;

namespace Translation.Application
{
    public class LanguageBuilder
    {
        private string _name;
        private string _abbrevation;
        public LanguageBuilder()
        {
        }

        public LanguageBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public LanguageBuilder WithAbbrevation(string abbrevation)
        {
            _abbrevation = abbrevation;
            return this;
        }

        public Language Build()
        {
            return new Language(_name, _abbrevation);
        }
    }
}