// Calcule a área de um triângulo qualquer, dadas as medidas dos 3 lados. Exiba o semiperímetro e a área.

double a;
double b;
double c;
double p; //semiperimetro
double area;

Console.WriteLine("----Calculadora de Triângulo----\n");

Console.Write("Digite a medida do lado a: ");
a = double.Parse(Console.ReadLine()!);

Console.Write("Digite a medida do lado b: ");
b = double.Parse(Console.ReadLine()!);

Console.Write("Digite a medida do lado a: ");
c = double.Parse(Console.ReadLine()!);

p = a + b + c / 2;
area = Math.Sqrt (p * (p - a) * (p -b) * (p- c));

Console.WriteLine($"o semiperímetro é {p}");
Console.WriteLine($"A área do triângulo é {area}");
Console.ReadLine();