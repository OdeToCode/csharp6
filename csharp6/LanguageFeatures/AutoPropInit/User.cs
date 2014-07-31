using System;
using System.Diagnostics;

namespace LanguageFeatures
{
    public class User
    { 
        // auto property initializer
        public Guid Id { get; } = Guid.NewGuid();
    }

}
