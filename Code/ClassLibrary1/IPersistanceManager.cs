using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public interface IPersistanceManager
    {
        (IEnumerable<Personnage> personnages, IEnumerable<Arc> arcs, IEnumerable<Haki> hakis) ChargeDonnees();

        void SauvegardeDonnees(IEnumerable<Personnage> personnages, IEnumerable<Arc> arcs, IEnumerable<Haki> hakis);
    }
}
