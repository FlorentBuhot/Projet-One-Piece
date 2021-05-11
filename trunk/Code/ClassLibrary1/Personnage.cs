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


        /// <summary>
        /// Constructeur personnage
        /// </summary>
        /// <param name="nom">Nom du personnage</param>
        /// <param name="prénom">Prénom du personnage</param>
        /// <param name="info">Information sur le personnage</param>
        /// <param name="age">L'age du personnage</param>
        /// <param name="haki">Le haki du personnage</param>
        /// <param name="img">Une image du personnage</param>
        /// <param name="appartennance">L'appartenance du personnage</param>
        /// <param name="arcs">Listes des arcs du personnage</param>
        public Personnage(string nom, string prénom, string info, int age, Haki haki, Appartennance appartennance, Image img, List<Arc> arcs)
        {
            Nom = nom;
            Prénom = prénom;
            Info = info;
            Age = age;
            Haki = haki;
            Appart = appartennance;
            SourceImgPerso.AddLast(img);
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
    }
}
