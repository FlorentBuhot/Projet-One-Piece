﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Image
    {
        public string Source { get; set; }
        public string Description { get; set; }
        public Image(string source, string description)
        {
            Source = source;
            Description = description;
        }

        public Image()
        {
            Source = "";
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

        public override int GetHashCode()
        {
            return HashCode.Combine(Source, Description);
        }
    }
}
