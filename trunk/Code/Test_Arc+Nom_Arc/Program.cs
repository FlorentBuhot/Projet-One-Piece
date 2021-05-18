using ClassLibrary1;
using System;

namespace Test_Arc_Nom_Arc
{
    class Program
    {
        static void Main(string[] args)
        {
            Arc alabasta = new Arc(NomArc.Alabasta, "Dans la prison", new Image("sgd", "gsgs"));

            Console.WriteLine(NomArc.Alabasta.GetHashCode());
            Console.WriteLine(alabasta.GetHashCode());
        }
    }
}
