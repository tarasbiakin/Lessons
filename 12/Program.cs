// За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
// Для вычисления суммы с учетом процентов используйте цикл for. Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет представлять тип decimal).

Console.WriteLine($"Введите размер вклада");
decimal vkl =Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Введите размер процента");
decimal prc = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Введите срок");
decimal sr = Convert.ToDecimal(Console.ReadLine());



void Vkl(decimal vk,decimal pr,decimal s){
    decimal res=vk;
    for(int i=0;i<=s;i++){
        res =res*pr; 
    }Console.WriteLine("Результат: "+res);
    
}
Vkl( vkl,prc,sr);