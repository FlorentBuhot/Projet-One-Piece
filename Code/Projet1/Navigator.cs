using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;


namespace Projet1
{
    public class Navigator : INotifyPropertyChanged
    {
        public enum EtatUC
        {
            ACCUEIL,
            AJT_IMG_PERSO,
            ARC,
            PERSONNAGE,
            AJT_IMG_ARC,
            AJT_PERSO
        }

        private EtatUC etatEnCours = EtatUC.ACCUEIL;
        public EtatUC EtatEnCours
        {
            get => etatEnCours;
            set
            {
                if(value != etatEnCours)
                {
                    etatEnCours = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
