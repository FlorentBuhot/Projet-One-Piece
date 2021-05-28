﻿using System;
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
        public Image ImgBase { get; set; }
        public List<Haki> ListHaki { get; set; }
        public Appartennance Appart { get; set; }
        public List<Image> SourceImgPerso { get; set; }
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

        /// <summary>
        /// Donne le hashcode du personnage en fonction de tous ses attributs
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Prénom, Nom, Info, Age, ListHaki, ImgBase, Appart, ListeArc);
        }
    }
}
