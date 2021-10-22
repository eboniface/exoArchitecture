using System;
using System.Collections.Generic;
using System.Text;

namespace ExoArchitecture
{
    class PointDeVie
    {
        private int _value;
        private Vivant _vivant;

        public PointDeVie()
        {
            _value = 1000;
        }
        public void RecoisAttaque(int degat)
        {
            _value = _value - degat;
        }
        public bool check(int degat)
        {
            if (_value - degat <= 0)
            {
                return false;
            }
            return true;
        }
        public void Mort()
        {
            _value = 0;
            _vivant.Mort();
        }
        public void checkVie(int soin)
        {
            if(_value+soin > 1000)
            {
                _value = 1000;
            }
            if(_value+soin< 1000)
            {
                _value = _value + soin;
            }
        }
    }
}
