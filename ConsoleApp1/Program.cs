// See https://aka.ms/new-console-template for more information
using ConsoleApp1;



/*********/
Console.WriteLine("Hi!");
Console.Write("Please Enter your Name:");
var nameinput = Console.ReadLine();
Console.Write("Please Enter your Age:");
int ageinput = Convert.ToInt32(Console.ReadLine());
Student student = new Student(nameinput,ageinput);
Console.WriteLine(student.Introduce());
/*********/