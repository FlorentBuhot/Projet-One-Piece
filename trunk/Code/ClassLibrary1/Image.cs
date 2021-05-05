using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Image
    {
        private string source;
        private string description;

        public Image(string source, string description)
        {
            Source = source;
            Description = description;
        }

        public string Source { get => source; set => source = value; }
        public string Description { get => description; set => description = value; }
    }
}
