using System;

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
        public Personnage(string nom, string prénom, int age, string équpage)
        {
            Nom = nom;
            Prénom = prénom;
            Age = age;
            Equipage = équipage;
        }

        /// <summary>
        /// Getter et setter pour le prénom
        /// </summary>
        public string Prénom
        {
            get
            {
                return prénom;
            }
            set
            {
                prénom = value;
            }
        }
        private string prénom;


        /// <summary>
        /// Getter et setter pour le nom
        /// </summary>
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
        private string nom;

        /// <summary>
        /// Getter et setter pour l'age
        /// </summary>
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        private int age;

        /// <summary>
        /// Getter et setter pour l'équipage
        /// </summary>
        public string Equipage
        {
            get
            {
                return équipage;
            }
            set
            {
                équipage = value;
            }
        }
        private string équipage;
    }
}
