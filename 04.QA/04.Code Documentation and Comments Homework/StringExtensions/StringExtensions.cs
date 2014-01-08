namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;


    /// <summary>
    /// Methods for working wiht string
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///   Convert strint to Md5Hash
        /// </summary>
        /// <param name="input"> Can be any string </param>
        /// <returns>Return Md4Hash representatin fo given string</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            var builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Convert strint to boolean value
        /// </summary>
        /// <param name="input"> Can be any string</param>
        /// <returns>
        /// Return boolean value true or false Depends of string is eqial to one
        /// of hardcoded values in var stringTrueValues[] 
        ///</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        ///   Parse string value to short 
        /// </summary>
        /// <param name="input"> Can be any string </param>
        /// <returns>Return short value parsed from given string</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        ///Parse string value to int 
        /// </summary>
        /// <param name="input">Can be any string</param>
        /// <returns>Return int value parsed from given string</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        ///Parse string value to long
        /// </summary>
        /// <param name="input">Can be any string</param>
        /// <returns>Return long value parsed from given string</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Parse string value to DateTime
        /// </summary>
        /// <param name="input"> Can be any string</param>
        /// <returns>Return DateTime value parsed from given string</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        ///   Capitalize first letter fo given string
        /// </summary>
        /// <param name="input">
        ///    Can be any string
        /// </param>
        /// <example>
        /// <code>
        ///   string str = "someString";
        ///   string result = CapitalizeFirstLetter(str);
        ///  </code>
        /// </example>
        /// <returns>
        /// Return new string wiht capitalized firs letter if the sting is not empty or null
        ///</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        ///  Get stirng between other strings given as parameters in given string
        /// </summary>
        /// <param name="input">Can be any string</param>
        /// <param name="startString">Star position of result begin after the end of this parame</param>
        /// <param name="endString">End position of result is before start of this parameter</param>
        /// <param name="startFrom"></param>
        /// <returns>String between startSting parameter and endString parameter</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Conver Cyrillic letters to Latin letters
        /// </summary>
        /// <param name="input">Can be any string</param>
        /// <returns>New string to Cirilic</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
            {
                "а", "б", "в", "г", "д", "е", "ж", "з",
                "и", "й", "к", "л", "м", "н", "о", "п",
                "р", "с", "т", "у", "ф", "х", "ц", "ч",
                "ш", "щ", "ъ", "ь", "ю", "я"
            };
            var latinRepresentationsOfBulgarianLetters = new[]
            {
                "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
            };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Convert Latin letterTo Cyrillic in coumpuret their keyboard representation
        /// </summary>
        /// <param name="input">Can be any string</param>
        /// <returns>Nwe string contains Cirillic letter on the keyboard of given string </returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
            {
                "a", "b", "c", "d", "e", "f", "g", "h",
                "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            var bulgarianRepresentationOfLatinKeyboard = new[]
            {
                "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                "в", "ь", "ъ", "з"
            };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// String whithout special characters
        /// </summary>
        /// <param name="input">Can be any string whitch containg @ example Pesho@-21</param>
        /// <returns>New string valid user name</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Convert sting to valid file name
        /// </summary>
        /// <param name="input">Can be any string whitch containg .(dot)and something afrer that for example снимка.пнг </param>
        /// <returns>New Sting whitch is valid file extention name</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Get first "charsCount" letter of given string 
        /// </summary>
        /// <param name="input">Can be any string</param>
        /// <param name="charsCount">Number of letters from start to end of string</param>
        /// <returns>New string contains letters form start of given string to "charsCount"</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Get extention of given file
        /// </summary>
        /// <param name="fileName">Can be any string whitch is valid file name example index.html</param>
        /// <returns>New string whith is extention of the file</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Conver string to content type
        /// </summary>
        /// <param name="fileExtension">Can be any string witch contains hardcoded file exetention for example pdf</param>
        /// <returns>Content type of given format</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
            {
                { "jpg", "image/jpeg" },
                { "jpeg", "image/jpeg" },
                { "png", "image/x-png" },
                {
                    "docx",
                    "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                },
                { "doc", "application/msword" },
                { "pdf", "application/pdf" },
                { "txt", "text/plain" },
                { "rtf", "application/rtf" }
            };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        ///  Convert given string to byte aray
        /// </summary>
        /// <param name="input">Can be any string</param>
        /// <returns>Return new sting whiht contain byte repesentatin of given string</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }

        public static void Main()
        {
           
        }
    }
}
