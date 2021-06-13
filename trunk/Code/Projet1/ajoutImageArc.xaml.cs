﻿using System;
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
    /// Logique d'interaction pour ajoutImageArc.xaml
    /// </summary>
    public partial class ajoutImageArc : UserControl
    {
        Manager MonManager => (App.Current as App).MonManager;
        ClassLibrary1.Image NouvelleImage { get; set; }

        private string filename;
        private string filesource;
        private string destinationsource = @"../Image/";
        public ajoutImageArc()
        {
            InitializeComponent();
            NouvelleImage = new ClassLibrary1.Image();
            DataContext = NouvelleImage;
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
                image_Arc.Source = new BitmapImage(new Uri(filesource, UriKind.Absolute));
            }
            try
            {
                filename = "ImageArc/" + new FileInfo(filesource).Name;
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
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }

        private void ClickAjouter(object sender, RoutedEventArgs e)
        {
            NouvelleImage.Source = filename;
            MonManager.AjouterImgArc(NouvelleImage, MonManager.ArcAfficher);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
    }
}
