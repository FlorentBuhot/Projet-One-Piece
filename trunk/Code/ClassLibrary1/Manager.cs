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
        public List<Haki> Hakis { get; private set; }
        public Arc ArcAfficher { get; set; }

        public Manager()
        {
            ListePreso = new HashSet<Personnage>();
            ListeArc = new List<Arc>();
            ListeArc.Add(new Arc("Colonel_Morgan"));
            ListeArc.Add(new Arc("Baggy_le_Clown"));
            ListeArc.Add(new Arc("Capitaine_Kuro"));
            ListeArc.Add(new Arc("Baratie"));
            ListeArc.Add(new Arc("Arlong"));
            ListeArc.Add(new Arc("LogueTown"));
            ListeArc.Add(new Arc("Laboon"));
            ListeArc.Add(new Arc("Whiskey_Peak"));
            ListeArc.Add(new Arc("Little_Garden"));
            ListeArc.Add(new Arc("Royaume_de_Drum"));
            ListeArc.Add(new Arc("Alabasta"));
            ListeArc.Add(new Arc("Jaya"));
            ListeArc.Add(new Arc("Skypiea"));
            ListeArc.Add(new Arc("Davy_Back_Fight"));
            ListeArc.Add(new Arc("Water_Seven"));
            ListeArc.Add(new Arc("Enies_Lobby"));
            ListeArc.Add(new Arc("Post_Enies_Lobby"));
            ListeArc.Add(new Arc("Thriller_Bark"));
            ListeArc.Add(new Arc("Archipel_Sabaody"));
            ListeArc.Add(new Arc("Amazon_Lily"));
            ListeArc.Add(new Arc("Impel_Down"));
            ListeArc.Add(new Arc("Marineford"));
            ListeArc.Add(new Arc("Post_Enies_Lobby"));
            ListeArc.Add(new Arc("Retour_a_Sabaody"));
            ListeArc.Add(new Arc("Hommes_Poissons"));
            ListeArc.Add(new Arc("Punk_Hazard"));
            ListeArc.Add(new Arc("Dressrosa"));
            ListeArc.Add(new Arc("Mine_Argentée"));
            ListeArc.Add(new Arc("Zou"));
            ListeArc.Add(new Arc("Whole_Cake"));
            ListeArc.Add(new Arc("Reverie"));
            ListeArc.Add(new Arc("Wano_Kuni"));
            

            List<Haki> Hakis = new List<Haki>();
            Hakis.Add(new Haki(NomHaki.Haki_des_rois, "Pété de ouf"));
            Hakis.Add(new Haki(NomHaki.Haki_de_perception, "Bonne perception"));
            Hakis.Add(new Haki(NomHaki.Haki_du_renforcement, "Permet de se renforcé"));
        }

        public void ArcAAfficher(int numArc)
        {
            ArcAfficher = ListeArc[numArc];
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
                    test.SourceImgPerso.Add(img);
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
