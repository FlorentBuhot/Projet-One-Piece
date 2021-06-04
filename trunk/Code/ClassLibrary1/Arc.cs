using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClassLibrary1
{
    [DataContract]
    public class Arc
    {
        [DataMember(EmitDefaultValue = false)]
        public string Info { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Nom { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ClassLibrary1.Image ImgDeBase { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public LinkedList<Image> SourceImgArc { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public List<Personnage> ListePerso { get; set; }

        public Arc(string nom, string description, Image img)
        {
            Nom = nom;
            Info = description;
            SourceImgArc = new LinkedList<Image>();
            SourceImgArc.AddLast(img);
            ImgDeBase = img;
        }

        public Arc(string nom, string description, Image img, List<Personnage> personnages)
        {
            Nom = nom;
            Info = description;
            SourceImgArc = new LinkedList<Image>();
            SourceImgArc.AddLast(img);
            ImgDeBase = img;
            ListePerso = new List<Personnage>();
            ListePerso = personnages;
        }

        public Arc(string nom)
        {
            Info = null;
            Nom = nom;
            SourceImgArc = new LinkedList<Image>();
        }
        public override string ToString()
        {
            return Nom + " " + Info;
        }
    }
}
