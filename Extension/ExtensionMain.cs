using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public class ExtensionMain
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Console.WriteLine(c1.Muliply(2, 4));
            Console.WriteLine(c1.Add(44, 66));
        }
    }
}
