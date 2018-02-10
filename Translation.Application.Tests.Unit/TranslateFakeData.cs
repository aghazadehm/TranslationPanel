using Domain.Entities;
using System;

namespace Translation.Application.Tests.Unit
{
    internal class TranslateFakeData
    {
        internal static CreateTranslateDTO GetFakedCreatedTranslate()
        {
            return new CreateTranslateDTO
            {
                PhraseId = 1,
                PhraseType = "commodity",
                LanguageAbbr = "En",
                Translation = "Wheat"
            };
        }

        internal static ModifyTranslateDTO GetFakedUpdatedTranslate()
        {
            return new ModifyTranslateDTO
            {
                Id = 1,
                PhraseId = 1,
                PhraseType = "commodity",
                LanguageAbbr = "En",
                Translation = "Wheat"
            };
        }
    }
}