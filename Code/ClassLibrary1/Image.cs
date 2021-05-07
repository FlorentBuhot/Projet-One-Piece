using System;
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
    }
}
