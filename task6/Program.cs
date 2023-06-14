Console.Clear();
Console.Write("Введите число: ");
string userImput = Console.ReadLine() ??"";
int num = int.Parse(userImput);

if (num %2 ==0)
    Console.WriteLine ($"{num} четное ");

else 
    Console.WriteLine ($"{num} нечетное ");
