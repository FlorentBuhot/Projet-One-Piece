using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Arc
    {
        private string description;
        public string Description { get => description; set => description = value; }

        private string sourceImageArc;
        public string SourceImageArc { get => sourceImageArc; set => sourceImageArc = value; }
    }
}
