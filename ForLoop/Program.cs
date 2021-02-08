using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            n = 10;
            for(i=1;i<n;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+"");
                }
            }
        }
    }
}
