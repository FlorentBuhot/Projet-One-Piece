using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;

namespace ClassLibrary1
{
    public class Manager : INotifyPropertyChanged
    {
        public List <Personnage> ListePerso { get; private set; }
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

        private Personnage persoAfficher;
        public Personnage PersoAfficher
        {
            get => persoAfficher;
            set
            {
                if (value != persoAfficher)
                {
                    persoAfficher = value;
                    OnPropertyChanged();
                }
            }
        }
        public int NumArc { get; set; }

        /// <summary>
        /// Dépendance vers le gestionnaire de persistance  
        /// </summary>
        public IPersistanceManager Persistance { get; /*private*/ set; }

        public Manager(IPersistanceManager p)
        {
            Persistance = p;
            ListePerso = new List<Personnage>();
            ListeArc = new List<Arc>();
            Hakis = new List<Haki>();
        }

        public Manager()
        {
            ListePerso = new List<Personnage>();
            ListeArc = new List<Arc>();
            Hakis = new List<Haki>();
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ChargeDonnees()
        {
            var donnees = Persistance.ChargeDonnees(); // <=== dépendance
            foreach(var p in donnees.personnages)
            {
                ListePerso.Add(p);
            }
            foreach (var a in donnees.arcs)
            {
                ListeArc.Add(a);
            }
            foreach(var h in donnees.hakis)
            {
                Hakis.Add(h);
            }
        }

        public void SauvegardeDonnees()
        {
            Persistance.SauvegardeDonnees(ListePerso, ListeArc, Hakis); // <=== dépendance
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void ArcAAfficher(int numArc)
        {
            ArcAfficher = ListeArc[numArc];
            NumArc = numArc;
        }

        public void AjouterPerso(Personnage perso)
        {
            if (ListePerso.Contains(perso))
            {
                return;
            }
            else
            {
                ListePerso.Add(perso);
            }
        }

        public void AjouterImgPerso(Image img, Personnage perso)
        {
            foreach(Personnage test in ListePerso)
            {
                if (test.Equals(perso))
                {
                    test.SourceImgPerso.Add(img);
                }
            }
        }
        public Personnage AjouterInfoPerso(Personnage ancien, Personnage nouveau)
        {
            if (!ancien.Equals(nouveau))
            {
                return null;
            }
            Type typePerso = typeof(Personnage);
            var PersProperties = typePerso.GetProperties();
            foreach(var property in PersProperties.Where(ppty => ppty.CanWrite))
            {
                property.SetValue(ancien, property.GetValue(nouveau));
            }
            OnPropertyChanged();
            return ancien;
        }

        public Personnage RechercherPerso(string nomPerso)
        {
            foreach(Personnage testPerso in ListePerso)
            {
                if (testPerso.Prénom.Equals(nomPerso))
                {
                    return testPerso;
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
