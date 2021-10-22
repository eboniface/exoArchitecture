using System;

namespace ExoArchitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Personnage perso1 = new Personnage();
            Personnage perso2 = new Personnage();
            Console.WriteLine(perso2.test());
            perso1.Attaque(perso2);
            Console.WriteLine(perso2.test());
            perso1.Soin(perso2);
            Console.WriteLine(perso2.test());
        }
    }
}
