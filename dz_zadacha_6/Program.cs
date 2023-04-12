// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
int division = number % 2;
if (division == 0)
{
  Console.WriteLine("This is chetnoe");
}
else
{
  Console.WriteLine("This is not chetnoe");
}