//Напишите программу, которая
//1. на вход принимает число , и выдает
//2. является ли число четным(делится ли оно на два без остатка)
//3. вывод результата

//Например
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int remain = num % 2;
if (remain == 0)
{
Console.WriteLine("Число " + num + " четное?");
Console.WriteLine("ДА!");
}
else
{
Console.WriteLine("Число " + num + " четное?");
Console.WriteLine("НЕТ!");
}
