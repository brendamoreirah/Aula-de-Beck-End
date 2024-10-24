int numeroImpar = 0;
int numeroPar = 0;



int[] numeros = new int[6];
for ( int i = 0; i < 6; i++)
{
    Console.WriteLine($"Digite um numero inteiro:");
    numeros[i]= int.Parse(Console.ReadLine());

    if (numeros[i] % 2 == 0)
    {
        numeroPar++;
       

    }
    else
    {
        numeroImpar++;
        
    }
}

Console.WriteLine($"temos  {numeroPar} numeros pares e {numeroImpar} numeros impares");



