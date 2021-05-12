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

        public Arc(NomArc nom, string description, Image img)
        {
            Nom = nom;
            Info = description;
            SourceImgArc = new LinkedList<Image>();
            SourceImgArc.AddLast(img);
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

        public override int GetHashCode()
        {
            return HashCode.Combine(Info, Nom, SourceImgArc);
        }
    }
}
