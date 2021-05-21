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
                Manager monManager = new Manager();
                Personnage luffy = new Personnage("Monkey .D", "Luffy", "Capitaine des Mugiwara", 17,
                    new List<Haki> { new Haki(NomHaki.Haki_des_rois, "pété de ouf"), 
                                     new Haki(NomHaki.Haki_de_perception, "Perceptionne mieux"), 
                                     new Haki(NomHaki.Haki_du_renforcement, "Permet de se renforcer")}, 
                    new Appartennance("Les Mugiwara", "Equipage Pirate"), 
                    new Image("sdgs", "Image simple"), 
                    new List<Arc> { new Arc(NomArc.Impel_Down, "Dans la prison", new Image("sgd", "gsgs")) });

                Console.WriteLine(luffy.ToString());
                Console.WriteLine(luffy.Appart);
            }
        }
    }
}
