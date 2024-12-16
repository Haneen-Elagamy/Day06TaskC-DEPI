using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Day06C_Task
{
    /*Create a class TypeA with attributes F (private), G (internal), and H (public).
o Write a program to access these attributes from different parts of the project.*/
    public class TypeA
    {
        private int F; //Accessible only inside the TypeA class.
        internal int G; //Accessible only within the same assembly/project.
        public int H; //Accessible from anywhere, including other assemblies.

        //parameterized Constructor
        public TypeA(int F,int G,int H)
        {
            this.F = F;
            this.G = G;
            this.H = H;
        }


        public void printA()
        {
            Console.WriteLine($"private F : {F}"); //access private field F in the same scope only
            Console.WriteLine($"Internal G : {G}");
            Console.WriteLine($"public H : {H}");
        }
       // Q_2
        //Question: How do access modifiers impact the scope and visibility of a class member?
        /*Access modifiers in C# define the scope and visibility of class members (fields, methods, properties, etc.), 
         * determining where they can be accessed within the program.
         * 
         * private: Accessible only within the declaring class.
          protected: Accessible within the declaring class and its derived classes.
          internal: Accessible within the same assembly/project.
          protected internal: Accessible within the same assembly or derived classes.
          private protected: Accessible within the declaring class and its derived classes in the same assembly.
          public: Accessible from anywhere, including other assemblies.
         */

    }
}
