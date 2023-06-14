Console.Clear();
Console.Write("Введите первое целое число: ");
string userImput1 = Console.ReadLine() ??"";
int num1 = int.Parse(userImput1);
Console.Write("Введите второе целое число: ");
string userImput2 = Console.ReadLine() ??"";
int num2 = int.Parse(userImput2);
Console.Write("Введите третье целое число: ");
string userImput3 = Console.ReadLine() ??"";
int num3 = int.Parse(userImput3);
int maxNumber = num1;

if (num1 >= num2 && num1 >= num3)
    maxNumber= num1;
else if (num2 >= num1 && num2 >=num3 )
    maxNumber= num2;
else if (num3 >= num1 && num3 >= 2)
    maxNumber = num3;

Console.WriteLine($"Наибольшее число {maxNumber}");