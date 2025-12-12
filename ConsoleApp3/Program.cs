// See https://aka.ms/new-console-template for more information

using ConsoleApp3;

int a ;
Console.Write("Enter a:");
a = Convert.ToInt32(Console.ReadLine());
int b;
Console.Write("Enter b:");
b = Convert.ToInt32(Console.ReadLine());
int c;
Console.WriteLine($"value a is: {a}");
Console.WriteLine($"value b is: {b}");
Statistics stats = new Statistics();
stats.AnalyzeNumbers(a, ref b, out c);
Console.WriteLine($"After Claculate");
Console.WriteLine($"value a was: {a}");
Console.WriteLine($"value b is: {b}");
Console.WriteLine($"value c is: {c}");



