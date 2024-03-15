using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_1
{
    class A
    {
        protected decimal a;
        protected decimal b;
        
        public A()
        {

        }

        public A(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
        }

        public decimal[] Valuses
        {
            get {
                return new decimal[] { a, b };
            }
        }

    }


    class B : A
    {
        private decimal d;
        private decimal c2 = 0;

        public B(decimal a, decimal b, decimal d, decimal c2): base(a, b)
        {
            this.d = d;
            this.c2 = c2;
            while (d> c2)
            {
                c2++;
                
            }
        }

        public B(decimal a, decimal b, decimal d) : base(a, b)
        {
            this.d = d;
        }

        public decimal D
        {
            get { return d; }
        }

        public decimal C2
        {
            get { return c2; }
        }
    }

    class Program
    {
        static void Main()
        {
            A objA = new A(1, 2);
            Console.Write("Значение свойства для A: ");
            decimal[] val = objA.Valuses;
            foreach (decimal num in val)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            B objB1 = new B(3, 4, 4, 5); 
            Console.WriteLine("Значение свойства для B (конструктор 1): " + objB1.C2); 

            B objB2 = new B(6, 7, 8); 
            Console.WriteLine("Значение свойства для B (конструктор 2): " + objB2.C2);

            Console.ReadLine();
        }
    }
}
