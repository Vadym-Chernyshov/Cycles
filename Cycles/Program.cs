namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Обчислення середнього заробітку: Напишіть програму,
            //яка запитує користувача про зарплату кожного працівника за місяць.
            //Після отримання всіх значень програма має обчислити та вивести середній заробіток.

            //Console.WriteLine("Please write count of workers");
            //string strCountOfWorkers = Console.ReadLine(); //ввід користувача
            //decimal totalSalary = 0;

            //if (int.TryParse(strCountOfWorkers,out int countOFWorkers) && countOFWorkers > 0) //перевірка вводу
            //{
            //    for (int i = 0; i < countOFWorkers; i++)
            //    {
            //        // мітка, щоб коритувач зміг ввести нові дані для працівника,
            //        // якщо він їх ввів на початку некоректно                   
            //        startOfTheCycleBody:

            //        Console.WriteLine($"Please enter worker`s salary #{i + 1}");
            //        string strWorkersSalary = Console.ReadLine();

            //        if (decimal.TryParse(strWorkersSalary,out decimal countSalary) && countSalary > 0)
            //        {
            //            totalSalary += countSalary;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Incorrect salary. Please try again");
            //            //переходимо на початок тіла цикла, для повторного вводу данних
            //            goto startOfTheCycleBody;
            //        }
            //    }
            //    Console.WriteLine($"Avarage Salary: {totalSalary / countOFWorkers}");
            //}
            //else
            //{
            //    Console.WriteLine("Error!!! Incorect input data");
            //}

            //2. Побудова графіку зірочками: Напишіть програму, яка будує графік за допомогою зірочок.
            //Користувач повинен ввести кількість рядків графіка. Кожен рядок графіка
            //має містити відповідну кількість зірочок.

            //Console.WriteLine("Please enter count of lines");
            //string strCountOfLines = Console.ReadLine();
            //string star = "*";
            //if (int.TryParse(strCountOfLines, out int countOfLines) && countOfLines > 0)
            //{
            //    string graph = string.Empty;
            //    for (int i = 0; i < countOfLines; i++)
            //    {
            //        graph += star;
            //        Console.WriteLine(graph);
            //    }
            //}
            //else //ERROR
            //{
            //    Console.WriteLine("Error ******************************************* Error");
            //}

            //3. Генерація простих чисел: Напишіть програму, яка генерує прості
            //числа від 1 до заданого користувачем числа. Просте число -
            //це число, яке ділиться лише на 1 і на себе.

            //Console.WriteLine("Please write your max value:");
            //string strMaxValue = Console.ReadLine();
            //bool thisIsAPrimeNumber = true; //булева зміна для перевірки числа на простоту

            //if (int.TryParse(strMaxValue, out int maxValue) && maxValue > 0)
            //{
            //    Console.WriteLine($"Prime numbers up to {maxValue}:");
            //    for (int i = 2; i <= maxValue; i++)
            //    {
            //        //перевірка дільників до корня з i
            //        for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {
            //            //якщо знайдено дільник, число не є простим
            //            if (i % j == 0) thisIsAPrimeNumber = false;
            //        }
            //        if (thisIsAPrimeNumber) { Console.Write(i + " "); }
            //        thisIsAPrimeNumber = true; 
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error ******************************************* Error");
            //}

            //4. Напишіть програму, яка перевіряє пароль користувача.
            //Пароль вважається прийнятним, якщо він містить принаймні
            //8 символів, з яких принаймні один символ - це цифра, а
            //також принаймні один символ - це спеціальний символ
            //(наприклад, !, @, # тощо).

            //string password = string.Empty;
            //bool badPassword = true;
            //while (badPassword)
            //{
            //    sbyte minLength = 8; //мінімальна довжина
            //    bool oneDigit = false; //перевірка на цифру
            //    bool oneSpecialSymbol = false; //перевірка на спец.символ

            //    Console.WriteLine("Please create your password");
            //    password = Console.ReadLine();

            //    //хз як це робити без масивів, тому буду користуватися ними
            //    for (int i = 0; i < password.Length; i++) // проходимо по символам рядка
            //    {
            //        //в char є зручні методи перевірки символів
            //        //https://learn.microsoft.com/en-us/dotnet/api/system.char.isdigit?view=net-9.0
            //        if (char.IsDigit(password[i])) oneDigit = true;
            //        if (!char.IsLetterOrDigit(password[i])) oneSpecialSymbol = true;

            //    }


            //    //умова виходу з циклу
            //    if (minLength <= password.Length && oneDigit && oneSpecialSymbol)
            //    {
            //        badPassword = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect password. Please try again.");
            //    }               
            //}
            //Console.WriteLine("Password has been created");

            //5. Генерація фібоначчівської послідовності: Напишіть програму,
            //яка генерує перші N чисел Фібоначчі. Послідовність Фібоначчі
            //починається з 0 і 1, а кожне наступне число є сумою двох
            //попередніх чисел у послідовності.

            //Console.WriteLine("Please enter your the desired number of Fibonacci numbers. Starting from 2");
            //string strCountOfFibonacciNum = Console.ReadLine();

            //if (long.TryParse(strCountOfFibonacciNum, out long countOfFibonacciNum) && countOfFibonacciNum > 0)
            //{
            //    long firstNum = 0; //перше число послідовності
            //    long secondNum = 1; //друге число послідовності
            //    long sum = 0; //третя зміна для суми та перезапису змінних
            //    string beginFibonacciNum = "0 1";
            //    string afterFibonacciNum = string.Empty;
            //    for (int i = 2; i < countOfFibonacciNum; i++)
            //    {
            //        //сумуємо
            //        sum = firstNum + secondNum;
            //        //переназначаємо зміні
            //        firstNum = secondNum;
            //        secondNum = sum;
            //        //записуємо результат
            //        afterFibonacciNum += " " + secondNum;                    
            //    }
            //    Console.WriteLine(beginFibonacciNum + afterFibonacciNum); //вивід
            //}
            //else
            //{
            //    Console.WriteLine("Error ******************************************* Error");
            //}

            //6. Калькулятор оплати праці за годину: Напишіть програму,
            //яка запитує в користувача кількість годин, працюваних за день,
            //та розмір годинної ставки. Після введення значень програма має
            //обчислити та вивести оплату за день.

            Console.WriteLine("Please enter number of hours at work");
            string numberOfHours = Console.ReadLine();



        }
    }
}
