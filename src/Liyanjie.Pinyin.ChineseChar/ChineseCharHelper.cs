using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Liyanjie.Pinyin.ChineseChar
{
    public class ChineseCharHelper
    {
        static readonly Dictionary<char, (string, string[])> chineseChars;

        static ChineseCharHelper()
        {
            chineseChars = new();
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Liyanjie.Pinyin.ChineseChar.ChineseChars.txt");
            using var reader = new StreamReader(stream, Encoding.UTF8);
            while (true)
            {
                var @string = reader.ReadLine();
                if (string.IsNullOrEmpty(@string))
                    break;
                if (@string.StartsWith("#"))
                    continue;

                var array = @string.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (chineseChars.ContainsKey(array[3][0]))
                    continue;

                chineseChars.Add(array[3][0], (array[0].TrimEnd(':'), array[1].Split(',')));
            }
        }

        public static IReadOnlyDictionary<char, (string Code, string[] Pinyins)> ChineseChars => chineseChars;

        public static string[] GetPinyins(char chineseChar)
        {
            return ChineseChars.ContainsKey(chineseChar)
                ? ChineseChars[chineseChar].Pinyins
                : new[] { "*" };
        }
    }
}
