using Exercicio01;
Console.Clear();
Console.WriteLine($"-- Bem vindo ao programa de Geometria --");
Console.WriteLine();

//-------------Retangulo-----------
Console.WriteLine($"Vamos calcular a Area do retangulo:");
Console.Write($"Informe a Altura: ");
float altura= float.Parse(Console.ReadLine());
Console.Write($"Informe a Largura: ");
float largura = float.Parse(Console.ReadLine());

Retangulo roberto = new Retangulo(altura , largura);


//-------------Circulo-------------
Console.WriteLine($"Vamos calcular a Area do circulo:");
Console.Write($"Informe o Raio: ");
float raio= float.Parse(Console.ReadLine());

Circulo junior = new Circulo(raio);



//-----------Resultado---------------
junior.CalcularArea();
roberto.CalcularArea();

