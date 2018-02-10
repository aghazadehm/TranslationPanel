using Domain.Entities;
using Domain.Entities.Tests.Util;
using Domain.Entities.Tests.Util.Builders;
using Domain.Entities.Tests.Util.EqualityComparers;
using Domain.Entities.Tests.Util.NSubstituteExtentions;
using Domain.Interfaces;
using NSubstitute;
using System;
using Xunit;

namespace Translation.Application.Tests.Unit
{
    public class TranslationServiceTests
    {
        private readonly ToTranslateRequestBuilder _sutBuilder;
        public TranslationServiceTests()
        {
            _sutBuilder = new ToTranslateRequestBuilder();
        }

        [Fact]
        public void GetPhraseTypes_should_load_phrase_types()
        {
            var repository = Substitute.For<ITranslationRepository>();
            var sut = new TranslationService(repository);
            var fake = new FakeData();
            var phraseTypes = sut.GetPhraseTypes().Returns(fake.GetPhraseTypes());
            Assert.NotEmpty(sut.GetPhraseTypes());
        }

        [Theory]
        [InlineData("Talar", "Ar")]
        [InlineData("Commodity", "En")]
        public void GetToTranslations_sholud_load_phrases(string typeName, string languageAbbr)
        {
            var builder = new ToTranslateRequestBuilder();
            var type = new PhraseTypeBuilder().WithName(typeName).Build();
            var lang = new LanguageBuilder().WithAbbrevation(languageAbbr).Build(); ;
            ToTranslateRequest request = builder.WithPhraseType(type).WithLanguage(lang).Build();
            var repository = Substitute.For<ITranslationRepository>();

            var sut = new TranslationService(repository);
            var fake = new FakeData(request.PhraseType, request.Language);
            var translates = sut.GetPhrases(request).Returns(fake.GetPhrases());
            Assert.NotEmpty(sut.GetPhrases(request));
        }

        [Fact]
        public void CreateTranslate_should_save_translate()
        {
            var dto = TranslateFakeData.GetFakedCreatedTranslate();
            var repository = Substitute.For<ITranslationRepository>();
            var sut = new TranslationService(repository);

            sut.CreateTranslate(dto);

            var language = new LanguageBuilder().WithAbbrevation(dto.LanguageAbbr).Build();
            var phraseType = new PhraseTypeBuilder().WithName(dto.PhraseType).Build();
            var phrase = new PhraseBuilder().WithId(dto.PhraseId).WithPhraseType(phraseType).Build();
            var expectedTranslate = new TranslateBuilder()
                .WithLanguage(language)
                .WithPhrase(phrase)
                .WithTranslation(dto.Translation).Build();
            repository.Received(1).Save(ArgExt.Compare(expectedTranslate, new TranslatorEqualityComparer()));
        }



        [Fact]
        public void UpdateTranslate_should_update_translate()
        {
            var dto = TranslateFakeData.GetFakedUpdatedTranslate();
            var translate = Substitute.For<Translator>();
            var repository = Substitute.For<ITranslationRepository>();
            repository.GetById(dto.Id).Returns(translate);

            var sut = new TranslationService(repository);
            sut.ModifyTranslate(dto);

            var language = new LanguageBuilder().WithAbbrevation(dto.LanguageAbbr).Build();
            var phraseType = new PhraseTypeBuilder().WithName(dto.PhraseType).Build();
            var phrase = new PhraseBuilder().WithId(dto.PhraseId).WithPhraseType(phraseType).Build();
            var expectedTranslate = new TranslateBuilder()
                .WithId(dto.Id)
                .WithLanguage(language)
                .WithPhrase(phrase)
                .WithTranslation(dto.Translation).Build();
            translate.Received().Update(phrase, language, dto.Translation);
        }
    }
}
