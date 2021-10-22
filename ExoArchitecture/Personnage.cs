using System;
using System.Collections.Generic;
using System.Text;

namespace ExoArchitecture
{
    public class Personnage : IPersonnage
    {
        private int _pointVie;
        private bool _vivant;
        private int _niveau;



        public Personnage()
        {
            _pointVie = 1000;
            _vivant = true;
            _niveau = 1;
        }
        public int pointVie => _pointVie;
        public bool vivant => _vivant;
        public int niveau => _niveau;

        int IPersonnage.pointVie { get => _pointVie; }



        private void setPV(int pv)
        {
            this._pointVie = pv;
        }

        public void Attaque(Personnage cible, int degat)
        {
            if(cible._pointVie - degat <= 0)
            {
                cible._vivant = false;
                cible._pointVie = 0;
            }else
            {
                cible._pointVie = cible._pointVie - degat;
            }
           
        }
        public void Soin(Personnage cible, int soin)
        {
            if (cible._pointVie + soin> 1000)
            {
                cible._pointVie = 1000;
            }
            else
            {
                cible._pointVie = cible._pointVie + soin
            }
            
        }
    }
}
