using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Arc
    {
        public string Description { get => description; set => description = value; }
        private string description;
        public string SourceImageArc { get => sourceImageArc; set => sourceImageArc = value; }
        private string sourceImageArc;
    }
}
