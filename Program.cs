using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var c = new A(4, 83);
            Console.WriteLine(c.sum_a());
            Console.WriteLine(c.minus_a());
            var d = new B(12, 0, 4);
            Console.WriteLine(d.c2());
        }
    }
}

public class A {
    private decimal a;
    private decimal b;

    public A (decimal a, decimal b) {
        this.a = a;
        this.b = b;
    }
    public decimal sum_a() {
        return this.a+=this.b;
    }
    public decimal minus_a() {
        return this.a - this.b;    
    }

}

public class B:A {
    private decimal d;
    
    public B (decimal a, decimal b, decimal d) : base(a, b){
        this.d = d;
    }

    public decimal c2(){
        while ((this.d) < 10){
            return this.d++;
        }
    }

}
