using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace Test_Personnage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe personnage");

            testCreationPerso();


            /// <summary>
            /// Test de la création du personnage et de la redéfinition de ToStrong
            /// </summary>
            void testCreationPerso()
            {
                Personnage luffy = new Personnage("Monkey .D", "Luffy", "Capitaine des Mugiwara", 17, 
                    new Haki("Haki des rois", "pété de ouf"), 
                    new Appartennance("Les Mugiwara", "Equipage Pirate"), 
                    new Image("sdgs", "Image simple"), 
                    new List<Arc> { new Arc(NomArc.Impel_Down, "Dans la prison", new Image("sgd", "gsgs")) });

                Console.WriteLine(luffy.ToString());
                Console.WriteLine(luffy.Haki);
                Console.WriteLine(luffy.Appart);
            }
        }
    }
}
