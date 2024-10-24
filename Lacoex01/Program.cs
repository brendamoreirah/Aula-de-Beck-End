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
int qtdesporte = 0;
int qtdnesporte = 0;



Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qtnEntrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qtnEntrevistados ; i++)
{
  Console.WriteLine($"Qual e o seu sexo m/f ");
  string sexo = Console.ReadLine();

  if (sexo == "f")
  {
    qtdMulher++;
  }
  else
  {
    qtdHomem++;
  }


Console.WriteLine($"Voce gosta de esportes sim ou nao?");
  string esporte = Console.ReadLine();

  if (esporte == "sim")
  {
    qtdesporte++;
  }
  else
  {
    qtdnesporte++;
  }


}
float percentual = (100/ qtnEntrevistados) * qtdnesporte;
//total
//gastar
//100/ total * gastam


  Console.WriteLine($"Quantidades de mulheres: {qtdMulher}");
  Console.WriteLine($"Quantidades de homens: {qtdHomem}");
  Console.WriteLine($"Total Entrevistados: {qtdHomem + qtdMulher}");
  Console.WriteLine($"Quantidades de quem gosta de esporte:  {percentual}");
  Console.WriteLine($"Quantidades de quem nao de esporte:  {qtdnesporte}");

