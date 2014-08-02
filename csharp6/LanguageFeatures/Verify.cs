using System;

namespace LanguageFeatures
{
    public static class Verify
    {
        public static T NotNull<T>(string name, T argument)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(name);
            }
            return argument;
        }
    }
}
