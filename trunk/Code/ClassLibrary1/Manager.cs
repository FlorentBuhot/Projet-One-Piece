using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Manager
    {
        private HashSet<Personnage> listePreso;
        private HashSet<Arc> listeArc;
        public void AjouterPerso(Personnage perso)
        {
            if (listePreso.Contains(perso))
            {
                return;
            }
            else
            {
                listePreso.Add(perso);
            }
        }

        public void AjouterImgPerso(Image img, Personnage perso)
        {
            foreach(Personnage test in listePreso)
            {
                if (test.Equals(perso))
                {
                    test.SourceImgPerso.AddLast(img);
                }
            }
        }
        public void AjouterInfoPerso(Personnage perso, string info)
        {
            perso.Info += info;
        }

        public Personnage RechercherPerso(string nomPerso)
        {
            foreach(Personnage test in listePreso)
            {
                if (test.Nom.Equals(nomPerso))
                {
                    return test;
                }
            }
            return null;
        }

        public void AjouterImgArc(Image img, Arc arc)
        {
            foreach (Arc test in listeArc)
            {
                if (test.Equals(arc))
                {
                    test.SourceImgArc.AddLast(img);
                }
            }
        }

        public void AjouterInfoArc(Arc arc, string info)
        {
            arc.Info += info;
        }
        public Arc RechercherArc(string nomArc)
        {
            foreach (Arc test in listeArc)
            {
                if (test.Nom.Equals(nomArc))
                {
                    return test;
                }
            }
            return null;
        }
    }
}
