using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClassLibrary1
{
    [DataContract]
    public class Image
    {
        [DataMember(EmitDefaultValue = false)]
        public string Source { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }

        public Image(string source, string description)
        {
            Source = source;
            Description = description;
        }

        public Image()
        {
            Source = null;
            Description = null;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Image test = obj as Image;
            if (test.Source.Equals(this.Source))
            {
                return true;
            }
            else { return false; }
        }
    }
}
