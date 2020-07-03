using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MediaPanther.Framework
{
    public class Common
    {
        #region public static methods
        
        #region collections
        /// <summary>
        /// Converts a comma-seperated-value list into an untyped collection, ready for processing.
        /// </summary>
        /// <param name="csv">The delimited string representing the items.</param>
        /// <param name="delimiter">The character that delimits the entries, normally a comma.</param>
        public static ArrayList CsvToArray(string csv, string delimiter)
        {
            csv = csv.Trim();
            if (csv.Length == 0)
                return null;

            ArrayList array = new ArrayList();
            foreach (string element in csv.Split(char.Parse(delimiter)))
                array.Add(element.Trim());

            return array;
        }

        /// <summary>
        /// Converts an array of string elements into a comma-seperated list of values.
        /// </summary>
        /// <param name="collection">The string-valued collection to serialise.</param>
        /// <param name="delimiter">The character(s) to use as a delimiter. If a regular CSV id desired, then include a trailing space to english-format the result.</param>
        public static string ArrayToCsv(ArrayList collection, string delimiter)
        {
            if (collection == null)
                return String.Empty;

            StringBuilder csv = new StringBuilder();
            for (int i = 0; i < collection.Count; i++)
            {
                csv.Append(collection[i] as string);

                if (i < (collection.Count - 1))
                    csv.Append(delimiter);
            }

            return csv.ToString();
        }
        #endregion

        /// <summary>
        /// Converts a DateTime to the common RFC#822 format, used for Email and RSS.
        /// </summary>
        public static string DateTimeToRfc822(DateTime timeToConvert)
        {
            return timeToConvert.ToString("r");
        }

        /// <summary>
        /// Determines whether or not a mime type is an acceptable image to show in a browser.
        /// </summary>
        /// <param name="mimeType">The full mime-type declaration, i.e. 'image/jpeg'.</param>
        public static bool IsMimeTypeWebImage(string mimeType)
        {
            // there is a System.Net.Mime namespace to extend this, but this needn't be complicated right now.
            if (mimeType.Trim() == String.Empty)
                return false;

            string[] parts = mimeType.Split(char.Parse("/"));
            if (parts[0].ToLower() == "image")
            {
                string format = parts[1].ToLower();
                if (format == "jpeg" || format == "jpg" || format == "gif" || format == "png")
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Validates a UK postal-code.
        /// </summary>
        public static bool IsPostCode(string postCode) 
        {
            return Regex.IsMatch(postCode, "^([A-PR-UWYZ0-9][A-HK-Y0-9][ABCDEFGHJKSTUW0-9]?[ABEHMNPRVWXY0-9]? {1,2}[0-9][ABD-HJLNP-UW-Z]{2}|GIR0AA)$");
        }
        
        /// <summary>
        /// Tests to see if a string numeral is a valid integer.
        /// </summary>
        public static bool IsNumeric(string numeral) 
        {
            try
            {
                int number = int.Parse(numeral);
                return true;
            }
            catch
            {
            }

            return false;
        }
        
        /// <summary>
        /// Performs a check to see if an input string matches the format for an Email address.
        /// </summary>
        public static bool IsEmail(string email) 
        {
            return Regex.IsMatch(email, "\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
        }
        
        /// <summary>
        /// Performs a check to see if an input string matches the format for a valid date.
        /// </summary>
        public static bool IsDate(string date) 
        {
            try
            {
                DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        /// <summary>
        /// Performs a check to see if an input string matches the format for a valid Guid.
        /// </summary>
        public static bool IsGuid(string guid) 
        {
            Guid guid1;
            bool flag1;

            try
            {
                guid1 = new Guid(guid);
                flag1 = true;
            }
            catch
            {
                flag1 = false;
            }

            return flag1;
        } 
        #endregion
    }
}