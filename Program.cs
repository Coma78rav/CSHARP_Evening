// String, Char
// Console.Clear();
// Console.Write("Введите имя: ");
// string name = Console.ReadLine()!;
//Console.WriteLine($"Привет, {name}!");
// Воспринимае как массив name
// Ivan
// // 0123
// Console.WriteLine(name[0]); // выведет первую букву
// Console.WriteLine(name.Length); //выведет количество символов
// name = "Ivan"    String
// name[0] = 'I'    Char

// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine()!;
// Console.WriteLine(Convert.ToInt32(number[0]));
//Console.WriteLine(number[0] * 2);
// 4 это 52 по UTF-8 (таблица кодировки)
// char 's' = '!';

// Напишите программу, которая принимает на входе число и выводит сумму его цифр.
// int -> [2147000000]
Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine()!;
// int n = int.Parse(Console.ReadLine()!);
// char -> string -> int
int result = 0;
for (int i = 0; 1 < number.Length; i++){
    result += int.Parse(number[i].ToString()); // char -> string -> int
}
Console.WriteLine(result);
