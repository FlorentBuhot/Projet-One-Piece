using System;
using System.Collections.Generic;
using System.Diagnostics;
using ClassLibrary1;

namespace Stub
{
    public class Stub : IPersistanceManager
    {
        public void SauvegardeDonnees(IEnumerable<Personnage> personnages, IEnumerable<Arc> arcs, IEnumerable<Haki> hakis)
        {
            Debug.WriteLine("Sauvegarde damandé");
        }


        /// <summary>
        /// Ici on est obligé d'instancier les différent personnages pour qu'ils soient visible dans la création des arcs.
        /// Puis on fini de compléter les personnages car nous avons besoin des informations des arcs que nous venons de créer
        /// </summary>
        /// <returns></returns>
        public (IEnumerable<Personnage> personnages, IEnumerable<Arc> arcs, IEnumerable<Haki> hakis) ChargeDonnees()
        {
            Personnage Luffy = new Personnage();
            Luffy.ImgBase = new ClassLibrary1.Image("ImagePerso/luffy_sourire.png", "Luffy heureux");
            Personnage Zoro = new Personnage();
            Zoro.ImgBase = new ClassLibrary1.Image("ImagePerso/zoro_sourire.jpg", "Zoro heureux");
            Personnage Sanji = new Personnage();
            Sanji.ImgBase = new ClassLibrary1.Image("ImagePerso/sanji_sourire.jpg", "Sanji heureux");
            Personnage Doflamingo = new Personnage();
            Doflamingo.ImgBase = new ClassLibrary1.Image("ImagePerso/doflamingo_content.jpeg", "Doflamingo content");

            List<Arc> ListeArc = new List<Arc>();
            Arc Arc1 = new Arc("Colonel Morgan", "Première arc de One Piece", new ClassLibrary1.Image("/ImageArc/morgan.png", "Le colonel Morgan"), new List<Personnage> {Luffy});
            ListeArc.Add(Arc1);
            Arc Arc2 = new Arc("Baggy le clown", "Deuxième arc de One Piece", new ClassLibrary1.Image("/ImageArc/baggy.png", "Le colonel Morgan"), new List<Personnage> {Luffy});
            ListeArc.Add(Arc2);
            Arc Arc3 = new Arc("Capitaine Kuro", "Troisième arc de One Piece", new ClassLibrary1.Image("ImageArc/kuro.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc3);     
            Arc Arc4 = new Arc("Baratie", "Quatrième arc de One Piece", new ClassLibrary1.Image("ImageArc/baratie.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc4);
            Arc Arc5 = new Arc("Arlong", "Cinquième arc de One Piece", new ClassLibrary1.Image("ImageArc/arlong.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc5);
            Arc Arc6 = new Arc("LogueTown", "Sixième arc de One Piece", new ClassLibrary1.Image("ImageArc/loguetown.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc6);
            Arc Arc7 = new Arc("Laboon", "Septième arc de One Piece", new ClassLibrary1.Image("ImageArc/laboon.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc7);
            Arc Arc8 = new Arc("Whiskey Peak", "Huitième arc de One Piece", new ClassLibrary1.Image("ImageArc/whiskey.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc8);
            Arc Arc9 = new Arc("Little Garden", "Neuvième arc de One Piece", new ClassLibrary1.Image("ImageArc/garden.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc9);
            Arc Arc10 = new Arc("Royaume de Drum", "Dixième arc de One Piece", new ClassLibrary1.Image("ImageArc/drum.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc10);
            Arc Arc11 = new Arc("Alabasta", "Onzième arc de One Piece", new ClassLibrary1.Image("ImageArc/alabasta.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc11);
            Arc Arc12 = new Arc("Jaya", "Douzième arc de One Piece", new ClassLibrary1.Image("ImageArc/jaya.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc12);
            Arc Arc13 = new Arc("Skypiea", "Treizième arc de One Piece", new ClassLibrary1.Image("ImageArc/skypiea.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc13);
            Arc Arc14 = new Arc("Davy Back Fight", "Quatorzième arc de One Piece", new ClassLibrary1.Image("ImageArc/davy.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc14);
            Arc Arc15 = new Arc("Water Seven", "Quinzième arc de One Piece", new ClassLibrary1.Image("ImageArc/water.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc15);
            Arc Arc16 = new Arc("Enies Lobby", "Seizième arc de One Piece", new ClassLibrary1.Image("ImageArc/enies.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc16);
            Arc Arc17 = new Arc("Post Enies Lobby", "Dix Septième arc de One Piece", new ClassLibrary1.Image("ImageArc/post_enies.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc17);
            Arc Arc18 = new Arc("Thriller Bark", "Dix Huitième arc de One Piece", new ClassLibrary1.Image("ImageArc/thriller.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc18);
            Arc Arc19 = new Arc("Archipel Sabaody", "Dix Neuvième arc de One Piece", new ClassLibrary1.Image("ImageArc/sabaody.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc19);
            Arc Arc20 = new Arc("Amazon Lily", "Vingtième arc de One Piece", new ClassLibrary1.Image("ImageArc/amazon.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc20);
            Arc Arc21 = new Arc("Impel Down", "Vingt et unième arc de One Piece", new ClassLibrary1.Image("ImageArc/impel.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc21);
            Arc Arc22 = new Arc("Marineford", "Vingt Deuxième arc de One Piece", new ClassLibrary1.Image("ImageArc/marineford.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc22);
            Arc Arc23 = new Arc("Post Marineford", "Vingt Troisième arc de One Piece", new ClassLibrary1.Image("ImageArc/post_marineford.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc23);
            Arc Arc24 = new Arc("Retour a Sabaody", "Vingt Quatrième arc de One Piece", new ClassLibrary1.Image("ImageArc/retour.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc24);
            Arc Arc25 = new Arc("Hommes Poissons", "Vingt Cinquième arc de One Piece", new ClassLibrary1.Image("ImageArc/hommes.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc25);
            Arc Arc26 = new Arc("Punk Hazard", "Vingt Sizième arc de One Piece", new ClassLibrary1.Image("ImageArc/punk.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc26);
            Arc Arc27 = new Arc("Dressrosa", "Vingt Septième arc de One Piece", new ClassLibrary1.Image("ImageArc/dressrosa.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc27);
            Arc Arc28 = new Arc("Mine Argentée", "Vingt Huitième arc de One Piece", new ClassLibrary1.Image("ImageArc/mine.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc28);
            Arc Arc29 = new Arc("Zou", "Vingt Neuvième arc de One Piece", new ClassLibrary1.Image("ImageArc/zou.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc29);
            Arc Arc30 = new Arc("Whole Cake", "Trentième arc de One Piece", new ClassLibrary1.Image("ImageArc/whole.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc30);
            Arc Arc31 = new Arc("Reverie", "Trente et unième arc de One Piece", new ClassLibrary1.Image("ImageArc/reverie.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc31);
            Arc Arc32 = new Arc("Wano Kuni", "Trente Deuxième arc de One Piece", new ClassLibrary1.Image("ImageArc/wano.png", "Luffy au début"), new List<Personnage> { Luffy });
            ListeArc.Add(Arc32);


            List<Haki> ListHaki = new List<Haki>();
            Haki HakiRoi = new Haki(NomHaki.Haki_des_rois, "Pété de ouf");
            ListHaki.Add(HakiRoi);
            Haki HakiPers = new Haki(NomHaki.Haki_de_perception, "Bonne perception");
            ListHaki.Add(HakiPers);
            Haki HakiRenfo = new Haki(NomHaki.Haki_du_renforcement, "Permet de se renforcé");
            ListHaki.Add(HakiRenfo);

            List<Personnage> ListePerso = new List<Personnage>();


            Luffy.Prénom = "Luffy";
            Luffy.Nom = "Monkey D.";
            Luffy.Info = "Monkey D. Luffy (モンキー・Ｄディー・ルフィ, Monkī Dī Rufi) est un pirate et le principal protagoniste du manga et anime One Piece. Luffy est le fils du chef de l'Armée Révolutionnaire, Monkey D. Dragon, le petit-fils du célèbre Vice-Amiral de la Marine, Monkey D. Garp, le fils adoptif d'une bandit des montagnes, Curly Dadan ainsi que le frère adoptif du défunt Portgas D. Ace et de Sabo. Son rêve le plus cher est de devenir le Seigneur des Pirates en trouvant le trésor légendaire One Piece, caché quelque part dans le monde par Gol D. Roger. Selon lui, être le Seigneur des Pirates signifie être celui qui jouit d'une liberté sans pareille dans le monde. Il a mangé un Fruit du Démon : le Gomu Gomu no Mi, qui a été rapporté lors d'un voyage par L'Équipage du Roux au Village de Fuchsia, à ce moment là. En tant que fondateur et Capitaine de l'Équipage du Chapeau de Paille, il est le premier membre à en faire partie, ainsi que l'un des trois combattants les plus forts de ce dernier, s'il n'est le plus fort. C'est également le fondateur involontaire de La Grande Flotte du Chapeau de Paille, il refuse cependant d'en être le Capitaine, ne désirant pas priver les autres de leur liberté. Luffy a une réputation mondiale pour avoir causé des troubles et des catastrophes, même parmi les 7 Capitaines Corsaires et la Marine, en étant allé jusqu'à défier deux des Quatre Empereurs (Big Mom et Kaidô), ainsi qu'en commettant des crimes et actions considérées comme dangereuses par le Gouvernement Mondial. Il a reçu la réputation d'être \"téméraire\" et \"fou\", dans certains cas. Il est, en effet, célèbre pour avoir fait brûler le drapeau du Gouvernement Mondial à Enies Lobby (il s'agissait d'un ordre donné à Sogeking), avant d'y vaincre le CP9 avec son équipage; avoir frappé un Dragon Céleste à Sabaody; vaincu plusieurs des 7 Grands Corsaires (Crocodile, Gecko Moria ou Doflamingo); s'être infiltré et échappé d'Impel Down en y causant une gigantesque évasion (la plus grande de l'histoire de la prison); et s'être joint à la Bataille de Marine Ford, du côté de l'Équipage de Barbe Blanche. De plus, il est connu pour être le seul pirate à s'être non seulement infiltré dans les trois installations capitales du Gouvernement, mais aussi pour s'être échappé vivant de toutes les trois. Ce passé de fauteur de troubles valut rapidement à Luffy le qualificatif \"d\'élément dangereux dans le futur\", notamment pour l\'Amiral Commandant en Chef Sakazuki, faisant de la Marine l\'un de ses plus grands ennemis. Luffy est réputé pour porter son Chapeau de Paille (d'où son épithète \"Luffy au Chapeau de Paille\") que le légendaire capitaine pirate Shanks \"le Roux\" lui a confié lorsqu'il était jeune, ce dernier le tenant lui-même de Roger. Luffy a également une cicatrice avec deux points de suture sous son œil gauche (blessure qu'il s'est lui-même infligée avec un couteau sous l’œil pour prouver son courage à Shanks), et des cheveux noirs assez courts. Similaire à la plupart des hommes de son équipage, Luffy porte la plupart du temps les mêmes vêtements, à l'opposé du reste de l'équipage (spécialement Nami et Nico Robin), qui quant à elles, changent fréquemment de tenues. Quel que soit l'endroit où il se trouve, Luffy porte en toutes circonstances son Chapeau de Paille, même si au début, le chapeau pouvait facilement tomber de sa tête, car instable, ce qui forçait Luffy à le mettre de côté, ou à demander à quelqu'un de le tenir pour lui (le plus souvent à Nami). Il porte des pantalons courts ainsi que des sandales et une veste rouge sans manches. Ayant l'air un peu maigre sous sa chemise, il a pourtant un physique étonnamment bien bâti. Il est assez petit, éclipsé par beaucoup de personnages de la série plus grands.";
            Luffy.Age = 18;

            Luffy.ListHaki.Add(ListHaki[ListHaki.IndexOf(HakiRoi)]);
            Luffy.ListHaki.Add(ListHaki[ListHaki.IndexOf(HakiPers)]);
            Luffy.ListHaki.Add(ListHaki[ListHaki.IndexOf(HakiRenfo)]);

            Appartennance LuffyAppart = new Appartennance("Pirate au Chapeau de Paille", "Equipage trop fort");
            Luffy.Appart = LuffyAppart;

            ClassLibrary1.Image ImageL1 = new ClassLibrary1.Image("ImagePerso/ancien_luffy.png", "Luffy a Sabaody");
            ClassLibrary1.Image ImageL2 = new ClassLibrary1.Image("ImagePerso/gear4_luffy.png", "Le fameux Gear 4");
            ClassLibrary1.Image ImageL3 = new ClassLibrary1.Image("ImagePerso/luffy_petit.png", "Luffy enfant");
            ClassLibrary1.Image ImageL4 = new ClassLibrary1.Image("ImagePerso/luffy_po_content.png", "Luffy énervé");
            ClassLibrary1.Image ImageL5 = new ClassLibrary1.Image("ImagePerso/luffy_drame.png", "Luffy avant la tempete");
            ClassLibrary1.Image ImageL6 = new ClassLibrary1.Image("ImagePerso/luffy_capitaine.jpg", "Luffy le capitaine");
            ClassLibrary1.Image ImageL7 = new ClassLibrary1.Image("ImagePerso/luffy_sourire.png", "Luffy heureux");

            Luffy.SourceImgPerso.Add(ImageL1);
            Luffy.SourceImgPerso.Add(ImageL2);
            Luffy.SourceImgPerso.Add(ImageL3);
            Luffy.SourceImgPerso.Add(ImageL4);
            Luffy.SourceImgPerso.Add(ImageL5);
            Luffy.SourceImgPerso.Add(ImageL6);
            Luffy.SourceImgPerso.Add(ImageL7);


            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc1)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc2)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc3)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc4)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc5)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc6)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc7)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc8)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc9)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc10)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc11)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc12)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc13)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc14)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc15)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc16)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc17)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc18)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc19)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc20)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc21)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc22)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc23)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc24)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc25)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc26)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc27)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc28)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc29)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc30)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc31)]);
            Luffy.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc32)]);

            ListePerso.Add(Luffy);

            Zoro.Prénom = "Zoro";
            Zoro.Nom = "Roronoa";
            Zoro.Info = "Sabreur a 3 sabres";
            Zoro.Age = 20;

            Zoro.ListHaki.Add(ListHaki[ListHaki.IndexOf(HakiRoi)]);
            Zoro.ListHaki.Add(ListHaki[ListHaki.IndexOf(HakiPers)]);
            Zoro.ListHaki.Add(ListHaki[ListHaki.IndexOf(HakiRenfo)]);

            Appartennance ZoroAppart = new Appartennance("Pirate au Chapeau de Paille", "Equipage trop fort");
            Zoro.Appart = ZoroAppart;

            ClassLibrary1.Image ImageZ1 = new ClassLibrary1.Image("ImagePerso/zoro_sourire.jpg", "Zoro content");
            ClassLibrary1.Image ImageZ2 = new ClassLibrary1.Image("ImagePerso/zoro_jeune.jpg", "Zoro jeune");
            ClassLibrary1.Image ImageZ3 = new ClassLibrary1.Image("ImagePerso/zoro_bandana.jpeg", "Zoro et son bandana");
            ClassLibrary1.Image ImageZ4 = new ClassLibrary1.Image("ImagePerso/zoro_sabre_bouche.jpg", "Zoro énervé");

            Zoro.SourceImgPerso.Add(ImageZ1);
            Zoro.SourceImgPerso.Add(ImageZ2);
            Zoro.SourceImgPerso.Add(ImageZ3);
            Zoro.SourceImgPerso.Add(ImageZ4);

            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc1)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc2)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc3)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc4)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc5)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc6)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc7)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc8)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc9)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc10)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc11)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc12)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc13)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc14)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc15)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc16)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc17)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc18)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc19)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc20)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc21)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc22)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc23)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc24)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc25)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc26)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc27)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc28)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc29)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc30)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc31)]);
            Zoro.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc32)]);

            ListePerso.Add(Zoro);

            Sanji.Prénom = "Sanji";
            Sanji.Nom = "Vinsmoke";
            Sanji.Info = "Cuisinier du chapeau de paille";
            Sanji.Age = 20;

            Sanji.ListHaki.Add(ListHaki[ListHaki.IndexOf(HakiPers)]);
            Sanji.ListHaki.Add(ListHaki[ListHaki.IndexOf(HakiRenfo)]);

            Appartennance SanjiAppart = new Appartennance("Pirate au Chapeau de Paille", "Equipage trop fort");
            Sanji.Appart = SanjiAppart;

            ClassLibrary1.Image ImageS1 = new ClassLibrary1.Image("ImagePerso/sanji_sourire.jpg", "Sanji content");
            ClassLibrary1.Image ImageS2 = new ClassLibrary1.Image("ImagePerso/sanji_jeune.jpg", "Sanji jeune");
            ClassLibrary1.Image ImageS3 = new ClassLibrary1.Image("ImagePerso/sanji_enerve.jpg", "Sanji enervé");
            ClassLibrary1.Image ImageS4 = new ClassLibrary1.Image("ImagePerso/sanji_heros.jpg", "Sanji héroique");

            Sanji.SourceImgPerso.Add(ImageS1);
            Sanji.SourceImgPerso.Add(ImageS2);
            Sanji.SourceImgPerso.Add(ImageS3);
            Sanji.SourceImgPerso.Add(ImageS4);

            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc4)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc5)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc6)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc7)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc8)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc9)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc10)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc11)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc12)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc13)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc14)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc15)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc16)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc17)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc18)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc19)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc20)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc21)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc22)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc23)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc24)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc25)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc26)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc27)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc28)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc29)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc30)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc31)]);
            Sanji.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc32)]);

            ListePerso.Add(Sanji);

            Doflamingo.Prénom = "Doflamingo";
            Doflamingo.Nom = "Don Quijotte";
            Doflamingo.Info = "Ancien grand corsaire";
            Doflamingo.Age = 41;

            Doflamingo.ListHaki.Add(ListHaki[ListHaki.IndexOf(HakiRoi)]);
            Doflamingo.ListHaki.Add(ListHaki[ListHaki.IndexOf(HakiPers)]);
            Doflamingo.ListHaki.Add(ListHaki[ListHaki.IndexOf(HakiRenfo)]);

            Appartennance DoflaAppart = new Appartennance("Don Quichotte Family", "Ancien équipage de grand corsaire");
            Doflamingo.Appart = DoflaAppart;

            ClassLibrary1.Image ImageD1 = new ClassLibrary1.Image("ImagePerso/doflamingo_content.jpeg", "Doflamingo content");
            ClassLibrary1.Image ImageD2 = new ClassLibrary1.Image("ImagePerso/doflamingo_jeune.jpg", "Doflamingo jeune");
            ClassLibrary1.Image ImageD3 = new ClassLibrary1.Image("ImagePerso/doflamingo_enerve.png", "Doflamingo enervé");

            Doflamingo.SourceImgPerso.Add(ImageD1);
            Doflamingo.SourceImgPerso.Add(ImageD2);
            Doflamingo.SourceImgPerso.Add(ImageD3);

            Doflamingo.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc12)]);
            Doflamingo.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc21)]);
            Doflamingo.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc22)]);
            Doflamingo.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc26)]);
            Doflamingo.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc27)]);
            Doflamingo.ListeArc.Add(ListeArc[ListeArc.IndexOf(Arc31)]);

            ListePerso.Add(Doflamingo);

            return (ListePerso, ListeArc, ListHaki);
        }
    }
}
