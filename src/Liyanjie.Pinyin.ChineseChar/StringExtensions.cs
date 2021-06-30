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
        public static string[] GetPinyins(this char input)
        {
            if ((input > 47 && input < 58) || (input > 64 && input < 91) || (input > 96 && input < 123))
                return new[] { input.ToString() };

            return Liyanjie.Pinyin.ChineseChar.ChineseCharHelper.GetPinyins(input);
        }
    }
}
