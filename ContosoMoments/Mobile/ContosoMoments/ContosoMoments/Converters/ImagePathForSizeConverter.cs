﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ContosoMoments.Converters
{
    public class ImagePathForSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string param = (string)parameter;
            IDictionary<string, Uri> imagePaths = (IDictionary<string, Uri>)value;
            ImageSource retVal = null;

            if (null != imagePaths)
            {
                if (imagePaths.ContainsKey(param))
                    retVal = ImageSource.FromUri(imagePaths[param]);
            }

            return retVal;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
