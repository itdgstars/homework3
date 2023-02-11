void pal(int N)
{
    int p = N / 10000;
    if (p > 0 &  p <10)
    {
       int n1 = N/10000;
       int nn1 = N%10;
       int n2 = N/1000;
       int n3 = n2%10;
       int nn2 = N%100;
       int n4 = nn2/10;
       if (n1 == nn1 & n3 == n4)
       {
        Console.WriteLine ($"Число {N} является палиандром."); 
       }
       else
       {
        Console.WriteLine ($"Число {N} НЕ является палиандром.");
       }
    } 
    else
    {
       Console.WriteLine ($"Ваше число {N} не является пятизначным"); 
    }
}
Console.WriteLine ("Введите пятизначное число: ");
int nP = Convert.ToInt32(Console.ReadLine());
pal(nP);
