using System;

namespace Exercise_2
{

    interface IExploadable<T>
    {
        void Explode(T radius);
    }

    class Bomb : IExploadable<double>
    {
        public void Explode(double radius)
        {
            System.Console.WriteLine("BOOM! ------ Blast radius was " + radius +" metres");
        }
    }

    class Program
    {
         
        static void Main(string[] args)
        {
            Bomb C4 = new Bomb();
            C4.Explode(12.5);
        }
    }
}
