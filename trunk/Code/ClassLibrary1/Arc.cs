using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Arc
    {
        public string Description { get => description; set => description = value; }
        private string description;

        public NomArc Nom { get => nom; set => nom = value; }
        private NomArc nom;

        private string info;
        public string Info { get => info; set => info = value; }

        private LinkedList<Image> sourceImgArc;

        public void AjouterImageArc(Image img)
        {
            sourceImgArc.AddLast(img);
        }
        public void AjouterInfoArc(string info)
        {
            Info += info;
        }
    }
}
