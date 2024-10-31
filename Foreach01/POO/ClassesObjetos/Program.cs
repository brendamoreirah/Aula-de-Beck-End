using  System.Net.Http.Headers;
using ClassesObjetos.Classes;

Animal cachorro = new Animal();
Animal gato = new Animal();

cachorro.nome = "Spike";
cachorro.raca = "Sao bernardo";
cachorro.cor = "Caramelo";
cachorro.idade = 3;

Console.WriteLine($"Nome do cachorrinho {cachorro.nome}");
Console.WriteLine($"raca do {cachorro.nome}  {cachorro.raca}");
Console.WriteLine($"cor do {cachorro.nome} {cachorro.cor}");
Console.WriteLine($"idade do {cachorro.nome} {cachorro.idade}");


gato.nome = "Estrela";
gato.raca = "Siamês";
gato.cor = "Caramelo";
gato.idade = 2;

Console.WriteLine($"Nome do gatinho {gato.nome}");
Console.WriteLine($"raca do {gato.nome}  {gato.raca}");
Console.WriteLine($"cor do {gato.nome} {gato.cor}");
Console.WriteLine($"idade do {gato.nome} {gato.idade}");

