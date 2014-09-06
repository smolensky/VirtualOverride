using System;

namespace FunWithVirtualOverride
{
    class Program
    {
        static void Main()
        {
            Alfa a = new Beta();
            Beta b = new Beta();

            Console.WriteLine(a.GetFirst());
            Console.WriteLine(a.GetSecond());
            Console.WriteLine(b.GetFirst());
            Console.WriteLine(b.GetSecond());
            
            Console.ReadKey();

        }
    }

    class Alfa
    {
        public bool GetFirst()
        {
            return true;
        }

        public virtual bool GetSecond()
        {
            return true;
        }
    }

    class Beta : Alfa
    {
        public new bool GetFirst()
        {
            return false;
        }

        public override bool GetSecond()
        {
            return false;
        }
    }
}
