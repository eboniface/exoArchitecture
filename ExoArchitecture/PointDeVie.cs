using System;
using System.Collections.Generic;
using System.Text;

namespace ExoArchitecture
{
    class PointDeVie
    {
        private int _Pv;
        public PointDeVie()
        {
            _Pv = 1000;
        }

        public void check()
        {
            if (_Pv - 100 <= 0)
            {
                _Pv = 0;
            }
            if (_Pv - 100 > 0)
            {
                _Pv = _Pv - 100;
            }
            Console.WriteLine("A perdue des point de vie ");
        }
        public void checkVie()
        {

            if (_Pv + 100 >= 1000)
            {
                _Pv = 1000;
            }
            if (_Pv + 100 < 1000)
            {
                _Pv = _Pv + 100;
            }
            Console.WriteLine("A gagné des point de vie ");
        }
        public void isMort(Vivant vivant)
        {
            if (_Pv ==0)
            {
                vivant.checkISmort();
            }
        }
    }
}
