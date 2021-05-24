using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Arc
    {
        public string Info { get; set; }
        public string Nom { get; set; }
        public ClassLibrary1.Image ImgDeBase { get; set; }
        public LinkedList<Image> SourceImgArc { get; set; }

        public Arc(string nom, string description, Image img)
        {
            Nom = nom;
            Info = description;
            SourceImgArc = new LinkedList<Image>();
            SourceImgArc.AddLast(img);
            ImgDeBase = img;
        }

        public Arc(string nom)
        {
            Info = null;
            Nom = nom;
            SourceImgArc = new LinkedList<Image>();
        }

        public override bool Equals(object obj)
        {
            if(obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Arc test = obj as Arc;
            if (test.Info.Equals(this.Info) && test.Nom.Equals(this.Nom) && test.SourceImgArc.Equals(this.SourceImgArc))
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
            return Nom + " " + Info;
        }
    }
}
