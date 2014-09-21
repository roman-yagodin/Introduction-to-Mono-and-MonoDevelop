public static void Main(string[] args)
{
    int len;
    int sel;
    int rand;

    string pass = "";
    Random num = new Random();

    Console.WriteLine("Введите длину пароля:");
    len = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Выберите тип пароля:");
    Console.WriteLine("1-Буквы, символы, цифры");
    Console.WriteLine("2-Буквы и символы");
    Console.WriteLine("3-Буквы и цифры");
    Console.WriteLine("4-Буквы");
    Console.WriteLine("5-Цифры");
    sel = Convert.ToInt32(Console.ReadLine());

    switch (sel)
    { 
        case 1:
        for (int c1 = 0; c1 < len; c1++)
            pass+=char.ConvertFromUtf32(num.Next(33,130));
        break;
        
        case 2:
            for (int c1 = 0; c1 < len; c1++)
            {
            genNew:
                rand = num.Next(33, 126);
                if ((rand < 48) || (rand > 57))
                {
                     pass += Char.ConvertFromUtf32(rand);
                }
                else
                {
                    goto genNew;
                }
            }
            break;              

        case 3:
            for (int c1 = 0; c1 < len; c1++)
            {
                genNew2:
                rand = num.Next(33, 126);
                if (((rand > 47) && (rand < 58)) ||
                    ((rand < 122) && (rand > 96)) || 
                    ((rand < 89) && (rand > 64)))
                {
                    pass += Char.ConvertFromUtf32(rand);
                }
                else
                {
                    goto genNew2;
                }
            }
            break;

        case 4:
            for (int c1 = 0; c1 < len; c1++)
            {
                genNew3:
                rand = num.Next(33, 130);
                if(((rand>65) && (rand<90))||
                   ((rand<122) && (rand>96)))
                {
                    pass += char.ConvertFromUtf32(rand);
                }
                else
                {
                    goto genNew3;
                }
            }
            break;

        case 5:
            for (int c1 = 0; c1 < len; c1++)
            {
                pass +=  
                   char.ConvertFromUtf32(num.Next(48,57));
            }
            break;
    }
    Console.WriteLine("Ваш пароль: {0}", pass);
}
