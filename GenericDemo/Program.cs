// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using GenericDemo;

int[] intArray = { 1, 2, 3, 4, 5 };
double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
//Program.toPrint(intArray);
//Program.toPrint(doubleArray);
//Program.toPrint(charArray);

Sample.toPrint<int>(intArray);
Sample.toPrint<double>(doubleArray);
Sample.toPrint<char>(charArray);
Console.ReadKey();
