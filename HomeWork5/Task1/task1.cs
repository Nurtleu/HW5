using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task1
{
    class Program
    {          
        static void Main(string[] args)
        {
            WriteLine("Enter web property: ");
            string web = ReadLine();
            try
            {
                throw new Exception($"This resource does not exist!");
            }
            catch (Exception ex)
            {
                WriteLine(ex);
            }
            ReadLine();
        }
    }
}
