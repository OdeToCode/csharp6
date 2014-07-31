using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures.AutoPropInit
{
    public class Order { }

    public class Person
    {
        public  IList<Order> Orders { get; } = null;
    }

    public class Customer : Person
    {
        public new IList<Order> Orders { get; } = new List<Order>();
    }

    //public class Order { }

    //public class Person
    //{
    //    public Person()
    //    {
    //        Orders = null;
    //    }

    //    public virtual IList<Order> Orders { get; set; }
    //}

    //public class Customer : Person
    //{
    //    public Customer()
    //    {
    //        Orders = new List<Order>();
    //    }

    //    public override IList<Order> Orders { get; set; }
    //}
}
