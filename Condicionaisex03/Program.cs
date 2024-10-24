// Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     

  // − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
 //  − Triângulo    Isóscele:    possui    2    lados    iguais.     
 //  − Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.WriteLine($"informe o lado 1");
float lado1= float.Parse(Console.ReadLine()!);

Console.WriteLine($"informe o lado 2 ");
float lado2= float.Parse(Console.ReadLine()!);

Console.WriteLine($"informe o lado 3");
float lado3= float.Parse(Console.ReadLine()!);

if(lado1 == lado2 && lado2 == lado3)
{
     Console.WriteLine("triangulo Equilátero");
}
else if (lado1 == lado2 || lado1 ==lado3 || lado2 ==lado3)
{
    Console.WriteLine("triangulo Isóscele");
}
else
{
    Console.WriteLine("triangulo Escaleno");
}

