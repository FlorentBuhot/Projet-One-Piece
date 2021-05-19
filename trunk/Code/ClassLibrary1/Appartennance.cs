using System;
using System.Collections.Generic;
using System.Text;



namespace ClassLibrary1
{
    public class Appartennance
    {
        public string Description { get; set; }
        public string Nom { get; set; }

        public Appartennance(string nom, string description)
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
            Appartennance test = obj as Appartennance;
            if (test.Description.Equals(this.Description) && test.Nom.Equals(this.Nom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return Nom + " " + Description;
        }
    }
}
