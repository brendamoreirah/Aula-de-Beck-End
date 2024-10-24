//varíaveis e tipos de dados
// Criar um  cabeçalho de boas vindas
//Pedir os dados de cadastro

Console.WriteLine(@"
+-------------------------+
|    Seja Bem Vindoa(a)   |
+-------------------------+
");


Console.WriteLine($"Nome:");
string nome = Console.ReadLine();


Console.WriteLine($"{nome}, digite seu sobrenome:");
string sobrenome = Console.ReadLine();


Console.WriteLine($"Digite sua data de nascimento: ");
//   DateOnly dataNascimento = new DateOnly(2008, 2, 22);
DateOnly dataNascimento = DateOnly.Parse(Console.ReadLine());
        DateOnly dataAtual = DateOnly.FromDateTime(DateTime.Now);
  
        Console.WriteLine("Data de Nascimento: " + dataNascimento);
        Console.WriteLine("Data Atual: " + dataAtual);
  
        int idade = dataAtual.Year - dataNascimento.Year;
        if (dataAtual < dataNascimento.AddYears(idade))
        {
            idade--;
        }

        Console.WriteLine("Idade: " + idade);


Console.WriteLine($"Seu Email:");
string email = Console.ReadLine();

Console.WriteLine($"Telefone:");
string telefone = Console.ReadLine();

Console.WriteLine($"CPF:");
string cpf = Console.ReadLine();

Console.WriteLine($"Endereço:");
string Endereço = Console.ReadLine();

Console.WriteLine($"Estado civil:");
string estatoscivil = Console.ReadLine();

Console.WriteLine($"Obrigada: {nome} {sobrenome} {idade} {dataNascimento} {email} {telefone} {cpf} {Endereço} {estatoscivil}");





