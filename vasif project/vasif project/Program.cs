using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;

namespace vasif_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            char[] alpha = "ABCÇDEƏFGĞHXIİJKQLMNOÖPRSŞTUÜVYZ".ToCharArray();
            char[] alpha1 = "ÖIUPRAĞŞSHJÜTBXİCƏZVOYGNLDMFKÇEQ".ToCharArray();
            bool test = true;
            
            while (test)
            {
                List<int> list = new List<int>();
                Console.WriteLine("\n\n\n\n\n\n\nSozu daxil edin");
                string name = Console.ReadLine();
                foreach (char n in name)
                {
                    int count = 0;
                    foreach (char item in alpha1)
                    {
                        count++;
                        if (char.ToLower(n) == char.ToLower(item))
                        {
                            list.Add(count);
                            break;
                        }
                    }
                }
                foreach (int item in list)
                {
                    Console.Write($"{alpha[item - 1]}") ;
                }
            }
        }
    }
}
