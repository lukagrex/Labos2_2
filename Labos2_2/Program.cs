using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labos2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation qe = new QuadraticEquation(1, 2, -3);
            //Console.WriteLine(qe.A);
            //qe.A = 5;
            var roots1 = qe.Roots;
            Console.WriteLine(roots1[0]);
            Console.WriteLine(roots1[1]);

            QuadraticEquation qe1 = new QuadraticEquation(-1, 2, -1);
            var roots2 = qe1.Roots;
            Console.WriteLine(roots2[0]);
            Console.WriteLine(roots2[1]);
            Console.ReadKey(false);
        }
    }
}
