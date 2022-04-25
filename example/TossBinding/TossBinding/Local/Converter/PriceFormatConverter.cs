﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace TossBinding.Local.Converter
{
    public class PriceFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int price = (int)value;

            return $"{price.ToString("N0")}원";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
