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

    }
}
