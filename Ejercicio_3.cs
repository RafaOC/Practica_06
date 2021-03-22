using System;

namespace Ejercicio_3
{
    /*3---> Crear tres clases ClaseA, ClaseB, ClaseC que ClaseB herede de ClaseA y ClaseC herede de ClaseB. 
    Definir un constructor a cada clase que muestre un mensaje. Luego definir un objeto de la clase ClaseC.*/
    public class A
    {
        public A()
        {
            Console.WriteLine("Constructor de la clase A");
            //Console.WriteLine(a);
        }
    }
    public class B : A
    {
        public B()
        {
            Console.WriteLine("\nConstructor de la clase B");
            //Console.WriteLine(b);
        }
    }
    public class C : B
    {
        public C()
        {
            Console.WriteLine("\nConstructor de la clase C");
            //Console.WriteLine(c);
        }
    }
    class Mostrar
    {
        static void Main(string[] args)
        {
            C obj1 = new C();
        } 
    }
}
