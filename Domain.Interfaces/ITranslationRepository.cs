using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ITranslationRepository
    {
        IEnumerable<Translator> GetTranslators(string phraseType, string language);
        void Save(Translator translate);
        Translator GetById(int id);
        PhraseType GetPhraseTypeById(int languageId);
        Language GetLanguageById(int languageId);
        PhraseType GetPhraseTypeByName(string phraseType);
        Phrase GetPhraseById(int phraseId, PhraseType phraseType);
        IEnumerable<PhraseType> GetPhraseTypes();
    }
}