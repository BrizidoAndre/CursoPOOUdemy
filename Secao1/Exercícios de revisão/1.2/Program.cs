Console.WriteLine($"Por favor digite o valor do raio do círculo:");
double raio = double.Parse(Console.ReadLine());

double area = Math.Round(Math.PI * Math.Pow(raio,2),4);

Console.WriteLine($"O tamanho do círculo é de {area}");
