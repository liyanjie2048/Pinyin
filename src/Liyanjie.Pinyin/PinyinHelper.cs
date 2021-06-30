using System;
using System.Linq;

using JiebaNet.Segmenter;

namespace Liyanjie.Pinyin
{
    public class PinyinHelper
    {
        public static string[] GetPinyin(string sentence)
        {
            return new JiebaSegmenter().Cut(sentence).SelectMany(_ => _.GetPinyin()).ToArray();
        }
    }
}
