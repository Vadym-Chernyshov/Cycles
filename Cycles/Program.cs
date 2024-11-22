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

            Console.WriteLine("Please write your max value:");
            string strMaxValue = Console.ReadLine();
            bool thisIsAPrimeNumber = true; //булева зміна для перевірки числа на простосту

            if (int.TryParse(strMaxValue, out int maxValue) && maxValue > 0)
            {
                Console.WriteLine($"Prime numbers up to {maxValue}:");
                for (int i = 2; i <= maxValue; i++)
                {
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0) thisIsAPrimeNumber = false;                   
                    }
                    if (thisIsAPrimeNumber) { Console.Write(i + " "); }
                    thisIsAPrimeNumber = true;
                }
            }
            else
            {
                Console.WriteLine("Error ******************************************* Error");
            }                     
        }
    }
}
