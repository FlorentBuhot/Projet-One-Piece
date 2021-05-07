using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Haki
    {
        public Haki(string nom, string description)
        {
            Nom = nom;
            Description = description;
        }

        private string nom;
        public string Nom { get => nom; set => nom = value; }

        private string description;
        public string Description { get => description; set => description = value; }
    }
}
