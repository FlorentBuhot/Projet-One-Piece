using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Data;
using System.Windows.Controls;
using System.Diagnostics;

namespace Projet1
{
    class StringToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string nomImage = (value as string);
            if (string.IsNullOrWhiteSpace(nomImage)) return null;
            Debug.WriteLine(Directory.GetCurrentDirectory());
            string dossierImage = Path.Combine(Directory.GetCurrentDirectory(), "../Image");
            string cheminImage = Path.Combine(dossierImage, nomImage);
            return new Uri(cheminImage, UriKind.RelativeOrAbsolute);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
