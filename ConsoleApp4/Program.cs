using ConsoleApp4;

ArrayAnalyzer analyzer = new ArrayAnalyzer();
Console.Write("اندازه آرایه را وارد کنید: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
if (size == 0)
{
    Console.WriteLine("آرایه خالی است.");
}
else
{
    Console.Write($"اندازه آرایه شما: {size}");
}
for (int i = 0; i < size; i++)
{
    Console.Write($"عنصر {i + 1} را وارد کنید: ");
    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
    {
        Console.Write($"لطفاً یک عدد صحیح برای عنصر {i + 1} وارد کنید: ");
    }
}

int maxValue = 0; 
double averageValue;
analyzer.AnalyzeArray(numbers, ref maxValue, out averageValue);
Console.WriteLine("نتایج :");

Console.WriteLine($"بزرگترین عدد: {maxValue}");
Console.WriteLine($"میانگین اعداد: {averageValue}");

Console.ReadLine();