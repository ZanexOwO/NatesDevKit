using System;
using System.Collections.Generic;

namespace NatesLibary
{
    public static class Constants
    {
        /// <summary>
        /// %appdata% folder 
        /// </summary>
        internal static string AppFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + AppName;
        internal static string AppName = System.Reflection.Assembly.GetExecutingAssembly().ToString();

        /// <summary>
        /// Invisible String
        /// </summary>
        internal static string InvisbleString = "\u200b";
        /// <summary>
        /// World Currency Symbol
        /// </summary>
        internal static string EurosCurrecy = "€";
        internal static string PoundCurrency = "£";
        internal static string DollarCurrency = "$";
        internal static string ChinaCurrency = "¥";
        internal static string CzechRepublicCurrency = "Kč";
        internal static string IndiaCurrency = "₹";





    }
}
