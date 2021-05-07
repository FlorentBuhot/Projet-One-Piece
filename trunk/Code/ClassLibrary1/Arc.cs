using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Arc
    {
        public string Description { get; set; }
        public NomArc Nom { get; set; }
        private LinkedList<Image> sourceImgArc;

        public Arc(string description, NomArc nom, Image img)
        {
            Description = description;
            Nom = nom;
            AjouterImage(img);
        }
        public void AjouterImage(Image img)
        {
            sourceImgArc.AddLast(img);
        }
        public void AjouterDesc(string desc)
        {
            Description += desc;
        }
    }
}
