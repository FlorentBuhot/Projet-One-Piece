using System;
using ClassLibrary1;
using DataContractPersistance;

namespace Test_DataContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(new Stub.Stub());
            manager.ChargeDonnees();
            manager.Persistance = new DataContractPersistance.DataContractPers();
            manager.SauvegardeDonnees();
        }
    }
}
