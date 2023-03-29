using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenzura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи дума, която да се цензурира: ");
            string[] word = Console.ReadLine().Split().ToArray();
            Console.WriteLine("Въведи изречение: ");
            string izr = Console.ReadLine();

            foreach (var item in word)
            {
                if (izr.Contains(item))
                {
                    izr = izr.Replace(item, new string('*', item.Length));
                }
            }
            Console.WriteLine(izr);
        }
    }
}
