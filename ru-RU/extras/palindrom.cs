public static void Main(string[] args)
{
    string str = string.Empty;

    Console.WriteLine("Введите слово");
    string s = Console.ReadLine();
    
    int i = s.Length;
    
    for (int j = i-1; j >= 0; j--)
    {
        str = str + s[j];
    }
  
    if (str == s)
    {
        Console.WriteLine(s + " это палиндром");
    }
    else
        Console.WriteLine(s + " это не палиндром");
    
    Console.WriteLine(str);
}
