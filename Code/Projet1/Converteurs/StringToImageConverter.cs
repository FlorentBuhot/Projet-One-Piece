using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Data;
using System.Windows.Controls;

namespace Projet1
{
    class StringToImageConverter : IValueConverter
    {
        private static string imagesPath;

        static StringToImageConverter()
        {
            imagesPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\Image\\");
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imageName = value as string;
            if (string.IsNullOrWhiteSpace(imageName)) return null;

            string imagePath = Path.Combine(imagesPath, imageName);

            return new Uri(imagePath, UriKind.RelativeOrAbsolute);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
