using NSubstitute;
using System.Collections.Generic;

namespace Domain.Entities.Tests.Util.NSubstituteExtentions
{
    public class ArgExt
    {
        public static T Compare<T>(T value, IEqualityComparer<T> comparer)
        {
            return Arg.Is<T>(x => comparer.Equals(value, x));
        }
    }
}