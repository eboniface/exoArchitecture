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

            perso1.Attaque(perso2);
            perso1.Attaque(perso2);
            perso1.Attaque(perso2);
            perso1.Attaque(perso2);
            perso1.Attaque(perso2);
            perso1.Soin(perso2);
            perso1.Attaque(perso2);
            perso1.Attaque(perso2);
            perso1.Attaque(perso2);
            perso1.Attaque(perso2);
            perso1.Attaque(perso2);
            perso1.Attaque(perso2);
        }
    }
}
