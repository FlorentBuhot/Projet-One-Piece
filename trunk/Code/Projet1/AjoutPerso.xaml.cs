    using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary1;

namespace Projet1
{
    /// <summary>
    /// Logique d'interaction pour AjoutPerso.xaml
    /// </summary>
    public partial class AjoutPerso : UserControl
    {
        public Manager MonManager => (App.Current as App).MonManager;
        //Personnage NouveauPerso { get; set; }
        //ClassLibrary1.Image ImgBase { get; set; }
        public Navigator Navigator => (App.Current as App).Navigator;

        Personnage NouveauPerso = new Personnage();
        ClassLibrary1.Image ImgBase = new ClassLibrary1.Image();
        Appartennance appartenance = new Appartennance();

        private string filename;
        private string filesource;
        private string destinationsource = "Image/";
        public AjoutPerso()
        {
            InitializeComponent();
            
            DataContext = NouveauPerso;
        }

        private void Bouton_Parcourir(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.InitialDirectory = @"C:\Utilisateurs";
            dialog.FileName = "Image";
            dialog.DefaultExt = ".jpg | .png | .gif";

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                filesource = dialog.FileName;
                image_perso.Source = new BitmapImage(new Uri(filesource, UriKind.Absolute));
            }
            try
            {
                filename = "ImagePerso/" + new FileInfo(filesource).Name;
                destinationsource += filename;
                File.Copy(filesource, destinationsource, true);
            }
            catch (IOException exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message);
            }
        }
        private void ClickAnnuler(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ACCUEIL;
        }

        private void ClickAjouter(object sender, RoutedEventArgs e)
        {
            if(NouveauPerso.Age <= 0)
            {
                return;
            }
            if(haki_rois.IsChecked == true)
            {
                NouveauPerso.ListHaki.Add(MonManager.RechercherHaki(NomHaki.Haki_des_rois));
            }
            if (haki_obs.IsChecked == true)
            {
                NouveauPerso.ListHaki.Add(MonManager.RechercherHaki(NomHaki.Haki_de_perception));
            }
            if (haki_att.IsChecked == true)
            {
                NouveauPerso.ListHaki.Add(MonManager.RechercherHaki(NomHaki.Haki_du_renforcement));
            }
            if (arc0.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Colonel Morgan"));
            }
            if (arc1.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Baggy le clown"));
            }
            if (arc2.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Capitaine Kuro"));
            }
            if (arc3.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Baratie"));
            }
            if (arc4.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Arlong"));
            }
            if (arc5.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("LogueTown"));
            }
            if (arc6.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Laboon"));
            }
            if (arc7.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Whiskey Peak"));
            }
            if (arc8.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Little Garden"));
            }
            if (arc9.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Royaume de Drum"));
            }
            if (arc10.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Alabasta"));
            }
            if (arc11.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Jaya"));
            }
            if (arc12.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Skypiea"));
            }
            if (arc13.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Davy Back Fight"));
            }
            if (arc14.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Water Seven"));
            }
            if (arc15.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Enies Lobby"));
            }
            if (arc16.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Post Enies Lobby"));
            }
            if (arc17.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Thriller Bark"));
            }
            if (arc18.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Archipel Sabaody"));
            }
            if (arc19.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Amazon Lily"));
            }
            if (arc20.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Impel Down"));
            }
            if (arc21.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Marineford"));
            }
            if (arc22.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Post Marineford"));
            }
            if (arc23.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Retour a Sabaody"));
            }
            if (arc24.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Hommes Poissons"));
            }
            if (arc25.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Punk Hazard"));
            }
            if (arc26.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Dressrosa"));
            }
            if (arc27.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Mine Argentée"));
            }
            if (arc28.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Zou"));
            }
            if (arc29.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Whole Cake"));
            }
            if (arc30.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Reverie"));
            }
            if (arc31.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Wano Kuni"));
            }

            appartenance.Nom = appart.Text;
            appartenance.Description = appartDesc.Text;
            ImgBase.Source = filename;
            NouveauPerso.ImgBase = ImgBase;
            NouveauPerso.Appart = appartenance;
            MonManager.PersoAfficher = NouveauPerso;
            MonManager.AjouterPerso(NouveauPerso);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.PERSONNAGE;
            
        }
    }
}
