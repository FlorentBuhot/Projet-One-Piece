using System.Collections.Generic;
using ClassLibrary1;

namespace ClassLibrary1
{
    /// <summary>
    /// Classe Personnage, reflette les information et les modification de personnages de l'application
    /// </summary>
    public class Personnage
    {
        /// <summary>
        /// Constructeur d'un personnage
        /// </summary>
        /// <param name="nom"> Le nom du personnage</param>
        /// <param name="prénom"> Le prénom du personnaga</param>
        /// <param name="age"> L'age du personnage</param>
        /// <param name="équpage"> Le nom de l'équipage du personnage</param>
        public Personnage(string nom, string prénom, string info, int age, string équipage, string typeHaki)
        {
            Nom = nom;
            Prénom = prénom;
            Info = info;
            Age = age;
        }

        /// <summary>
        /// Getter et setter pour le prénom
        /// </summary>
        public string Prénom { get => prénom; set => prénom = value; }
        private string prénom;

        /// <summary>
        /// Getter et setter pour le nom
        /// </summary>
        public string Nom { get => nom; set => nom = value; }
        private string nom;

        public string Info { get => info; set => info = value; }
        private string info;

        /// <summary>
        /// Getter et setter pour l'age
        /// </summary>
        public int Age { get => age; set => age = value; }
        private int age;

        private LinkedList<Image> sourceImgPerso;

        public void AjouterImage(Image img)
        {
            sourceImgPerso.AddLast(img);
        }
    }
}
