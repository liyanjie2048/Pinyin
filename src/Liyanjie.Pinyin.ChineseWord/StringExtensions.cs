using System.Linq;

namespace System
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// 获取拼音
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[] GetPinyin(this string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.Length == 0)
                return default;

            if (Liyanjie.Pinyin.ChineseWord.ChineseWordHelper.TryGetPinyin(input, out var pinyin))
                return pinyin;
            else
                return input.Select(_ => _.GetPinyins()[0]).ToArray();
        }
    }
}
