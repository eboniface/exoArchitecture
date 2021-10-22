using System;
using System.Collections.Generic;
using System.Text;

namespace ExoArchitecture
{
    class Personnage
    {
        private Niveau _niveau;
        private PointDeVie _pointDeVie;

        public Personnage()
        {
            _niveau = new Niveau();
            _pointDeVie = new PointDeVie();
        }

        public void Attaque(int degat)
        {
            if (!_pointDeVie.check(degat))
            {
                _pointDeVie.Mort();
            }
            if (_pointDeVie.check(degat))
            {
                _pointDeVie.RecoisAttaque(degat);
            }
        }
        public void Soin(int soin)
        {
                _pointDeVie.checkVie(soin);
           
        }
    }
}
