using System;
using System.Linq;

using JiebaNet.Segmenter;

namespace Liyanjie.Pinyin
{
    public class PinyinHelper
    {
        public static string[] GetPinyin(string input)
        {
            return new JiebaSegmenter().Cut(input).SelectMany(_ => _.GetPinyin()).ToArray();
        }
    }
}
