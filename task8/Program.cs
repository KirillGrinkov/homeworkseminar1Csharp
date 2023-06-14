Console.Clear();
Console.Write("Введите число: ");
string userImput = Console.ReadLine() ??"";
int num = int.Parse(userImput);
int div = 2;

if(num > 1)
{
    while(div <= num)
    {
        Console.Write(div + " ");
        div = div + 2;
    }
}