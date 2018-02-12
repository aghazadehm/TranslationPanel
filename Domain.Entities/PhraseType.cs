namespace Domain.Entities
{
    public class PhraseType
    {
        public PhraseType(int id, string name, string title)
        {
            Id = id;
            Name = name;
            Title = title;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}