// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int a = new Random().Next(100,999);
// Console.WriteLine(a);
// int first = a / 100;
// int second = (a % 100) / 10;
// int therd = a % 10;

// Console.WriteLine(second);




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Введи число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string nText = Convert.ToString(n);
//     if (nText.Length > 2)
// {
//         Console.WriteLine("Третья цифра - " + nText[2]);
// }
// else 
// {
//   Console.WriteLine("Третьей цифры нет");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите числовое значение дня недели");
int weekDay=Convert.ToInt32(Console.ReadLine());
    while (weekDay >= 1 & weekDay <= 5)   
{
        Console.WriteLine("Не является выходным днем, повторите ввод");
        weekDay=Convert.ToInt32(Console.ReadLine());
}
    if (weekDay==6) Console.WriteLine("Выходной день - суббота");

    else if (weekDay==7) Console.WriteLine("Выходной день - воскресенье");

    else 
    while (weekDay >= 8) // При дальнейшем вооде значений после цикла - результат некорректный (прошу подсказать решение)
{
            Console.WriteLine("Вы ввели недопустимый номер дня недели, повторите ввод");
            weekDay=Convert.ToInt32(Console.ReadLine());
}
    
    