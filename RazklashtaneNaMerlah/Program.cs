using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazklashtaneNaMerlah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи символен низ: ");
            string input = Console.ReadLine();
            Console.Write("Въведи шаблон за изтриване: ");
            string template = Console.ReadLine();
            string output = input;
            byte couter = 0;

            while (output.Contains(template))
            {
                couter++;
                int pos = output.IndexOf(template);
                int len = template.Length;
                output = output.Remove(pos, len);
            }

            if (couter>=2)
            {
                Console.WriteLine("Shaked it!");
            }
            Console.WriteLine("No shake!");

            Console.WriteLine($"Входящ низ: {input}");
            Console.WriteLine($"Изходящ низ: {output}");
        }
    }
}
