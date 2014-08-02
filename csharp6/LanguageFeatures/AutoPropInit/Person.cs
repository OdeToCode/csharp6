using System.Collections.Generic;

namespace LanguageFeatures.AutoPropInit
{
    public class Order { }

    public class Person
    {
        public virtual IList<Order> Orders { get; } = null;
    }

    public class Customer : Person
    {
        public override IList<Order> Orders { get; } = new List<Order>();
    }
}
