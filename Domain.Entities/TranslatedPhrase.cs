namespace Domain.Entities
{
    public class TranslatedPhrase
    {
        public int Id { get; set; }
        public int PhraseId { get; set; }
        public int PhraseTypeId { get; set; }
        public int LanguageId { get; set; }
        public string Translate { get; set; }

        public TranslatedPhrase(int id, int phraseId, int phraseTypeId, int languageId, string translate)
        {
            Id = id;
            PhraseId = phraseId;
            PhraseTypeId = phraseTypeId;
            LanguageId = languageId;
            Translate = translate;
        }
    }
}