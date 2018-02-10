namespace Translation.Application
{
    public class CreateTranslateDTO
    {
        public string PhraseType { get; set; }
        public int PhraseId { get; set; }
        public string LanguageAbbr { get; set; }
        public string Translation { get; set; }
    }
}