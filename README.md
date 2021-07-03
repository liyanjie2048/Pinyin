##### Liyanjie.Pinyin
- ���� **��ͷִ�**(https://github.com/anderscui/jieba.NET)
- ��Ҫ����
```csharp
string[] Liyanjie.Pinyin.PinyinHelper.GetPinyin(string input)
```
##### Liyanjie.Pinyin.ChineseChar
- ���� **����ƴ������**(https://github.com/mozillazg/pinyin-data) **/master/pinyin.txt**
- ��Ҫ����
```csharp
string[] Liyanjie.Pinyin.ChineseChar.ChineseCharHelper.GetPinyins(char chineseChar)
```
- ��չ����
```csharp
string[] System.StringExtensions.GetPinyins(this char input)
```
##### Liyanjie.Pinyin.ChineseWord
- ���� **����ƴ������**(https://github.com/mozillazg/phrase-pinyin-data) **/master/large_pinyin.txt**
- ��Ҫ����
```csharp
bool Liyanjie.Pinyin.ChineseWord.ChineseWordHelper.TryGetPinyin(string chineseWord, out string[] pinyin)
```
- ��չ����
```csharp
string[] System.StringExtensions.GetPinyin(this string input)
```

##### �򵥲���
- ����
```csharp
var array = new[]
{
    "�����ع�",
    "�����ﵥ��",
    "�۱����۵�����",
    "���ż���������",
    "��ެ��ެ��",
    "һ��ʮ�����ع�",
    "ʡ����ʡ����",
    "����ʦ�Լ�����",
    "����ܳ����",
    "���ź�������������",
    "���з��й�Ʊ",
    "����ɶ�",
    "������ٵ���",
    "��ʯʯ��",
    "��������ʮ��",
    "����ƤЬ׷����",
    "�����Ų�����",
    "������ʦ��������",
    "��УȥУ��",
};
foreach (var item in array)
{
    var pinyins = Liyanjie.Pinyin.PinyinHelper.GetPinyin(item);
    Console.WriteLine($"{item} > {string.Join(' ', pinyins)}");
}
```
- ���
```
�����ع� > ch��ng q��ng zh��ng g��ng
�����ﵥ�� > ch��n y�� q�� d��n ch��
�۱����۵����� > sh�� b��n d�� zh�� de zh�� t��ng
���ż��������� > g��n zh��o j�� b�� n��ng zhu�� sh��u
��ެ��ެ�� > t�� b�� de f��n y��n
һ��ʮ�����ع� > y�� p�� sh�� h��n b��i b��o gu��ng
ʡ����ʡ���� > sh��ng zh��ng b�� x��ng r��n sh��
����ʦ�Լ����� > d�� l��o sh�� y�� j�� du�� r��n
����ܳ���� > ch�� ch��i b�� n��ng ch�� ch�� cu��
���ź������������� > y�� zhu�� h��n chen * y�� y��n c��ng s��
���з��й�Ʊ > y��n h��ng f�� x��ng g�� pi��o
����ɶ� > �� g��u zh��n k�� w��
������ٵ��� > di��o ch�� h��u z��i ti��o ji��
��ʯʯ�� > li��ng sh�� sh�� z��
��������ʮ�� > d��n g��ng t��n l�� sh�� z��
����ƤЬ׷���� > b�� xi�� p�� xi�� zhu�� p�� sh��u
�����Ų����� > k��ng h�� xi�� b�� d��o w��
������ʦ�������� > y��n yu�� l��o sh�� l�� y�� zh�� r��n
��УȥУ�� > sh��ng xi��o q�� ji��o ch��ng
```
- Ԥ�ڴ���
```
��ʯʯ�� > li��ng sh�� sh�� z��
```