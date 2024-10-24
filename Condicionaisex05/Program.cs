Console.WriteLine($"Quantas macas deseja comprar?:");
int quantMacas = int.Parse(Console.ReadLine());
float valorVenda;

if (quantMacas < 12)
{
    valorVenda = quantMacas * 0.30f;
}
else 
{
    valorVenda = quantMacas  * 0.25f;
}

Console.WriteLine($" Valor da venda:  {valorVenda}");





