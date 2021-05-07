using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Haki
    {
        public string Nom { get; set; }
        public string Description { get; set; }

        public Haki(string nom, string description)
        {
            Nom = nom;
            Description = description;
        }
    }
}
