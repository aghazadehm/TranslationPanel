using Domain.Entities;

namespace Translation.Application
{
    public class PhraseTypeBuilder
    {
        private int _id;
        private string _title;
        private string _name;

        public PhraseTypeBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
        public PhraseTypeBuilder WithTitle(string title)
        {
            _title = title;
            return this;
        }
        public PhraseTypeBuilder WithId(int id)
        {
            _id = id;
            return this;
        }
        public PhraseType Build()
        {
            return new PhraseType(_id, _name,_title);
        }
    }
}