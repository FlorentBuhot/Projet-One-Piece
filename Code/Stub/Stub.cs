﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using ClassLibrary1;

namespace Stub
{
    public class Stub : IPersistanceManager
    {
        public (IEnumerable<Personnage> personnages, IEnumerable<Arc> arcs, IEnumerable<Haki> hakis) ChargeDonnees()
        {
            List<Arc> lesArcs = ChargeArc();
            List<Personnage> lesPersonnages = chargePerso();
            List<Haki> lesHakis = chargeHaki();
            return (lesPersonnages, lesArcs, lesHakis);
        }

        public void SauvegardeDonnees(IEnumerable<Personnage> personnages, IEnumerable<Arc> arcs, IEnumerable<Haki> hakis)
        {
            Debug.WriteLine("Sauvegarde damandé");
        }

        private List<Arc> ChargeArc()
        {
            List<Arc> ListeArc = new List<Arc>();
            ListeArc.Add(new Arc("Colonel Morgan", "Première arc de One Piece", new Image("/ImageArc/morgan.png", "Le colonel Morgan"), new List<Personnage> { new Personnage("Monkey .D", "Luffy", new Image("/ImagePerso/Luffy/luffy_sourire.png", "Luffy de base")) }));
            ListeArc.Add(new Arc("Baggy le Clown"));
            ListeArc.Add(new Arc("Capitaine Kuro"));
            ListeArc.Add(new Arc("Baratie"));
            ListeArc.Add(new Arc("Arlong"));
            ListeArc.Add(new Arc("LogueTown"));
            ListeArc.Add(new Arc("Laboon"));
            ListeArc.Add(new Arc("Whiskey Peak"));
            ListeArc.Add(new Arc("Little Garden"));
            ListeArc.Add(new Arc("Royaume de Drum"));
            ListeArc.Add(new Arc("Alabasta"));
            ListeArc.Add(new Arc("Jaya"));
            ListeArc.Add(new Arc("Skypiea"));
            ListeArc.Add(new Arc("Davy Back Fight"));
            ListeArc.Add(new Arc("Water Seven"));
            ListeArc.Add(new Arc("Enies Lobby"));
            ListeArc.Add(new Arc("Post Enies Lobby"));
            ListeArc.Add(new Arc("Thriller Bark"));
            ListeArc.Add(new Arc("Archipel Sabaody"));
            ListeArc.Add(new Arc("Amazon Lily"));
            ListeArc.Add(new Arc("Impel Down"));
            ListeArc.Add(new Arc("Marineford"));
            ListeArc.Add(new Arc("Post Marineford"));
            ListeArc.Add(new Arc("Retour à Sabaody"));
            ListeArc.Add(new Arc("Hommes Poissons"));
            ListeArc.Add(new Arc("Punk Hazard"));
            ListeArc.Add(new Arc("Dressrosa"));
            ListeArc.Add(new Arc("Mine Argentée"));
            ListeArc.Add(new Arc("Zou"));
            ListeArc.Add(new Arc("Whole Cake"));
            ListeArc.Add(new Arc("Reverie"));
            ListeArc.Add(new Arc("Wano Kuni"));
            return ListeArc;
        }

