using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Translation.Application
{
    public class TranslationService
    {
        private readonly ITranslationRepository _repository;

        public TranslationService(ITranslationRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Translator> GetPhrases(ToTranslateRequest request)
        {
            return _repository.GetTranslators(request.PhraseType.Name, request.Language.Abbrevation);
        }

        public void CreateTranslate(CreateTranslateDTO dto)
        {
            var phraseType = new PhraseTypeBuilder().WithName(dto.PhraseType).Build(); //GetPhraseTypeByName(dto.PhraseType);
            var phrase = new PhraseBuilder().WithId(dto.PhraseId).WithPhraseType(phraseType).Build(); //GetPhraseById(dto.PhraseId, phraseType);
            var language = new LanguageBuilder().WithAbbrevation(dto.LanguageAbbr).Build(); //new Language(dto.LanguageId, dto.LanguageName);
            var translate = new Translator(0, phrase, language, dto.Translation);
            _repository.Save(translate);
        }

        public IEnumerable<PhraseType> GetPhraseTypes()
        {
            return _repository.GetPhraseTypes();
        }

        private Phrase GetPhraseById(int phraseId, PhraseType phraseType)
        {
            return _repository.GetPhraseById(phraseId, phraseType);
        }

        private PhraseType GetPhraseTypeByName(string phraseType)
        {
            return _repository.GetPhraseTypeByName(phraseType);
        }

        private Language GetLanguageById(int languageId)
        {
            Language language = _repository.GetLanguageById(languageId);
            return language;
        }

        private PhraseType GetPhraseTypeById(int phraseTypeId)
        {
            PhraseType phraseType = _repository.GetPhraseTypeById(phraseTypeId);
            return phraseType;
        }

        public void ModifyTranslate(ModifyTranslateDTO dto)
        {
            var translator = _repository.GetById(dto.Id);
            var language = new LanguageBuilder().WithAbbrevation(dto.LanguageAbbr).Build();
            var phraseType = new PhraseTypeBuilder().WithName(dto.PhraseType).Build();
            var phrase = new PhraseBuilder().WithId(dto.PhraseId).WithPhraseType(phraseType).Build();
            translator.Update(phrase, language, dto.Translation);
        }
    }
}
