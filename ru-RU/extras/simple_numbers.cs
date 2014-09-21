public static void Main(string[] args)
{
    int n = 0;
    int i = 0; 
    bool flag = false;
    
    Console.WriteLine("Простые числа:");
    for (n = 1; n <= 50; n++) {
        flag = true;
        for (i = 2; i <= n / 2; i++) {
            if (n % i == 0) {
                flag = false;
            }
        }
        if (flag) {
            Console.WriteLine(n);
        }
    }
}
