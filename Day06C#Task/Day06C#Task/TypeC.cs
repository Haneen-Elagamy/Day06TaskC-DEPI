using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Day06C_Task
{
    internal class TypeC
    {
        public void printC()
        {
            TypeA obj = new TypeA(10,20,30);
            //obj.F inaccessible here >>private
            //obj.G inaccessible here >> internal >> limited to the original project(assembly)
            Console.WriteLine(obj.H);// Accessable >> public 
        }
    }
}
