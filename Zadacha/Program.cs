string[] SMass;
Console.WriteLine("Введите текст");
string text = Console.ReadLine().ToLower();
SMass = text.Split(' ');
Console.WriteLine($"{SMass.Length} слов(а)");



string[] SMass2;
SMass2 = text.Split('.', '!', '?');
Console.WriteLine($"{SMass2.Length} предложени(я)й");



string[] SMass3;
int summa = 0;
SMass3 = text.Split(' ');
for (int i = 0; i < SMass3.Length; i++)
{
    summa += SMass3.Length;
}
Console.WriteLine($"{summa/ SMass3.Length} буквы - средняя длина слова");


char[] vowels = { 'а', 'у', 'е', 'ы', 'о', 'э', 'я', 'и', 'ю', 'ё' };
int countOfVowels = 0;
int countOfConsonats = 0;

for (int i = 0; i< text.Length; i++)
{
    char temp = text[i];
    if (char.IsLetter(text[i]))
    {
        bool isConsonats = true;
        for (int j = 0; j < vowels.Length; j++)
        {
            if (vowels[j] == temp)
            {
                countOfVowels++;
                isConsonats = false;
                break;
            }
            
        }
        if (isConsonats == true)
        {
            countOfConsonats++;
        }
    }

}
Console.WriteLine($"согласных {countOfConsonats}, гласных {countOfVowels}");