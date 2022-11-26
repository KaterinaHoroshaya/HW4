/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Без использования функции Math.Pow.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно возвести:");
int b = Convert.ToInt32(Console.ReadLine());

int count = 1;
int result = 1;

while (count <= b)
{
    result = result * a;
    count++;
}

Console.WriteLine($"{result}");
