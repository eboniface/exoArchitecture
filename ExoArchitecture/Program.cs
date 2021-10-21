using System;

namespace ExoArchitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Personnage personnages = new Personnage();
            Personnage personnages2 = new Personnage();
            Console.WriteLine(personnages2.pointVie);
            personnages.Attaque(personnages2);
            Console.WriteLine(personnages2.pointVie);
            
        }
    }
}
