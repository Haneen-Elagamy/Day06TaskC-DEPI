using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06C_Task
{
    internal class TypeB
    {
        
        void printB()
        {
            TypeA obj = new TypeA(10, 20, 30);

            //obj.F inaccessible here-->private
            Console.WriteLine(obj.G);
            Console.WriteLine(obj.H);
        }
    }
}
