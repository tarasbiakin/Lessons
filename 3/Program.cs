// Вывести на экран число «ПИ» с точностью до сотых.

internal class Program
{
    private static void Main(string[] args)
    {
        double pi = Math.PI;
        System.Console.WriteLine(Math.Round(pi,2));
    }
}