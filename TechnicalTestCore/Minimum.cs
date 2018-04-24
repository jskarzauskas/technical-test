using System;

namespace TechnicalTestCore
{
    using System.Collections.Generic;

    internal class Minimum
    {
        public static int MinimumElementIn(List<int> intlist)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass

            if (intlist == null || intlist.Count.Equals(0))
            {
                throw new ArgumentException("intlist is null or empty !");
            }

            //1st way using built-in methods

            /* 
               return intlist.Min();
            */

            //2nd way
            int min = intlist[0];
            for (int i = 1; i < intlist.Count; i++)
            {
                if (min > intlist[i])
                {
                    min = intlist[i];
                }
            }

            return min;

        }
    }
}
