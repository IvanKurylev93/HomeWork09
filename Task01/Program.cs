// Показать натуральные числа от N до 1, N задано
Console.Clear();

Console.WriteLine("Введите число: ");
int num2 = int.Parse(Console.ReadLine());
int num1 = 1;

string num3 = NumberRec(num1, num2);
Console.Write($"{num3} ");
string NumberRec(int nm1, int nm2)  // Рекурсия 
{
    if (nm1 <= nm2) 
        return ($"{nm2} {NumberRec( nm1, nm2 - 1)}");       // 

    else return String.Empty;
}