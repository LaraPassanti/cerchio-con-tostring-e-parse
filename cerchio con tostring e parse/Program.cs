using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerchio_con_tostring_e_parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio c = new Cerchio(5);
            Cerchio s = Cerchio.Parse(c.ToString());
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
