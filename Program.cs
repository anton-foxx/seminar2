// Напишите программу, которая принимает на вход трехзначное число  
// и на выходе показывает вторую цифру этого числа.

// Console.Clear();
// int x = new Random().Next(99,1000);
// Console.WriteLine(x);

// int rem1 = x / 10;
// int rem2 = rem1 % 10;

// Console.WriteLine(rem2);


// Напишите прогоррамму, которая выводит третью цифру заданног числа и сообщает, 
// что третьей цифры нет.

// Console.Clear();
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2 = 0;

// if (num < 100)
// {
//  Console.WriteLine("Третье число отсутствует");
// }
// else 
// {
//     while (num >= 1000)
//     num = num / 10;
//     num2 = num % 10;
//     Console.WriteLine(num2);
// }


// Напишите программу, которая принимает на вход цифру, обозначающую день недели,  
// и проверяет, является ли этот день выходным.

// Console.Clear();
// Console.Write("Введите число соответствующее дню недели: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (num == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (num == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (num == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (num == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (num == 6)
// {
//     Console.WriteLine("Суббота - выходной день!");
// }
// else if (num == 7)
// {
//     Console.WriteLine("Воскресенье - Выходной день!");
// }
// else 
// {
//         Console.WriteLine("Ошибка");
// }