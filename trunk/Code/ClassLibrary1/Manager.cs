using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Manager
    {
        private HashSet<Personnage> listePresos;
        public void AjouterPerso(Personnage perso)
        {
            if (listePresos.Contains(perso))
            {
                return;
            }
            else
            {
                listePresos.Add(perso);
            }
        }

        public void AjouterImgPerso(Image img, Personnage perso)
        {
            if (listePresos.Contains(perso))
            {
                
            }
            else
            {
                return;
            }
        }
    }
}
