using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfstprojectt
{
    class MaxUniqueSequnceFinder
    {
        char[] massiv;
        public void enter(string[] args) //enter the string
        {
            Console.Write("enter the string: ");
           
            string str = null;
            if (args.Length != 0)
                foreach (string s in args)
                {
                    str = s;
                    massiv = str.ToCharArray();
                }
             //
           Console.Write(massiv);
            Console.ReadLine();
        }

        public void check() //counting different values
        {
            int allsymbols = 0;
            int double_symbol = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                allsymbols++; // string length
                for (int j = i + 1; j < massiv.Length; j++)
                {
                    if (massiv[j] == massiv[i])
                    {
                        double_symbol++; //repeated characters
                        break;
                    }
                }
            }
            int unicSymbols = allsymbols - double_symbol;
            Console.Write("count of unique symbols - " + unicSymbols);
            Console.ReadLine();
        }
    }
}
