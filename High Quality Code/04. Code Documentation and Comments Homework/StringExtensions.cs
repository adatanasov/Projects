//-----------------------------------------------------------------------
// <summary>
// This is extension class for String objects.
// </summary>
// <copyright file="StringExtensions.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2013
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// This is the namespace for the extension class for String objects.
/// </summary>
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
    /// This is extension class for String objects.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// The method convert the input string to a byte array and compute the hash.
        /// Then loop through each byte of the hashed data and format each one as a hexadecimal string.
        /// </summary>
        /// <param name="input"> The input string. </param>
        /// <returns> The hexadecimal string. </returns>
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
        ///  Return true if the input string is in stringTrueValues array, which contains positive value strings.
        /// </summary>
        /// <param name="input"> The input string. </param>
        /// <returns> Boolean value. </returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// This method converts the input string into short variable.
        /// </summary>
        /// <param name="input"> The input string. </param>
        /// <returns> The short value OR 0 if the string can't be converted. </returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// The method converts the input string into integer value.
        /// </summary>
        /// <param name="input"> The input string. </param>
        /// <returns> The integer value OR 0 if the string can't be converted. </returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// The method converts the input string into long value.
        /// </summary>
        /// <param name="input"> The input string. </param>
        /// <returns> The long value OR 0L if the string can't be converted. </returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// The method converts the input string into DateTime value.
        /// </summary>
        /// <param name="input"> The input string. </param>
        /// <returns> The DateTime value OR 1.1.0001. 00:00:00 if the string can't be converted. </returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// The method makes the first letter of the input string a capital.
        /// </summary>
        /// <param name="input"> The input string. </param>
        /// <returns> The input string with capital first letter
        /// OR null if the input string is null OR empty string if the input string is empty. </returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// This method return the substring between the two given border strings.
        /// </summary>
        /// <param name="input"> The input string. </param>
        /// <param name="startString"> The left border string. </param>
        /// <param name="endString"> The right border string. </param>
        /// <param name="startFrom"> The position from which we search in the input string. </param>
        /// <returns> The string between startString and endString. </returns>
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
        /// This method modifies the cyrillic letters into latin ones.
        /// </summary>
        /// <param name="input"> The input string with cyrillic letters. </param>
        /// <returns> The result string with latin letters. </returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                {
                    "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                    "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
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
        /// This method modifies the latin letters into cyrillic ones.
        /// </summary>
        /// <param name="input"> The input string with latin letters. </param>
        /// <returns> The result string with cyrillic letters. </returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                {
                    "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
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
        /// The method converts the input string's cyrillic letter with latin and 
        /// removes everything except letters, digits, underscore and dot.
        /// </summary>
        /// <param name="input"> The input string. </param>
        /// <returns> The string with only latin letters, digits, underscore and dot. </returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// The method converts whitespace from the input string into dash,
        /// the input string's cyrillic letter into latin and 
        /// removes everything except letters, digits, underscore, dot and dash.
        /// </summary>
        /// <param name="input"> The input string. </param>
        /// <returns> The string with only latin letters, digits, underscore, dot and dash. </returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// The method returns the first chars from the input string with length charsCount.
        /// </summary>
        /// <param name="input"> The input string. </param>
        /// <param name="charsCount"> The length of the first chars, which we want.</param>
        /// <returns> The first chars from the input string with length charsCount 
        /// OR the whole string if charsCount is bigger than input string's length. </returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// The method returns the part of the string after the last dot.
        /// </summary>
        /// <param name="fileName"> The input string. </param>
        /// <returns> The file extension OR 
        /// empty string if there is no input string or no dot in the it. </returns>
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
        /// The method converts file extension into what type it is.
        /// </summary>
        /// <param name="fileExtension"> The input string. </param>
        /// <returns> The converted extension OR
        /// "application/octet-stream" if the extension is not in the list. </returns>
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
        /// The method converts the input string into byte array.
        /// </summary>
        /// <param name="input"> The input string. </param>
        /// <returns> The converted byte array. </returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
