using Domain.Entities;

namespace Translation.Application
{
    public class PhraseTypeBuilder
    {
        private string _name;

        public PhraseTypeBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public PhraseType Build()
        {
            return new PhraseType( _name);
        }
    }
}