/* 
Вывести квадрат числа
*/
//1. Объявить переменную, проинициализировать;
int firstTaskValue = 5;
//2. Объявить переменную с будущим результатом, присвоить
// значение умножения переменной из пункта 1 самой на себя
int firstTaskResult = firstTaskValue * firstTaskValue;
// 3. Вывести значение переменной из п.2 в консоль.
Console.WriteLine(firstTaskResult);


/*
По двум заданным числам проверять является
 ли первое квадратом второго
*/
// 1. Сказать про входные данные
// 1.1. входные данные - числа
// 1.2. числа целые (int)
// 1.3. Первое число - предполагаемый квадрат второго числа.
int secondTaskFirstValue = 25;
int secondTaskSecondValue = 4;

// 2. Второе целое число умножить само на себя. Результат сохранитью
// 2.1. Переменная, в которой лежит квадрат второго числаю
int secondTaskSquareResult = secondTaskSecondValue * secondTaskSecondValue;
// 3. Сравнить первое число со значением переменной из пункта 2.1.
// 3.1. Еслт первое число равно этому значению, следовательно вывести на экран сообщение 
// о том, что первое число - квадрат второго
// 3.2. Иначе сообщаем о том, что это не так
if (secondTaskFirstValue == secondTaskSquareResult)
{
    Console.WriteLine("Число является квадратом другого числа");
}
else
{
Console.WriteLine("Число не квадрат другого числа");
}

/*
Даны два числа. Показать большее и меньшее число
*/

// даны 2 числа, будем работать с целыми числами.
int thirdTaskFirstValue = 9;
int thirdTaskSecondValue = 4;

if (thirdTaskFirstValue > thirdTaskSecondValue)
{
    Console.WriteLine("Большее: " + thirdTaskFirstValue);
    Console.WriteLine("Меньшее: " + thirdTaskSecondValue);
}
else if (thirdTaskFirstValue < thirdTaskSecondValue)
{
    Console.WriteLine("Большее: " + thirdTaskSecondValue);
    Console.WriteLine("Меньшее: " + thirdTaskFirstValue);
}
else 
{
    Console.WriteLine("Числа равны");
}

/*
По заданному номеру дня недели вывести его название
*/

int dayOfweek = 1;
if (dayOfweek == 1)
{
    Console.WriteLine("Понедельник");
}
else if (dayOfweek == 2)
{
    Console.WriteLine("Вторник");
}
else if (dayOfweek == 3)
{
    Console.WriteLine("Среда");
}
else if (dayOfweek == 4)
{
    Console.WriteLine("Четверг");
}
else if (dayOfweek == 5)
{
    Console.WriteLine("Пятница");
}
else if (dayOfweek == 6)
{
    Console.WriteLine("Суббота");
}
else if (dayOfweek == 7)
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("МЫ не знаем такого значения");
}

string [] daysOfweek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if ((dayOfweek) >  0 && (dayOfweek) <= (daysOfweek.Length))
{
    Console.WriteLine(daysOfweek[dayOfweek]);
}
else 
{
    Console.WriteLine("Мы не знаем такого значения");
}
/*
Найти максимальное из трех чисел
*/
int a = 1;
int b = 2;
int c = 3;

int max = a;

if (a < b)
{
    max = b;
}
else
{
    max = a;
}
if (max < c)
{
    max = c;
}

Console.WriteLine(max);





/*
Написать программу вычисления значения функции y = f(a)
*/

int x = -1;

if (x >= 0)
{
    Console.WriteLine(x - 1);
}
else if (x < 0)
{
    Console.WriteLine(Math.Abs(x));
}

/*
Выяснить является ли число чётным
*/
int lastTaskValue = 4;

if (lastTaskValue % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else 
{
    Console.WriteLine("Число не четное");
}
/*
Показать последнюю цифру трёхзначного числа
Показать вторую цифру трёхзначного числа
Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Удалить вторую цифру трёхзначного числа
Выяснить, кратно ли число заданному, если нет, вывести остаток.
Найти третью цифру числа или сообщить, что её нет
*/  