        private List<Personnage> chargePerso()
        {
            List<Personnage> ListePerso = new List<Personnage>();

            Personnage Luffy = new Personnage();
                Luffy.Prénom = "Luffy";
                Luffy.Nom = "Monkey D.";
                Luffy.Info = "Monkey D. Luffy (モンキー・Ｄディー・ルフィ, Monkī Dī Rufi) est un pirate et le principal protagoniste du manga et anime One Piece. Luffy est le fils du chef de l'Armée Révolutionnaire, Monkey D. Dragon, le petit-fils du célèbre Vice-Amiral de la Marine, Monkey D. Garp, le fils adoptif d'une bandit des montagnes, Curly Dadan ainsi que le frère adoptif du défunt Portgas D. Ace et de Sabo. Son rêve le plus cher est de devenir le Seigneur des Pirates en trouvant le trésor légendaire One Piece, caché quelque part dans le monde par Gol D. Roger. Selon lui, être le Seigneur des Pirates signifie être celui qui jouit d'une liberté sans pareille dans le monde. Il a mangé un Fruit du Démon : le Gomu Gomu no Mi, qui a été rapporté lors d'un voyage par L'Équipage du Roux au Village de Fuchsia, à ce moment là. En tant que fondateur et Capitaine de l'Équipage du Chapeau de Paille, il est le premier membre à en faire partie, ainsi que l'un des trois combattants les plus forts de ce dernier, s'il n'est le plus fort. C'est également le fondateur involontaire de La Grande Flotte du Chapeau de Paille, il refuse cependant d'en être le Capitaine, ne désirant pas priver les autres de leur liberté. Luffy a une réputation mondiale pour avoir causé des troubles et des catastrophes, même parmi les 7 Capitaines Corsaires et la Marine, en étant allé jusqu'à défier deux des Quatre Empereurs (Big Mom et Kaidô), ainsi qu'en commettant des crimes et actions considérées comme dangereuses par le Gouvernement Mondial. Il a reçu la réputation d'être \"téméraire\" et \"fou\", dans certains cas. Il est, en effet, célèbre pour avoir fait brûler le drapeau du Gouvernement Mondial à Enies Lobby (il s'agissait d'un ordre donné à Sogeking), avant d'y vaincre le CP9 avec son équipage; avoir frappé un Dragon Céleste à Sabaody; vaincu plusieurs des 7 Grands Corsaires (Crocodile, Gecko Moria ou Doflamingo); s'être infiltré et échappé d'Impel Down en y causant une gigantesque évasion (la plus grande de l'histoire de la prison); et s'être joint à la Bataille de Marine Ford, du côté de l'Équipage de Barbe Blanche. De plus, il est connu pour être le seul pirate à s'être non seulement infiltré dans les trois installations capitales du Gouvernement, mais aussi pour s'être échappé vivant de toutes les trois. Ce passé de fauteur de troubles valut rapidement à Luffy le qualificatif \"d\'élément dangereux dans le futur\", notamment pour l\'Amiral Commandant en Chef Sakazuki, faisant de la Marine l\'un de ses plus grands ennemis. Luffy est réputé pour porter son Chapeau de Paille (d'où son épithète \"Luffy au Chapeau de Paille\") que le légendaire capitaine pirate Shanks \"le Roux\" lui a confié lorsqu'il était jeune, ce dernier le tenant lui-même de Roger. Luffy a également une cicatrice avec deux points de suture sous son œil gauche (blessure qu'il s'est lui-même infligée avec un couteau sous l’œil pour prouver son courage à Shanks), et des cheveux noirs assez courts. Similaire à la plupart des hommes de son équipage, Luffy porte la plupart du temps les mêmes vêtements, à l'opposé du reste de l'équipage (spécialement Nami et Nico Robin), qui quant à elles, changent fréquemment de tenues. Quel que soit l'endroit où il se trouve, Luffy porte en toutes circonstances son Chapeau de Paille, même si au début, le chapeau pouvait facilement tomber de sa tête, car instable, ce qui forçait Luffy à le mettre de côté, ou à demander à quelqu'un de le tenir pour lui (le plus souvent à Nami). Il porte des pantalons courts ainsi que des sandales et une veste rouge sans manches. Ayant l'air un peu maigre sous sa chemise, il a pourtant un physique étonnamment bien bâti. Il est assez petit, éclipsé par beaucoup de personnages de la série plus grands.";
                Luffy.Age = 18;
                Luffy.ImgBase = new ClassLibrary1.Image("ImagePerso/Luffy/luffy_sourire.png", "Luffy heureux");

                Haki HakiLuf = new Haki(NomHaki.Haki_des_rois, "Un truc trop fort");
                Luffy.ListHaki.Add(HakiLuf);
                Haki HakiLuf1 = new Haki(NomHaki.Haki_de_perception, "On voit le futur");
                Luffy.ListHaki.Add(HakiLuf1);
                Haki HakiLuf2 = new Haki(NomHaki.Haki_du_renforcement, "Taper fort");
                Luffy.ListHaki.Add(HakiLuf2);

                Appartennance LuffyAppart = new Appartennance("Pirate au Chapeau de Paille", "Equipage trop fort");
                Luffy.Appart = LuffyAppart;

                ClassLibrary1.Image Image1 = new ClassLibrary1.Image("ImagePerso/Luffy/ancien_luffy.png", "Luffy a Sabaody");
                ClassLibrary1.Image Image2 = new ClassLibrary1.Image("ImagePerso/Luffy/gear4_luffy.png", "Le fameux Gear 4");
                ClassLibrary1.Image Image3 = new ClassLibrary1.Image("ImagePerso/Luffy/luffy_petit.png", "Luffy enfant");
                ClassLibrary1.Image Image4 = new ClassLibrary1.Image("ImagePerso/Luffy/luffy_po_content.png", "Luffy énervé");
                ClassLibrary1.Image Image5 = new ClassLibrary1.Image("ImagePerso/Luffy/luffy_drame.png", "Luffy avant la tempete");
                ClassLibrary1.Image Image6 = new ClassLibrary1.Image("ImagePerso/Luffy/luffy_capitaine.jpg", "Luffy le capitaine");
                ClassLibrary1.Image Image7 = new ClassLibrary1.Image("ImagePerso/Luffy/luffy_sourire.png", "Luffy heureux");

                Luffy.SourceImgPerso.Add(Image1);
                Luffy.SourceImgPerso.Add(Image2);
                Luffy.SourceImgPerso.Add(Image3);
                Luffy.SourceImgPerso.Add(Image4);
                Luffy.SourceImgPerso.Add(Image5);
                Luffy.SourceImgPerso.Add(Image6);
                Luffy.SourceImgPerso.Add(Image7);


                Arc Arc1 = new Arc("Colonel_Morgan", "Début", new ClassLibrary1.Image("ImageArc/morgan.png", "Luffy au début"));
                Luffy.ListeArc.Add(Arc1);
                Arc Arc2 = new Arc("Baggy_le_Clown", "hgquf", new ClassLibrary1.Image("ImageArc/baggy.png", "Luffy au début"));
                Luffy.ListeArc.Add(Arc2);
                //Arc Arc3 = new Arc(Capitaine_Kuro, "hgquf", new ClassLibrary1.Image("ImageArc/kuro.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc3);
                //Arc Arc4 = new Arc(Baratie, "hgquf", new ClassLibrary1.Image("ImageArc/baratie.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc4);
                //Arc Arc5 = new Arc(Arlong, "hgquf", new ClassLibrary1.Image("ImageArc/arlong.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc5);
                //Arc Arc6 = new Arc(LogueTown, "hgquf", new ClassLibrary1.Image("ImageArc/loguetown.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc6);
                //Arc Arc7 = new Arc(Laboon, "hgquf", new ClassLibrary1.Image("ImageArc/laboon.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc7);
                //Arc Arc8 = new Arc(Whiskey_Peak, "hgquf", new ClassLibrary1.Image("ImageArc/whiskey.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc8);
                //Arc Arc9 = new Arc(Little_Garden, "hgquf", new ClassLibrary1.Image("ImageArc/garden.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc9);
                //Arc Arc10 = new Arc(Royaume_de_Drum, "hgquf", new ClassLibrary1.Image("ImageArc/drum.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc10);
                //Arc Arc11 = new Arc(Alabasta, "hgquf", new ClassLibrary1.Image("ImageArc/alabasta.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc11);
                //Arc Arc12 = new Arc(Jaya, "hgquf", new ClassLibrary1.Image("ImageArc/jaya.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc12);
                //Arc Arc13 = new Arc(Skypiea, "hgquf", new ClassLibrary1.Image("ImageArc/skypiea.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc13);
                //Arc Arc14 = new Arc(Davy_Back_Fight, "hgquf", new ClassLibrary1.Image("ImageArc/davy.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc14);
                //Arc Arc15 = new Arc(Water_Seven, "hgquf", new ClassLibrary1.Image("ImageArc/water.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc15);
                //Arc Arc16 = new Arc(Enies_Lobby, "hgquf", new ClassLibrary1.Image("ImageArc/enies.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc16);
                //Arc Arc17 = new Arc(Post_Enies_Lobby, "hgquf", new ClassLibrary1.Image("ImageArc/post_enies.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc17);
                //Arc Arc18 = new Arc(Thriller_Bark, "hgquf", new ClassLibrary1.Image("ImageArc/thriller.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc18);
                //Arc Arc19 = new Arc(Archipel_Sabaody, "hgquf", new ClassLibrary1.Image("ImageArc/sabaody.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc19);
                //Arc Arc20 = new Arc(Amazon_Lily, "hgquf", new ClassLibrary1.Image("ImageArc/amazon.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc20);
                //Arc Arc21 = new Arc(Impel_Down, "hgquf", new ClassLibrary1.Image("ImageArc/impel.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc21);
                //Arc Arc22 = new Arc(Marineford, "hgquf", new ClassLibrary1.Image("ImageArc/marineford.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc22);
                //Arc Arc23 = new Arc(NomArc.Post_Marineford, "hgquf", new ClassLibrary1.Image("ImageArc/post_marineford.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc23);
                //Arc Arc24 = new Arc(NomArc.Retour_a_Sabaody, "hgquf", new ClassLibrary1.Image("ImageArc/retour.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc24);
                //Arc Arc25 = new Arc(NomArc.Hommes_Poissons, "hgquf", new ClassLibrary1.Image("ImageArc/hommes.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc25);
                //Arc Arc26 = new Arc(NomArc.Punk_Hazard, "hgquf", new ClassLibrary1.Image("ImageArc/punk.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc26);
                //Arc Arc27 = new Arc(NomArc.Dressrosa, "hgquf", new ClassLibrary1.Image("ImageArc/dressrosa.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc27);
                //Arc Arc28 = new Arc(NomArc.Mine_Argentée, "hgquf", new ClassLibrary1.Image("ImageArc/mine.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc28);
                //Arc Arc29 = new Arc(NomArc.Zou, "hgquf", new ClassLibrary1.Image("ImageArc/zou.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc29);
                //Arc Arc30 = new Arc(NomArc.Whole_Cake, "hgquf", new ClassLibrary1.Image("ImageArc/whole.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc30);
                //Arc Arc31 = new Arc(NomArc.Reverie, "hgquf", new ClassLibrary1.Image("ImageArc/reverie.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc31);
                //Arc Arc32 = new Arc(NomArc.Wano_Kuni, "hgquf", new ClassLibrary1.Image("ImageArc/wano.png", "Luffy au début"));
                //Luffy.ListeArc.Add(Arc32);
                ListePerso.Add(Luffy);

            ListePerso.Add(new Personnage("coucuoc", "prenom", new Image()));

            return ListePerso;
        }

        public List<Haki> chargeHaki()
        {
            List<Haki> Hakis = new List<Haki>();
            Hakis.Add(new Haki(NomHaki.Haki_des_rois, "Pété de ouf"));
            Hakis.Add(new Haki(NomHaki.Haki_de_perception, "Bonne perception"));
            Hakis.Add(new Haki(NomHaki.Haki_du_renforcement, "Permet de se renforcé"));
            return Hakis;
        }
    }
}