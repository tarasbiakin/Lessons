//Составить программу вывода на экран в одну строку четырех любых чисел с тремя пробелами между ними.

using System;
namespace Lessons{
    class Program{
        static void Main(){
            for(int i=1;i<5;i++){
            Random a = new Random();
            int randomNober = a.Next(1,50);
            System.Console.WriteLine(randomNober);}

        }
    }
}