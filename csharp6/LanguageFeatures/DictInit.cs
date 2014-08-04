using System;
using System.Collections.Generic;

class Program
{
    public static void Main() 
    {
        var lookup = new Dictionary<int, string> 
	{

             [2] = "two",
             [3] = "three"
        };

        foreach(var pair in lookup) 
        {
            Console.WriteLine("{0}:{1}", pair.Key, pair.Value);
        }

	var x = 3;
	Console.WriteLine(nameof(x));
    }
}