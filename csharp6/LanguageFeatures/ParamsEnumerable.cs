using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        var result = Sum(45, 54, 14);
    }

    public int Sum(params IEnumerable<int> numbers)
    {
        return numbers.Sum(n => n);
    }

}