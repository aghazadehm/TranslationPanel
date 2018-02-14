namespace Domain.Entities
{
    public class Translation
    {
        public Translation(int id, Language language, string translated)
        {
            Id = id;
            Language = language;
            Translated = translated;
        }
        public int Id { get; set; }
        public Language Language { get; set; }
        public string Translated { get; set; }
    }
}