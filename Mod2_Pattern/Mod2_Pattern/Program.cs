using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                int j = 0;
                while (j < 8)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write('X');
                        }
                        else
                        {
                            Console.Write('O');
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write('O');
                        }
                        else
                        {
                            Console.Write('X');
                        }
                    }
                    j++;
                }
                Console.WriteLine();
            }
        }
    }
}
