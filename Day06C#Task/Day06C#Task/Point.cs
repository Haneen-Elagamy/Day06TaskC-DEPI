using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06C_Task
{
    internal struct Point
    {
        public int X;
        public int Y;
        
        //default Constructor
        public Point()
        {
            //X = default;
            //Y = default;
        }

        //parameterized constructor
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return $"first coor is {X}, second coor is {Y}";
        }

        /*
         * Question: Why can't a struct inherit from another struct or class in C#?

      Structs in C# cannot inherit from another struct or class because structs are **value types**, and the nature of
        value types conflicts with the principles of inheritance.

       ### Key Reasons:
       1. **Memory and Performance Efficiency**:  
       Structs are designed to be lightweight and stored on the stack rather than the heap. Inheritance introduces overhead 
       due to features like method lookups and dynamic memory allocation, which would negate the performance benefits of structs.

       2. **Copy-by-Value Behavior**:  
        When you assign one struct to another, the entire value is copied. If inheritance were allowed, copying a derived 
        struct would require copying not just its own fields but also the fields and methods of its base type, complicating the simple copy-by-value nature of structs.

       3. **No Polymorphism**:  
       Structs do not support polymorphism, a fundamental feature of inheritance. Allowing inheritance for structs would 
        create unnecessary complexity without providing the benefits typically associated with polymorphism.

       4. **Intended Purpose**:  
      Structs are meant to represent simple, self-contained pieces of data. They are not designed for scenarios requiring 
      hierarchical relationships or shared behavior, which are best handled by classes.
      */
    }
}
