using HomeWork2.Task1;
using HomeWork2.Task2;
using HomeWork2.Task3;
using HomeWork2.Task4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding =Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("این متن فارسی است");
            Console.ReadLine();

            //TASK1
            Student student = new Student("Amir", 26);
            student.introduce();
            Console.ReadKey();


            //TASK2
            BankAccount myAccount = new BankAccount();
            myAccount.ShowBalance();

            myAccount.Deposit(500);
            myAccount.ShowBalance();

            myAccount.Withdraw(300);
            myAccount.ShowBalance();

            myAccount.Withdraw(2000);
            myAccount.ShowBalance();

            Console.WriteLine("press ENTER to exit");
            Console.ReadKey();




            //TAKS3
            Console.Write("عدد اول را وارد کنید: ");
            int num1;
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("ورودی نامعتبر است. لطفاً یک عدد صحیح وارد کنید: ");
            }

            Console.Write("عدد دوم را وارد کنید: ");
            int num2 = int.Parse(Console.ReadLine());

            int num3; // برای out مقدار اولیه نمی‌خواهد

            Console.WriteLine("\n--- مقادیر قبل از متد ---");
            Console.WriteLine($"عدد اول: {num1}");
            Console.WriteLine($"عدد دوم: {num2}");

            Statistics.AnalyzeNumbers(num1, ref num2, out num3);

            Console.WriteLine("\n--- مقادیر بعد از متد ---");
            Console.WriteLine($"عدد اول (بدون تغییر): {num1}");
            Console.WriteLine($"عدد دوم (ref و به توان 2): {num2}");
            Console.WriteLine($"عدد سوم (out و مجموع): {num3}");

            Console.ReadKey();



            //TASK4
            Console.Write("اندازه آرایه را وارد کنید: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"عدد {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int max = 0;
            double average;

            ArrayAnalyzer.AnalyzeArray(numbers, ref max, out average);

            Console.WriteLine($"بیشترین عدد: {max}");
            Console.WriteLine($"میانگین: {average}");
        }
    }
}