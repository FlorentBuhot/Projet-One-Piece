using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using ClassLibrary1;

namespace DataContractPersistance
{
    [DataContract]
    class DataPersist
    {
        [DataMember]
        public List<Personnage> Personnages { get; set; } = new List<Personnage>();
        [DataMember]
        public List<Arc> Arcs { get; set; } = new List<Arc>();
        [DataMember]
        public List<Haki> Hakis { get; set; } = new List<Haki>();
    }
}
