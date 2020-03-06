using System;
using System.Transactions;

namespace q23
{
    class A
    {
        protected int a;
        protected int b;

        public A()
        {
            this.a = 5;
            this.b = 5;
        }
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int c
        {
            get { return a + b; } 
        }
    }
    class B : A
    {
        private int d;
        public int c
        {
            get { return a + b + d; }
            set { a = value; b = value; d = value; }
        }
        public B(int a, int b, int d) : base(a, b)
        {
            this.d = d;
        }
        public B ()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A a1 = new A(1, 1);
            B a2 = new B();
            A a3 = new B(1, 2, 3); ;
            Console.WriteLine("c от А = {0}", a.c);
            Console.WriteLine("c от А(1,1) = {0}", a1.c);
            Console.WriteLine("c от B = {0}", a2.c);
            Console.WriteLine("c от B(1, 2, 3)) = {0}", a3.c);
            Console.ReadLine();
        }
    }
}