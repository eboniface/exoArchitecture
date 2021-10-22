using System;
using System.Collections.Generic;
using System.Text;

namespace ExoArchitecture
{
    class Personnage
    {
        private Niveau _niveau;
        private PointDeVieEtVivant _pointDeVieEtVivant;

        public Personnage()
        {
            _niveau = new Niveau();
            _pointDeVieEtVivant = new PointDeVieEtVivant();
        }

        public void Attaque(Personnage perso)
        {
            perso.ReçoisAttaque();
        }
        public void Soin(Personnage perso)
        {
            perso.ReçoiSoin();
        }
        public void ReçoisAttaque()
        {
            _pointDeVieEtVivant.PrendDesDegat();
        }
        public void ReçoiSoin()
        {
            _pointDeVieEtVivant.ReçoisDuSoin();
        }
        public int test()
        {
            return _pointDeVieEtVivant.test();
        }
    }
}
