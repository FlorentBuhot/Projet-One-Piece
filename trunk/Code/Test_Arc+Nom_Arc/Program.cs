using ClassLibrary1;
using System;

namespace Test_Arc_Nom_Arc
{
    class Program
    {
        static void Main(string[] args)
        {
            testHashCode();

            /// <summary>
            /// Test du hashcode de l'arc et de nomArc pour qu'ils soient bien identiquz
            /// </summary>
            void testHashCode()
            {
                Arc alabasta = new Arc(NomArc.Alabasta, "Dans le désert", new Image("sgd", "gsgs"));

                Console.WriteLine(NomArc.Alabasta.GetHashCode());
                Console.WriteLine(alabasta.GetHashCode());
                Console.WriteLine(alabasta.ToString());
            }
        }
    }
}
