Console.WriteLine($"Quantos gols o timeA fez");
float timeA = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Quantos gols o timeB fez");
float timeB = float.Parse(Console.ReadLine()!);


if (timeA >timeB)

{
    Console.WriteLine("timeA ganhou");
}
else if (timeA < timeB)
{
    Console.WriteLine("timeB ganhou");
}
else 
{
    Console.WriteLine("empate");
}