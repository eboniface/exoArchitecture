using System;
using System.Collections.Generic;
using System.Text;

namespace ExoArchitecture
{
    class Personnage
    {
        private NiveauEtVivant _niveauEtVivant;
        private PointDeVie _pointDeVie;

        public Personnage()
        {
            _niveauEtVivant = new NiveauEtVivant();
            _pointDeVie = new PointDeVie();
        }
    }
}
