void Quards(int uN)
{
    int current = 1;
    while (current <= uN)
    {
        int res=current*current*current;
        Console.Write($"{res}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}
Console.Write("введите число N ");
int uNN = Convert.ToInt32(Console.ReadLine());
if (uNN >=1)
{
    Console.Write($"{uNN} -> ");
   Quards(uNN); 
}
else Console.WriteLine("Неправильное число");