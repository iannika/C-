using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            B c = new B(4, 83, 65);
            
            while (c.a < c.b && c.d < c.b){
            Console.WriteLine(c.c); break;
}
    }
        }
    }

public class A {
    public decimal a;
    public decimal b;

    public A (decimal a, decimal b) {
        this.a = a;
        this.b = b;
    }

    public decimal c{

        get { return a-b; }
        set { c += value; }
    }

}

public class B:A{
    public decimal d;

    public decimal c2{
        get{return a + b + d;}
        set{c2 = value;}
    }

    public B(decimal a, decimal b, decimal d) : base(a,b){
        this.d = d;
       
    } 

   
}
