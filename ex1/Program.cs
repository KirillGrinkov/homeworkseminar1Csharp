Console.Clear();
Console.Write("Введите первое целое число: ");
string userImput1 = Console.ReadLine() ?? 
int a = int.Parse(userImput1);
Console.Write("Введите второе целое число: ");
string userImput2 = Console.ReadLine() ?? ;
int b = int.Parse(userImput2);
int MaxNumber = 0
int MixNumber = 0



if (a < b)
{
    int MaxNumber = b;
    int MinNumber = a;
}
else if (a > b) 
{
    int MaxNumber = a;
    int MinNumber = b;
}
else (a = b); 
{
    Console.WriteLine("Эти числа равны");
}

Console.WriteLine(MaxNumber ${"больше"} MinNumber);