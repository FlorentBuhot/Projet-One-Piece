using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Manager
    {
        public HashSet<Personnage> ListePreso { get; private set; }
        public List<Arc> ListeArc { get; private set; }
        
        public Manager()
        {
            ListePreso = new HashSet<Personnage>();
            ListeArc = new List<Arc>();
            ListeArc.Add(new Arc(NomArc.Colonel_Morgan));
            ListeArc.Add(new Arc(NomArc.Baggy_le_Clown));
            ListeArc.Add(new Arc(NomArc.Capitaine_Kuro));
            ListeArc.Add(new Arc(NomArc.Baratie));
            ListeArc.Add(new Arc(NomArc.Arlong));
            ListeArc.Add(new Arc(NomArc.LogueTown));
            ListeArc.Add(new Arc(NomArc.Laboon));
            ListeArc.Add(new Arc(NomArc.Whiskey_Peak));
            ListeArc.Add(new Arc(NomArc.Little_Garden));
            ListeArc.Add(new Arc(NomArc.Royaume_de_Drum));
            ListeArc.Add(new Arc(NomArc.Alabasta));
            ListeArc.Add(new Arc(NomArc.Jaya));
            ListeArc.Add(new Arc(NomArc.Skypiea));
            ListeArc.Add(new Arc(NomArc.Davy_Back_Fight));
            ListeArc.Add(new Arc(NomArc.Water_Seven));
            ListeArc.Add(new Arc(NomArc.Enies_Lobby));
            ListeArc.Add(new Arc(NomArc.Post_Enies_Lobby));
            ListeArc.Add(new Arc(NomArc.Thriller_Bark));
            ListeArc.Add(new Arc(NomArc.Archipel_Sabaody));
            ListeArc.Add(new Arc(NomArc.Amazon_Lily));
            ListeArc.Add(new Arc(NomArc.Impel_Down));
            ListeArc.Add(new Arc(NomArc.Marineford));
            ListeArc.Add(new Arc(NomArc.Post_Enies_Lobby));
            ListeArc.Add(new Arc(NomArc.Retour_a_Sabaody));
            ListeArc.Add(new Arc(NomArc.Hommes_Poissons));
            ListeArc.Add(new Arc(NomArc.Punk_Hazard));
            ListeArc.Add(new Arc(NomArc.Dressrosa));
            ListeArc.Add(new Arc(NomArc.Mine_Argentée));
            ListeArc.Add(new Arc(NomArc.Zou));
            ListeArc.Add(new Arc(NomArc.Whole_Cake));
            ListeArc.Add(new Arc(NomArc.Reverie));
            ListeArc.Add(new Arc(NomArc.Wano_Kuni));
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

        public Arc ArcSuivant(Arc arcActu)
        {
            return ListeArc[ListeArc.IndexOf(arcActu)+1];
        }

        public Arc ArcPrécédent(Arc arcActu)
        {
            return ListeArc[ListeArc.IndexOf(arcActu)-1];
        }
    }
}
