using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel;
using ClassLibrary1;
using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    /// <summary>
    /// Classe Personnage, reflette les information et les modification de personnages de l'application
    /// </summary>
    
    [DataContract]
    public class Personnage : INotifyPropertyChanged
    {
        public Personnage self => this;
        [DataMember (EmitDefaultValue = false)]
        public string Prénom { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Nom { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Info 
        { 
            get => info;
            set
            {
               if (info == value) return;
               info = value;
               OnPropertyChanged();
               OnPropertyChanged(nameof(self));
            }
        }
        private string info;

        [DataMember(EmitDefaultValue = false)]
        public int Age 
        { 
            get => age; 
            set
            {
                if (age == value || value <= 0) return;
                age = value;
            }
        }
        private int age;
        [DataMember(EmitDefaultValue = false)]
        public Image ImgBase { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public List<Haki> ListHaki { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Appartennance Appart { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public List<Image> SourceImgPerso { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public List<Arc> ListeArc { get; set; }

        public Personnage()
        {
            Nom = null;
            Prénom = null;
            Info = null;
            Age = 0;
            ListHaki = new List<Haki>();
            Appart = null;
            SourceImgPerso = new List<Image>();
            ListeArc = new List<Arc>();
        }

        public Personnage(string nom, string prenom, Image imgBase)
        {
            Nom = nom;
            Prénom = prenom;
            ImgBase = imgBase;
            ListeArc = new List<Arc>();
            SourceImgPerso = new List<Image>();
            ListHaki = new List<Haki>();
            Appart = null;
        }


        /// <summary>
        /// Créer pour la modification des informations 
        /// </summary>
        /// <param name="info"></param>
        public Personnage(string info)
        {
            Nom = null;
            Prénom = null;
            Info = info;
            Age = 0;
            ListHaki = new List<Haki>();
            Appart = null;
            SourceImgPerso = new List<Image>();
            ListeArc = new List<Arc>();
        }

        /// <summary>
        /// constructeur du personnage
        /// </summary>
        /// <param name="nom">nom du personnage</param>
        /// <param name="prénom">prénom du personnage</param>
        /// <param name="info">info sur le personnage</param>
        /// <param name="age">age du personnage</param>
        /// <param name="haki">haki du personnage</param>
        /// <param name="appartennance">l'appartenance du personnage</param>
        /// <param name="img">une image du personnage</param>
        /// <param name="arcs">list des arcs dans lequel le personnage apparait</param>
        public Personnage(string nom, string prénom, string info, int age, List<Haki> hakis, Image imgBase, Appartennance appartennance, List<Arc> arcs)
        {
            Nom = nom;
            Prénom = prénom;
            Info = info;
            Age = age;
            ListHaki = new List<Haki>();
            ListHaki = hakis;
            Appart = appartennance;
            ImgBase = imgBase;
            SourceImgPerso = new List<Image>();
            SourceImgPerso.Add(imgBase);
            ListeArc = new List<Arc>();
            ListeArc = arcs;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Ajouter une image à la liste d'image du personnage
        /// </summary>
        /// <param name="img">L'image à ajouter</param>
        public void AjouterImagePerso(Image img)
        {
            SourceImgPerso.Add(img);
        }

        /// <summary>
        /// Ajouter une info au personnage
        /// </summary>
        /// <param name="info">L'info à ajouter</param>
        public void AjouterInfoPerso(string info)
        {
            Info += info;
        }

        /// <summary>
        /// redeffinision de toString
        /// </summary>
        /// <returns> affiche le nom et le prénom</returns>
        public override string ToString()
        {
            return Nom + " " + Prénom;
        }

        public override bool Equals(object obj)
        {
            return obj is Personnage personnage &&
                   Prénom == personnage.Prénom &&
                   Nom == personnage.Nom &&
                   Info == personnage.Info &&
                   Age == personnage.Age &&
                   EqualityComparer<Image>.Default.Equals(ImgBase, personnage.ImgBase) &&
                   EqualityComparer<List<Haki>>.Default.Equals(ListHaki, personnage.ListHaki) &&
                   EqualityComparer<Appartennance>.Default.Equals(Appart, personnage.Appart) &&
                   EqualityComparer<List<Image>>.Default.Equals(SourceImgPerso, personnage.SourceImgPerso) &&
                   EqualityComparer<List<Arc>>.Default.Equals(ListeArc, personnage.ListeArc);
        }
    }
}
                                                                                                                                                                                                                  