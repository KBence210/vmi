using System;
using System.Collections.Generic;
using System.Text;

namespace Szinezheto
{

    interface ISzinezheto
    {
        Pontok.Szinespont.Szinek Szin { get; set; }
        Pontok.Szinespont.Szinek AlapertelmezettSzin { get; }

        Pontok.Szinespont.Szinek GetSzin();
    }
}
