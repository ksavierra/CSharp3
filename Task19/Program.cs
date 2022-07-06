// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

class Palindr
     {
        public static bool Palindromtest (string number)
    
       {
    for (int i = 0; i < number.Length / 2; i++)
 
        if (number[i] != number[number.Length - i - 1])
            return false;
    return true;
       }

    static void Main()
        {
        string number;
            Console.WriteLine("Введите 5-тизначное число:");
          number = Console.ReadLine();

        if (number.Length < 5)
            Console.WriteLine("Вы ввели число неудовлетворяющее условию");
        if (number.Length > 5)
            Console.WriteLine("Вы ввели число не удовлетворяющее условию");
          
    
          
        if (Palindromtest(number))
        Console.WriteLine("Да, это число палиндром");

       else Console.WriteLine("Нет, это число не палиндром");
    Console.ReadLine();
        }
     }           
        
     

