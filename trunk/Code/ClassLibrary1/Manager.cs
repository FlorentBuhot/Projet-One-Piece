using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    public class Manager : INotifyPropertyChanged
    {
        public HashSet<Personnage> ListePreso { get; private set; }
        public List<Arc> ListeArc { get; private set; }
        public List<Haki> Hakis { get; private set; }
        private Arc arcAfficher;
        public Arc ArcAfficher {
            get => arcAfficher;
            set
            {
                if (value != arcAfficher)
                {
                    arcAfficher = value;
                    OnPropertyChanged();
                }
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int NumArc { get; set; }

        public Manager()
        {
            ListePreso = new HashSet<Personnage>();
            ListeArc = new List<Arc>();
            ListeArc.Add(new Arc("Colonel Morgan", "Première arc de One Piece", new Image("/ImageArc/morgan.png", "Le colonel Morgan"), new List<Personnage> { new Personnage("Monkey .D", "Luffy", new Image("/ImagePerso/Luffy/luffy_sourire.png", "Luffy de base"))}));
            ListeArc.Add(new Arc("Baggy le Clown"));
            ListeArc.Add(new Arc("Capitaine Kuro"));
            ListeArc.Add(new Arc("Baratie"));
            ListeArc.Add(new Arc("Arlong"));
            ListeArc.Add(new Arc("LogueTown"));
            ListeArc.Add(new Arc("Laboon"));
            ListeArc.Add(new Arc("Whiskey Peak"));
            ListeArc.Add(new Arc("Little Garden"));
            ListeArc.Add(new Arc("Royaume de Drum"));
            ListeArc.Add(new Arc("Alabasta"));
            ListeArc.Add(new Arc("Jaya"));
            ListeArc.Add(new Arc("Skypiea"));
            ListeArc.Add(new Arc("Davy Back Fight"));
            ListeArc.Add(new Arc("Water Seven"));
            ListeArc.Add(new Arc("Enies Lobby"));
            ListeArc.Add(new Arc("Post Enies Lobby"));
            ListeArc.Add(new Arc("Thriller Bark"));
            ListeArc.Add(new Arc("Archipel Sabaody"));
            ListeArc.Add(new Arc("Amazon Lily"));
            ListeArc.Add(new Arc("Impel Down"));
            ListeArc.Add(new Arc("Marineford"));
            ListeArc.Add(new Arc("Post Marineford"));
            ListeArc.Add(new Arc("Retour à Sabaody"));
            ListeArc.Add(new Arc("Hommes Poissons"));
            ListeArc.Add(new Arc("Punk Hazard"));
            ListeArc.Add(new Arc("Dressrosa"));
            ListeArc.Add(new Arc("Mine Argentée"));
            ListeArc.Add(new Arc("Zou"));
            ListeArc.Add(new Arc("Whole Cake"));
            ListeArc.Add(new Arc("Reverie"));
            ListeArc.Add(new Arc("Wano Kuni"));
            

            List<Haki> Hakis = new List<Haki>();
            Hakis.Add(new Haki(NomHaki.Haki_des_rois, "Pété de ouf"));
            Hakis.Add(new Haki(NomHaki.Haki_de_perception, "Bonne perception"));
            Hakis.Add(new Haki(NomHaki.Haki_du_renforcement, "Permet de se renforcé"));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ArcAAfficher(int numArc)
        {
            ArcAfficher = ListeArc[numArc];
            NumArc = numArc;
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

        public int ArcSuivant()
        {
            return NumArc + 1;
        }

        public int ArcPrécédent(Arc arcActu)
        {
            return NumArc - 1;
        }
    }
}
