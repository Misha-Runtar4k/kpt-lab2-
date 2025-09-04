double a;
double b;
Console.WriteLine("Enter a:");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b:");
b = Convert.ToDouble(Console.ReadLine());


double test = a * b * b / 2;
Console.Write("test Resolt: ");
Console.WriteLine(test);


Console.WriteLine("Result : " + (a * b * b / 2).ToString("F4"));
Console.WriteLine("Result : " + (Math.Round(a / (b - a), 2)));