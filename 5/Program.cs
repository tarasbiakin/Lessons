//Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
internal class Program
{
    private static void Main(string[] args)
    {
        double e = Math.E;
        System.Console.WriteLine(Math.Round(e,1));
    }
}