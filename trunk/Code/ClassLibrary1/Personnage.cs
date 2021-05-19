using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace ClassLibrary1
{
    /// <summary>
    /// Classe Personnage, reflette les information et les modification de personnages de l'application
    /// </summary>
    public class Personnage
    {
        public string Prénom { get; set; }
        public string Nom { get; set; }
        public string Info { get; set; }
        public int Age { get; set; }
        public Haki Haki { get; set; }
        public Appartennance Appart { get; set; }
        public LinkedList<Image> SourceImgPerso { get; set; }
        public List<Arc> ListeArc { get; set; }

        public Personnage()
        {
            Nom = null;
            Prénom = null;
            Info = null;
            Age = 0;
            Haki = null;
            Appart = null;
            SourceImgPerso = new LinkedList<Image>();
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
        public Personnage(string nom, string prénom, string info, int age, Haki haki, Appartennance appartennance, Image img, List<Arc> arcs)
        {
            Nom = nom;
            Prénom = prénom;
            Info = info;
            Age = age;
            Haki = haki;
            Appart = appartennance;
            SourceImgPerso = new LinkedList<Image>();
            SourceImgPerso.AddLast(img);
            ListeArc = new List<Arc>();
            ListeArc = arcs;
        }

        /// <summary>
        /// Ajouter une image à la liste d'image du personnage
        /// </summary>
        /// <param name="img">L'image à ajouter</param>
        public void AjouterImagePerso(Image img)
        {
            SourceImgPerso.AddLast(img);
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
        /// Equals du personnage
        /// </summary>
        /// <param name="obj">obj pour lequel on test l'égalité</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Personnage test = obj as Personnage;
            if (test.Nom.Equals(this.Nom) &&
                test.Prénom.Equals(this.Prénom) &&
                test.Info.Equals(this.Info) && test.Age.Equals(this.Age) &&
                test.Haki.Equals(this.Haki) && test.Appart.Equals(this.Appart) &&
                test.SourceImgPerso.Equals(this.SourceImgPerso) &&
                test.ListeArc.Equals(this.ListeArc))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// redeffinision de toString
        /// </summary>
        /// <returns> affiche le nom et le prénom</returns>
        public override string ToString()
        {
            return Nom + " " + Prénom;
        }

        /// <summary>
        /// Donne le hashcode du personnage en fonction de tous ses attributs
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Prénom, Nom, Info, Age, Haki, Appart, SourceImgPerso, ListeArc);
        }
    }
}
