// See https://aka.ms/new-console-template for more information

/*********/
using ConsoleApp2;
Console.WriteLine("Enter init Balance value:");
int val = Convert.ToInt32(Console.ReadLine());  

BankAccount ba = new BankAccount(val);
Console.WriteLine("=============");
Console.WriteLine($"your Bank amount is : {ba.GetBalance()}");
Console.WriteLine("=============");
/*********/