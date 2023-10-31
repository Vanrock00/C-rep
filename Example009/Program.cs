//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string ReplaceText(string text, char OldValue, char NewValue)
{
    string newText = String.Empty;
    int length = text.Length; 
    for (int i = 0; i < length; i++)
    {
        if(text[i] == OldValue)
            newText += NewValue;//newText = newText + NewValue;
        else
            newText += text[i];//newText = newText + text[i];

    }
    return newText;
}

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы ваС послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

string ReplacedText = ReplaceText(text, ' ', '_');
Console.WriteLine(ReplacedText);
Console.WriteLine();
ReplacedText = ReplaceText(ReplacedText, 'к', 'К');
Console.WriteLine(ReplacedText);
Console.WriteLine();
ReplacedText = ReplaceText(ReplacedText, 'С', 'с');
Console.WriteLine(ReplacedText);