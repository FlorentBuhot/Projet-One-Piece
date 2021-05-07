using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Image
    {
        public Image(string source, string description)
        {
            Source = source;
            Description = description;
        }

        public string Source { get => source; set => source = value; }
        private string source;

        public string Description { get => description; set => description = value; }
        private string description;
    }
}
