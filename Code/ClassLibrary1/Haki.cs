﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClassLibrary1
{
    [DataContract]
    public class Haki
    {
        [DataMember(EmitDefaultValue = false)]
        public NomHaki Nom { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }

        public Haki(NomHaki nom, string description)
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
            if(test.Nom.Equals(this.Nom))
            {
                return true;
            }
            else { return false; }
        }



        public override string ToString()
        {
            return Nom + " " + Description;
        }
    }
}
