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

        private LinkedList<Image> sourceImgPerso;
        private List<Arc> ListeArc;


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
        public Personnage(string nom, string prénom, string info, int age, Haki haki, Image img, Appartennance appartennance, List<Arc> arcs)
        {
            Nom = nom;
            Prénom = prénom;
            Info = info;
            Age = age;
            Haki = haki;
            AjouterImagePerso(img);
            Appart = appartennance;
            List<Arc> ListeArc = new List<Arc>();
            ListeArc = arcs;
        }

        /// <summary>
        /// Ajouter une image à la liste d'image du personnage
        /// </summary>
        /// <param name="img">L'image à ajouter</param>
        public void AjouterImagePerso(Image img)
        {
            sourceImgPerso.AddLast(img);
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
