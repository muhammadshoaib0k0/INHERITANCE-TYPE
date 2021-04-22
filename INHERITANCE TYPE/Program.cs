using System;

namespace INHERITANCE_TYPE
{    
    /*
    MULTIPLE INHERITANCE CAN NOT  ACHIEVED 
    DIAMOND PROBLEM.
    C# SUPPORT MULTIPLE INTERFACE INHERITANCE
     */
    class Program
    {
        public class A
        {
            public void display()
            {
                Console.WriteLine("learn multilevel inheritance");
            }
        }
        public class B : A
        {
        }
        public class C : B
        {
        }

//    hierarchical inheritance
public class A2
        {
            public void print()
            {
                Console.WriteLine("it is HIERARCHICAL INHERITANCE");
            }
        }
public class B1 : A2 { }
        public class C1 : A2 { }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            A obj = new A();
            obj.display();
            B obj1 = new B ();
            obj1.display();
            C obj3 = new C();
            obj3.display();
            Console.WriteLine("");
            ////////////////////////////////////////////done multiple inheritance////////////////////
            
            
           // NOW ITS FOR HEIRARCHICAL INHERITANCE         ////
            
            C1 obj_b = new C1();

            obj_b.print();













        }
    }
}
