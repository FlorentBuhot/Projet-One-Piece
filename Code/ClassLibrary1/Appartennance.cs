using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;



namespace ClassLibrary1
{
    [DataContract]
    public class Appartennance
    {
        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Nom { get; set; }

        public Appartennance(string nom, string description)
        {
            Nom = nom;
            Description = description;
        }

        public Appartennance(string nom)
        {
            Nom = nom;
            Description = null;
        }

        public override string ToString()
        {
            return Nom + " " + Description;
        }
    }
}
