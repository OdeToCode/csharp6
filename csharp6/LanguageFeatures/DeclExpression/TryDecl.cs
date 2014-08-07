using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures.DeclExpression
{
    public class TryDecl
    {
        public int WithParsing(string input)
        {            
            if (int.TryParse(input, out var result))
            {
                return result;
            }
            return 0;
        }

        // take odd numbers and sum each, but add count of total to each number


        public int WithLinq(IEnumerable<int> numbers)
        {            
            int result = 0;
            var odd = numbers.Where(n => n % 2 == 1).ToList();
            foreach (var n in odd)
            { 
                result += n + odd.Count();
            }
            return result;
        }
    }
}
