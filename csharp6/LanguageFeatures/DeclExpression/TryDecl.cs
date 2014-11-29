using System.Collections.Generic;
using System.Linq;


// THESE FEATURES REMOVED
namespace LanguageFeatures.DeclExpression
{

    // TODO: Future
    //public class UserManager(User user)
    //{
    //    public Address Address { get; } = var homeAddress = user.HomeAddress;
    //    public string State { get; } = homeAddress.City;
    //}


public class TryDecl
    {
        //public string FindCity(User user)
        //{
        //    if ((var address = user.HomeAddress) != null)
        //    {
        //        // work with address ...

        //        return address.City;
        //    }

        //    // address now out of scope

        //    return "";
        //}

        //public int WithParsing(string input)
        //{
        //    if (int.TryParse(input, out var result))
        //    {
        //        return result;
        //    }
        //    return 0; // result is not out of scope
        //}

        //public int WithParsing2(string input, int @default = 0)
        //{
        //    return int.TryParse(input, out var result) ? result : @default;
        //}

        //public int TestLength(object o)
        //{
        //    if((var s = o as string) != null)
        //    {
        //        return s.Length;
        //    }
        //    return 0;
        //}

        //public int WithCallingOutMethod()
        //{
        //    OutMethod(out var x, out var y);
        //    return x + y;
        //}

        //void OutMethod(out int x, out int y)
        //{
        //    x = 3;
        //    y = 5;
        //}

        //public int WithLinq(IEnumerable<int> numbers)
        //{            
        //    int result = 0;
        //    //var odd = numbers.Where(n => n % 2 == 1).ToList();
        //    foreach (var n in var odd = numbers.Where(n => n % 2 == 1).ToList())
        //    { 
        //        result += n + odd.Count();
        //    }
        //    return result;
        //}
    }
}
