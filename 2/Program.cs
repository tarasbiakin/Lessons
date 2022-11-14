//Составить программу вывода на экран «столбиком» пяти любых чисел, введенных пользователем с клавиатуры.

System.Console.WriteLine("Введите числа");
int[]array = new int[5];
for(int i = 0; i <array.Length; i++ ){
    array[i] = Convert.ToInt16(Console.ReadLine());
}
foreach(int el in array){
    System.Console.WriteLine("Число " +el);
}
