using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Arc
    {
        public string Info { get; set; }
        public NomArc Nom { get; set; }
        public LinkedList<Image> SourceImgArc { get; set; }

        public Arc(string description, NomArc nom, Image img)
        {
            Info = description;
            Nom = nom;
            AjouterImage(img);
        }
        public void AjouterImage(Image img)
        {
            SourceImgArc.AddLast(img);
        }
        public void AjouterDesc(string desc)
        {
            Info += desc;
        }
    }
}
