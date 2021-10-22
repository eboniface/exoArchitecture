using System;
using System.Collections.Generic;
using System.Text;

namespace ExoArchitecture
{
    class Vivant
    {
        private bool _vivant;

        public Vivant()
        {
            _vivant = true;
        }
        public void Mort()
        {
            _vivant = false;
        }
    }
}
