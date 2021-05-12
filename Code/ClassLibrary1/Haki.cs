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

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Haki test = obj as Haki;
            if(test.Nom.Equals(this.Nom) && test.Description.Equals(this.Description))
            {
                return true;
            }
            else { return false; }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nom, Description);
        }

        public override string ToString()
        {
            return Nom + " " + Description;
        }
    }
}
