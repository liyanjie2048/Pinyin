# Pinyin moved to https://github.com/liyanjie8712/BuildingBlocks

- 基于以下项目实现
  - **结巴分词**(https://github.com/anderscui/jieba.NET)
  - **汉字拼音数据**(https://github.com/mozillazg/pinyin-data) **/master/pinyin.txt**
  - **词语拼音数据**(https://github.com/mozillazg/phrase-pinyin-data) **/master/large_pinyin.txt**

- 简单测试
    - 代码
    ```csharp
    var array = new[]
    {
        "重庆重工",
        "单于骑单车",
        "折本打折的折腾",
        "干着急不能着手",
        "吐蕃的蕃衍",
        "一曝十寒被曝光",
        "省长不省人事",
        "度老师以己度人",
        "出差不能出差错",
        "衣着寒伧，语言伧俗",
        "银行发行股票",
        "恶狗真可恶",
        "调查后再调解",
        "两石石子",
        "弹弓弹力十足",
        "扒下皮鞋追扒手",
        "恐吓吓不倒我",
        "音乐老师乐于助人",
        "上校去校场",
    };
    foreach (var item in array)
    {
        var pinyins = Liyanjie.Pinyin.PinyinHelper.GetPinyin(item);
        Console.WriteLine($"{item} > {string.Join(' ', pinyins)}");
    }
    ```
    - 输出
    ```
    重庆重工 > chóng qìng zhòng gōng
    单于骑单车 > chán yú qí dān chē
    折本打折的折腾 > shé běn dǎ zhé de zhē téng
    干着急不能着手 > gān zháo jí bù néng zhuó shǒu
    吐蕃的蕃衍 > tǔ bō de fán yǎn
    一曝十寒被曝光 > yī pù shí hán bèi bào guāng
    省长不省人事 > shěng zhǎng bù xǐng rén shì
    度老师以己度人 > dù lǎo shī yǐ jǐ duó rén
    出差不能出差错 > chū chāi bù néng chū chā cuò
    衣着寒伧，语言伧俗 > yī zhuó hán chen * yǔ yán cāng sú
    银行发行股票 > yín háng fā xíng gǔ piào
    恶狗真可恶 > è gǒu zhēn kě wù
    调查后再调解 > diào chá hòu zài tiáo jiě
    两石石子 > liǎng shí shí zǐ
    弹弓弹力十足 > dàn gōng tán lì shí zú
    扒下皮鞋追扒手 > bā xià pí xié zhuī pá shǒu
    恐吓吓不倒我 > kǒng hè xià bù dào wǒ
    音乐老师乐于助人 > yīn yuè lǎo shī lè yú zhù rén
    上校去校场 > shàng xiào qù jiào chǎng
    ```
    - 预期错误
    ```
    两石石子 > liǎng shí shí zǐ
    ```
