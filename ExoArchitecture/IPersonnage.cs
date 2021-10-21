using System;
using System.Collections.Generic;
using System.Text;

namespace ExoArchitecture
{
    public interface IPersonnage
    {
        int pointVie { get; }
        bool vivant { get; }
        int niveau { get; }

    }
}
