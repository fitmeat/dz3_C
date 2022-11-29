// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да 
// 23432 -> да
 Console.Clear();
 Console.WriteLine("Введите пятизначное число: ");
 int n = Convert.ToInt32(Console.ReadLine());
 while(n<10000 || n>99999){
    Console.WriteLine("Это не пятизначное число. Попробуй еще раз: ");
    n = Convert.ToInt32(Console.ReadLine());
 }
if(n/10000 == n%10){
    if((n/1000)%10 == (n%100)/10){
        Console.WriteLine("YES");
    } else Console.WriteLine("NO");
} else Console.WriteLine("NO");