// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел ");
string? text = Console.ReadLine();

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', ',');
Console.WriteLine($"Ваши числа : {newText}");
int IndexOfNextComma(string text, int index)
{
    while (text[index] != ',')
    {
        if (index < text.Length - 1)
            index++;
        else
            break;
    }
    return index;
}
int count = 0;

for (int i = 0; i < newText.Length; i++)
{
    switch (newText[i])
    {
        case '-':
            i = IndexOfNextComma(newText, i);
            break;
        case '0':
            i = IndexOfNextComma(newText, i);
            break;
        case ' ':
            break;
        default:
            count++;
            i = IndexOfNextComma(newText, i);
            break;
    }
}
Console.WriteLine($"Количество чисел больше 0 = : {count}.");

// Моя логига была проста . написать код так что бы числа вводить без запятых и не ошибиться с ними . а сам код
//переводил бы пробелы в запятые , и из строки цифр с запятыми - случилась бы магия и там уже все просто должно было быть.
//
//как я ошибался . 