using Framework.Core;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Tests.Util.EqualityComparers
{
    public class TranslatorEqualityComparer : IEqualityComparer<Translator>
    {
        public bool Equals(Translator x, Translator y)
        {
            return new EqualsBuilder()
                //.Append(x.Language.Name, y.Language.Name)
                .Append(x.Language.EnglishAbbrevation, y.Language.EnglishAbbrevation)
                .Append(x.Phrase.Id, y.Phrase.Id)
                //.Append(x.Phrase.Text, y.Phrase.Text)
                .Append(x.Phrase.PhraseType.Name, y.Phrase.PhraseType.Name)
                .Append(x.Translation, y.Translation)
                .IsEquals();
        }

        public int GetHashCode(Translator obj)
        {
            return new HashCodeBuilder()
                .Append(obj.Id)
                //.Append(obj.Language.Name)
                .Append(obj.Language.EnglishAbbrevation)
                .Append(obj.Phrase.Id)
                //.Append(obj.Phrase.Text)
                .Append(obj.Phrase.PhraseType.Name)
                .Append(obj.Translation)
                .ToHashCode();
        }
    }
}
