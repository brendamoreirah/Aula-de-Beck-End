
Console.WriteLine($"Entre com o valor do salário recebido");
float salário = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Entre com o valor do gasto");
float gasto = float.Parse(Console.ReadLine()!);


if (salarioRecebido >=totalGasto)

{
    Console.WriteLine("Gasto dentro do orçamento");
}
else
{
    Console.WriteLine("Orçamento estourado"); 
}

