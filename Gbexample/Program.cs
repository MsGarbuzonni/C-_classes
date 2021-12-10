// вывести квадрат числа
// byte (8 бит занимает)
// shart (16 бит)
// int (32 бит)
// long (64 бита)

// тип_данных имя_переменной = значение; 
int myint = 10;
Console.WriteLine(myint);

// float
// double 
double mydouble = 2.14;
Console.WriteLine(mydouble);
// char - символьный 
char myChar = 'a';
Console.WriteLine(myChar);

// bool  - логический тип данных (истина\ложь)
bool myBool = true;
Console.WriteLine(myBool);
bool myFolce = false;
Console.WriteLine(myFolce);


// string - строчка, массив данных 

string myString = "это строка";
Console.WriteLine(myString);

// + - * / %
int first = 9;
int second = 10;
int third = (first + second) * 5;
Console.WriteLine(third);

// if (условие)
//{
// тело_из_набора_оператораж   
//}

// < > >= <= == !=
// && || !- логическое отрицание

if (first < second)
{
    Console.WriteLine(first +"<"+second);
}
else if (first>second)
{
    Console.WriteLine(first+">"+second);
}
else
{
    Console.WriteLine("по умолчанию");
}

int a = int.Parse(Console.ReadLine());
Console.WriteLine(a);

double b = Math.Sqrt(9);
Console.WriteLine(b); 
