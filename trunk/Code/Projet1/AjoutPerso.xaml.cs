    using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Navigator Navigator => (App.Current as App).Navigator;

        Personnage NouveauPerso = new Personnage();
        ClassLibrary1.Image ImgBase = new ClassLibrary1.Image();
        Appartennance appartenance = new Appartennance();
        int nbArc = 0;

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
                nbArc++;
            }
            if (arc1.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Baggy le clown"));
                nbArc++;
            }
            if (arc2.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Capitaine Kuro"));
                nbArc++;
            }
            if (arc3.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Baratie"));
                nbArc++;
            }
            if (arc4.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Arlong"));
                nbArc++;
            }
            if (arc5.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("LogueTown"));
                nbArc++;
            }
            if (arc6.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Laboon"));
                nbArc++;
            }
            if (arc7.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Whiskey Peak"));
                nbArc++;
            }
            if (arc8.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Little Garden"));
                nbArc++;
            }
            if (arc9.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Royaume de Drum"));
                nbArc++;
            }
            if (arc10.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Alabasta"));
                nbArc++;
            }
            if (arc11.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Jaya"));
                nbArc++;
            }
            if (arc12.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Skypiea"));
                nbArc++;
            }
            if (arc13.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Davy Back Fight"));
                nbArc++;
            }
            if (arc14.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Water Seven"));
                nbArc++;
            }
            if (arc15.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Enies Lobby"));
                nbArc++;
            }
            if (arc16.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Post Enies Lobby"));
                nbArc++;
            }
            if (arc17.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Thriller Bark"));
                nbArc++;
            }
            if (arc18.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Archipel Sabaody"));
                nbArc++;
            }
            if (arc19.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Amazon Lily"));
                nbArc++;
            }
            if (arc20.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Impel Down"));
                nbArc++;
            }
            if (arc21.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Marineford"));
                nbArc++;
            }
            if (arc22.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Post Marineford"));
                nbArc++;
            }
            if (arc23.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Retour a Sabaody"));
                nbArc++;
            }
            if (arc24.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Hommes Poissons"));
                nbArc++;
            }
            if (arc25.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Punk Hazard"));
                nbArc++;
            }
            if (arc26.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Dressrosa"));
                nbArc++;
            }
            if (arc27.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Mine Argentée"));
                nbArc++;
            }
            if (arc28.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Zou"));
                nbArc++;
            }
            if (arc29.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Whole Cake"));
                nbArc++;
            }
            if (arc30.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Reverie"));
                nbArc++;
            }
            if (arc31.IsChecked == true)
            {
                NouveauPerso.ListeArc.Add(MonManager.RechercherArc("Wano Kuni"));
                nbArc++;
            }
            if(nbArc == 0)
            {
                MessageBox.Show("Vous n'avez pas séléctionné d'arc", "Erreur de saisie");
                return;
            }

            if(string.IsNullOrEmpty(NouveauPerso.Nom) ||
               string.IsNullOrEmpty(NouveauPerso.Prénom) ||
               string.IsNullOrEmpty(appart.Text) ||
               string.IsNullOrEmpty(appartDesc.Text) ||
               NouveauPerso.Age <= 0)
            {
                MessageBox.Show("Les valeurs suivantes sont obligatoir : \n" +
                                "Nom du personnage, Prénom du personnage , Nom de l'appartenance, Description de l'appartenance et l'age doit être supérieur à 0",
                                "Erreur de saisie");
                return;
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
