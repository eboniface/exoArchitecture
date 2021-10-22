using System;
using System.Collections.Generic;
using System.Text;

namespace ExoArchitecture
{
    class PointDeVieEtVivant
    {
        private PointDeVie _pointDeVie;
        private Vivant _vivant;

        public PointDeVieEtVivant()
        {
            _pointDeVie = new PointDeVie();
            _vivant = new Vivant();
        }
        public void PrendDesDegat()
        {
            _pointDeVie.check();
            _pointDeVie.isMort(_vivant);
        }
        public void ReçoisDuSoin()
        {
            _pointDeVie.checkVie();
        }
    }
}
