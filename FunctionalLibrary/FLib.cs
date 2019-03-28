using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalUp.FunctionalLibrary
{
    public static class FLib
    {
        public static T If<T>(bool condition, T valueIfTrue, T valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        //Note: syntax (of calling code) could be made more elegant with C#7.0 & value tuples
        //However, C# 7.0 also has pattern matching, so this capability is redundant.
        public static T Select<T>(T defaultReturn, params Tuple<bool,T>[] cases)
        {
            var matches = cases.Where(m => m.Item1 == true).Select(m => m.Item2);
            return matches.Count() > 0 ? matches.First() : defaultReturn;
        }

        public static T Select<T,U>(U inputValue, T defaultReturn, params Tuple<U, T>[] cases)
        {
            var matches = cases.Where(m => m.Item1.Equals(inputValue)).Select(m => m.Item2);
            return matches.Count() > 0 ? matches.First() : defaultReturn;
        }
    }
}
