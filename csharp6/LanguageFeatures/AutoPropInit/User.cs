using System;

namespace LanguageFeatures
{
    public class User
    {
        // auto property initializer
        public Guid Id { get; } = Guid.NewGuid();
        public Address HomeAddress { get; set; }

    }

    public class Address
    {
        public string City { get; set; }
    }

}
