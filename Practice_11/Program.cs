class Program
{
    static void Main()
    {
        List<string> inputList = new List<string>();
        List<string> uppercaseList = new List<string>();
        List<string> notUppercaseList = new List<string>();

        Console.WriteLine("Введіть рядки (для завершення введіть порожній рядок):");
        while (true)
        {
            Console.Write("Введіть рядок: ");
            string? line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                break;
            inputList.Add(line);
        }

        foreach (var str in inputList)
        {
            if (IsAllUpper(str))
                uppercaseList.Add(str);
            else
                notUppercaseList.Add(str);
        }

        Console.WriteLine("\nСписок рядків, що містять ТІЛЬКИ ВЕЛИКІ літери:");
        foreach (var str in uppercaseList)
            Console.WriteLine(str);

        Console.WriteLine("\nСписок рядків, що містять НЕ ТІЛЬКИ великі літери:");
        foreach (var str in notUppercaseList)
            Console.WriteLine(str);
    }
    
    static bool IsAllUpper(string s)
    {
        if (string.IsNullOrEmpty(s))
            return false;
        foreach (char c in s)
        {
            if (!char.IsUpper(c))
                return false;
        }
        return true;
    }
}