namespace PracticalWork3OAiP;

public class Program
{
    public static void Main(string[] args)
    {
        // ЗАДАНИЕ 1
        Console.WriteLine("ЗАДАНИЕ 1 (вывести ТОЛЬКО фамилию)\n\n");

        Console.WriteLine("Введите полное имя (имя + фамилия): ");
        string? fullName = Console.ReadLine();

        string[] fullNameSegments = fullName.Split(' ');
        string surname = fullNameSegments[fullNameSegments.Length - 1];

        Console.WriteLine($"\nФамилия: {surname}");


        // ЗАДАНИЕ 2
        Console.WriteLine("\n\nЗАДАНИЕ 2 (Замена всех букв \"а\" в строке на символ \"*\".)\n\n");

        Console.WriteLine("Введите строку:");
        string? inputString = Console.ReadLine();

        string? resultString = inputString.Replace("а", "*"); // Заменяем все вхождения "а" на "*"

        Console.WriteLine($"Результат: {resultString}");


        // ЗАДАНИЕ 3
        Console.WriteLine("\n\nЗАДАНИЕ 3 (Удаление лишних пробелов в начале и в конце введённой строки + вывод верхнем регистре.)\n\n");

        Console.WriteLine("Введите строку: ");
        string? userString = Console.ReadLine();

        Console.WriteLine($"\nОбновлённая строка: {userString.Trim().ToUpper()}");


        // ЗАДАНИЕ 4.1
        Console.WriteLine("\n\nЗАДАНИЕ 4.1 (Вывод количества слов в строке (разделённые пробелами).)\n\n");

        Console.WriteLine("Введите строку: ");
        string? userString1 = Console.ReadLine();

        string[] fullStringSegments = userString1.Split(' ');

        Console.WriteLine($"\nКоличество слов в строке: {fullStringSegments.Length}");


        // ЗАДАНИЕ 4.2
        Console.WriteLine("\n\nЗАДАНИЕ 4.2 (Вывод всех уникальных слов (без повторений).)\n\n");

        string[] uniqueWords = fullStringSegments.Distinct().ToArray();
        Console.WriteLine("\nУникальные слова: ");

        foreach (string word in uniqueWords)
            Console.WriteLine(word);


        // ЗАДАНИЕ 4.3
        Console.WriteLine("\n\nЗАДАНИЕ 4.3 (Вывод строки, в которой каждое слово начинается с заглавной буквы.)\n\n");

        string finalString = string.Join(" ", fullStringSegments.Select(word => char.ToUpper(word[0]) + word.Substring(1)));
        Console.WriteLine($"\nСтрока с заглавными буквами: {finalString}");
    }
}