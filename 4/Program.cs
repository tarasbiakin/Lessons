//Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».

System.Console.WriteLine("Введите число");
int a = Convert.ToInt16(Console.ReadLine());
System.Console.WriteLine("Вы ввели число "+a);