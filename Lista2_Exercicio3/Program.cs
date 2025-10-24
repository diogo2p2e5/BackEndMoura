// Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    
// escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:

//   − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
//   − Triângulo    Isóscele:    possui    2    lados    iguais.     
//   − Triângulo    Escaleno:    possui    3    lados    diferentes.

float m1, m2, m3;

Console.WriteLine($"digite a primeira medida do triangulo");
m1 = float.Parse(Console.ReadLine());

Console.WriteLine($"digite a segunda medida do triangulo");
m2 = float.Parse(Console.ReadLine());

Console.WriteLine($"digite a terceira medida do triangulo");
m3 = float.Parse(Console.ReadLine());

if (m1 == m2 && m2 == m3)
{
    Console.WriteLine($"o seu triangulo é Equilátero que possui os 3 lados iguais");

}
else if (m1 != m2 && m2 != m3)
{
    Console.WriteLine($"o seu triangulo é Escaleno que possui os 3 lados diferentes");
}
else
{
    Console.WriteLine($"o seu triangulo é o Isóseles que possui 2 lados iguais");
    
}