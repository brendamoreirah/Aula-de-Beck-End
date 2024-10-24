Console.WriteLine(@$"
 +------------------------+
|Bem vindo ao programa    |
|    contador             |
|            de           |
|            pessoas      |
+-------------------------+ 
");

int qtdHomem = 0;
int qtdMulher = 0;
int qtdProduto =0;
int qtdNaoGostaramDoProduto =0;

Console.WriteLine($"Qual o seu nome?");
string nome =Console.ReadLine()!;

Console.WriteLine($"Quantas pessoas estao com voce");
int Entrevistados = int.Parse(Console.ReadLine()!);

for(int i =0; i <=Entrevistados; i++)
{
Console.WriteLine($"Qual o seu sexo? (m/f)");
string sexo = Console.ReadLine()!;


  if (sexo == "f")
  {
    qtdMulher++;
  }
  else
  {
    qtdHomem++;
  }
}

  
Console.WriteLine($"Voce gostou do produto lançado?  sim/nao");
string produto = Console.ReadLine()!;

  if (produto == "sim")
  {
    qtdProduto++;
  }
  else
  {
    qtdNaoGostaramDoProduto++;
  }
  
float percentual = (100/ qtdHomem) * qtdProduto;
//total
//gastar
//100/ homens * nao gostaram

Console.WriteLine($"Quantidade de mulheres: {qtdMulher}");
Console.WriteLine($"Quantidades de homens: {qtdHomem}");
Console.WriteLine($"Total Entrevistados: {qtdHomem + qtdMulher}");
Console.WriteLine($"Total de pessoas que disseram sim:  {qtdProduto}");
Console.WriteLine($"Total de pessoas que disseram nao:  {qtdNaoGostaramDoProduto}");
 Console.WriteLine($"Total de mulheres que disseram sim: {qtdProduto}");
Console.WriteLine($"Percentual de homens que disseram nao {percentual}%");


