using System;

namespace PadawansTask12
{
    public static class StringExtension
    {
        public static bool AllCharactersAreUnique(string source)
        {
            if (source == null)
                throw new ArgumentNullException();
            //throw new NotImplementedException();
            for (int i = 0; i < source.Length - 1; i++)
            {
                for(int j = i + 1; j < source.Length; j++)
                {
                    if (source[i] == source[j])
                        return false;
                }
            }

            return true;
        }
    }
}