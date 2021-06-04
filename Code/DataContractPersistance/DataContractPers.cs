using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using ClassLibrary1;

namespace DataContractPersistance
{
    public class DataContractPers : IPersistanceManager
    {

        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "..//XML");
        public string FileName { get; set; } = "OPForever.xml";
        string PersFile => Path.Combine(FilePath, FileName);
        private DataContractSerializer serializer { get; set; } = new DataContractSerializer(typeof(DataPersist));
        public (IEnumerable<Personnage> personnages, IEnumerable<Arc> arcs, IEnumerable<Haki> hakis) ChargeDonnees()
        {
            if (!File.Exists(PersFile))
            {
                throw new FileNotFoundException("Fichier manquant !");
            }

            DataPersist data = new DataPersist();
            using (Stream s = File.OpenRead(PersFile))
            {
                data = serializer.ReadObject(s) as DataPersist;
            }

            return (data.Personnages, data.Arcs, data.Hakis);
        }

        public void SauvegardeDonnees(IEnumerable<Personnage> personnages, IEnumerable<Arc> arcs, IEnumerable<Haki> hakis)
        {

            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            DataPersist data = new DataPersist();
            data.Personnages.AddRange(personnages);
            data.Arcs.AddRange(arcs);
            data.Hakis.AddRange(hakis);

            var settings = new XmlWriterSettings() { Indent = true };
            using (TextWriter tw = File.CreateText(PersFile))
            {
                using (XmlWriter writer = XmlWriter.Create(tw, settings))
                {
                    serializer.WriteObject(writer, data);
                }
            }
        }
    }
}
