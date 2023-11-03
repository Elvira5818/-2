// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();

int varA;
while (true)
{

Console.Write("Напишите целое число - ");
if (int.TryParse(Console.ReadLine(), out varA))
break;
Console.WriteLine("Ошибка ввода!");

}

int a1 = varA / 100;
int a2 = varA % 10;

 if (varA > 999)
 {

    int b1 = varA /= 10;
    int result = b1 % 10;

    Console.WriteLine($"Третья цифра из трехзначного числа {varA} -> {result} ");
 }
else if (varA < 99)
{

    Console.WriteLine($"Третьей цифры нет");


}
else
Console.WriteLine($"Третья цифра из трехзначного числа {varA} -> {a2} ");