using System;

namespace Exercise_8
{
    class Gun
        {
            private static int gunCount = 0;
            public static int bulletCount = 0;
            public int shotsFired = 0;

            public Gun()
            {
                gunCount++;
            }

            public void Shoot()
            {
                System.Console.WriteLine("BANG!");
                bulletCount++;
                shotsFired++;
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun1 = new Gun();
            Gun gun2 = new Gun();
            Gun gun3 = new Gun();
            Gun gun4 = new Gun();

            gun1.Shoot();
            gun1.Shoot();
            gun2.Shoot();
            gun3.Shoot();
            gun4.Shoot();

            System.Console.Write(gun3.shotsFired);
            System.Console.WriteLine(" " + Gun.bulletCount);
        }
    }
}
