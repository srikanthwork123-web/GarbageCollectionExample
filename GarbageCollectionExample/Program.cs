using System;

namespace GarbageCollectionExample
{
    class Class1
    {
        ~Class1()
        {
            Console.WriteLine("Destructor");
        }
    }
    class Program
    {
        static void Main()
        {
            //create two objects
            Class1 c1 = new Class1();
            Class1 c2 = new Class1();
            Class1 c3 = new Class1();
            c1 = null;
            c2 = null;
//THIS IS ASLO ONE OF THE PROCESS DELETE ALL THE OBJECTS.
//BY USING PROGRAMATICALLY IF YOU WANT TO DELETE ALL THE OBJECTS WE CAN GO FOR THIS ONE.
//
            //delete all the objects
            GC.Collect();//Gc is a predefined class.
            
            Console.WriteLine("Garbage collection done.");

            Console.ReadKey();
        }
    }
}


/*output:
==================
Destructor
Garbage collection done.
Destructor
====================
*/