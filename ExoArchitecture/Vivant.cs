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
        private void Mort()
        {
            _vivant = false;
        }
        public void checkISmort()
        {
            Mort();
        }
    }
}
