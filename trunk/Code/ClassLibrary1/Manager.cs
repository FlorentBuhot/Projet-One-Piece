using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Manager
    {
        public HashSet<Personnage> ListePreso { get; set; }
        public HashSet<Arc> ListeArc { get; set; }
        public Manager()
        {
            ListePreso = new HashSet<Personnage>();
            ListeArc = new HashSet<Arc>();
        }
        public void AjouterPerso(Personnage perso)
        {
            if (ListePreso.Contains(perso))
            {
                return;
            }
            else
            {
                ListePreso.Add(perso);
            }
        }

        public void AjouterImgPerso(Image img, Personnage perso)
        {
            foreach(Personnage test in ListePreso)
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
            foreach(Personnage test in ListePreso)
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
            foreach (Arc test in ListeArc)
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
            foreach (Arc test in ListeArc)
            {
                if (test.Nom.Equals(nomArc))
                {
                    return test;
                }
            }
            return null;
        }

        public int ArcSuivant(Arc arcActu)
        {
            return arcActu.GetHashCode() + 1;
        }

        public int ArcPrécédent(Arc arcActu)
        {
            return arcActu.GetHashCode() - 1;
        }
    }
}
