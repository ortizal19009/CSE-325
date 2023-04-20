// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
var chrismasDay = Convert.ToDateTime($"{currentDate.Year}-12-25");
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate.ToString("dd/MM/yyyy")}{Environment.NewLine}Christmas Day: { chrismasDay.ToString("dd/MM/yyyy")}");
var result = (chrismasDay-currentDate).TotalDays;
Console.WriteLine($"{Environment.NewLine}The result is: {result}");
Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);
