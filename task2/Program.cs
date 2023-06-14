Console.Clear();
Console.Write("Введите первое целое число: ");
string userImput1 = Console.ReadLine() ??"";
int a = int.Parse(userImput1);
Console.Write("Введите второе целое число: ");
string userImput2 = Console.ReadLine() ??"";
int b = int.Parse(userImput2);
int maxNumber = 0;
int minNumber = 0;



if (a < b)
{
    maxNumber = b;
    minNumber = a;
}
else if (a > b) 
{
    maxNumber = a;
    minNumber = b;
}
else 
{
    Console.WriteLine("Эти числа равны");
}

Console.WriteLine($"{maxNumber} больше чем {minNumber}");