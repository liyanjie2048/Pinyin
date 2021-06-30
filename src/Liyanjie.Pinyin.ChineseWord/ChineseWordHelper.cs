using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Liyanjie.Pinyin.ChineseWord
{
    public class ChineseWordHelper
    {
        static readonly Dictionary<string, string[]> chineseWords;

        static ChineseWordHelper()
        {
            chineseWords = new();
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Liyanjie.Pinyin.ChineseWord.ChineseWords.txt");
            using var reader = new StreamReader(stream, Encoding.UTF8);
            while (true)
            {
                var @string = reader.ReadLine();
                if (string.IsNullOrEmpty(@string))
                    break;
                if (@string.StartsWith("#"))
                    continue;

                var array = @string.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                if (chineseWords.ContainsKey(array[0]))
                    continue;
                chineseWords.Add(array[0], array[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            }
        }

        public static IReadOnlyDictionary<string, string[]> ChineseWords => chineseWords;

        public static bool TryGetPinyin(string chineseWord, out string[] pinyin)
        {
            if (ChineseWords.ContainsKey(chineseWord))
            {
                pinyin = ChineseWords[chineseWord];
                return true;
            }
            else
            {
                pinyin = default;
                return false;
            }
        }
    }
}
