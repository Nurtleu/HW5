using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[] { 0, 12, 25, 54, 35, 8, 10, 5 };
            try
            {
                int index;
                Write("Enter the index:");
                Int32.TryParse(ReadLine(),out index);
                if(index>mas.Length)
                {
                    throw new IndexOutOfRangeException("The index is beyond it!");
                }

                else
                {
                    Write(mas[index]);
                }
            }
            catch(IndexOutOfRangeException Ex)
            {
                Write(Ex);
            }
            ReadLine();
        }
    }
}
