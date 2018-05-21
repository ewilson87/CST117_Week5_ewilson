//Corrected by Evan Wilson

using System;

namespace CST117_IC08_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //duplicate set A to perform union, since list is passed by reference once action is performed, A is changed. Perform union on _A
            Set _A = new Set();
            _A = A.DuplicateSet(A, _A);

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            //Performing union on Set A permenently changes set, changed union to be performed on clone of A, _A
            //Console.WriteLine("A union B: " + A.union(B));
            Console.WriteLine("A union B: " + _A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

            //prevents console from closing to user to view. Used this to see what was being written to console for debug instead of breakpoints
            Console.Read();
        }
    }
}
