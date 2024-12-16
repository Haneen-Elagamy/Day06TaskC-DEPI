using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06C_Task
{
    internal struct Point1
    {
        public int X;
        public int Y;

        // A parameterized constructor initializing X to specific value and Y to 0.
        public Point1(int _X)
        {
            X = _X;
            Y = 0;
        }

        // A parameterized constructor to set X and Y to specific values.

        public Point1(int _X,int _Y)
        {
            X= _X;
            Y= _Y;
        }

        public override string ToString()
        {
            return $"first coor is {X}, second coor is {Y}";
        }

        #region Q_Ctor  
        //Question: what is constructors in structs?
        /*In C#, a constructor in a struct is a special method used to initialize its fields when 
         * an instance of the struct is created. Struct constructors are important because they 
         * ensure proper initialization of fields, especially since structs are value types and do not have a default parameterless constructor (prior to C# 10).

         Key Points about Struct Constructors:
         1-Initialization: A constructor in a struct allows you to initialize fields with specific
         values when creating a new instance.

        2- No Default Constructor: Unlike classes, structs cannot have parameterless constructors 
        (prior to C# 10), as they are inherently designed to avoid unnecessary initialization.

        3-Field Assignment: All fields of the struct must be explicitly assigned a value inside the 
        constructor since structs do not allow uninitialized fields.

        4-Control and Consistency: Using a constructor ensures that the struct’s fields are 
        initialized in a controlled and consistent manner, reducing potential bugs.*/
        #endregion


        #region Q_Override_Tostring
        //Question: How does overriding methods like ToString() improve code readability?

        /*1-Simplifies Output: By overriding ToString(), you can control the string representation
         * of an object, making it more intuitive and easier to understand when you print or log the
         * object’s state. This eliminates the need for custom formatting logic every time the object is output.

         2-Improves Debugging: When you override ToString(), it ensures that the object's state is 
        displayed in a meaningful way. This is particularly helpful during debugging, as it provides 
        immediate insight into the object’s values without having to manually inspect each field.

        3-Consistency: Overriding ToString() provides a standardized way of representing your object
        across the application. Instead of having different methods or logic to display the object’s properties,
        you can call ToString() to consistently represent the object’s information.

        4-Enhanced Readability in Code: By using ToString(), you make the code cleaner and more 
        concise. Instead of manually constructing a string each time you want to output the object's
        properties, you can rely on the overridden ToString() method to handle it in a structured way.*/
        #endregion
    }
}
