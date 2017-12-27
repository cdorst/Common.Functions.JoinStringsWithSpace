using System.Collections.Generic;

namespace Common.Functions.JoinStringsWithSpace
{
    public static class StringsJoiner
    {
        private const string Space = " ";

        public static string JoinWithSpace(IEnumerable<string> strings)
            => string.Join(Space, strings);
    }
}
