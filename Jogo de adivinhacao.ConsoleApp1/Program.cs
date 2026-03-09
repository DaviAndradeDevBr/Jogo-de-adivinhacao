// Objetivos 
// 1. Nosso jogo deve aceitar o input do jogador e exibir o valor digitado
// 2. Nosso jogo deve gerar um numero secreto aleatorio
// 3. Nosso jogo deve validar a tentativa do jogador e exibir uma mensagem

Console.WriteLine("------------------------------------------");
Console.WriteLine("Jogo de adivinhaçao");
Console.WriteLine("------------------------------------------");

Console.Write("Digite um número de 1 a 20: ");
string? chute = Console.ReadLine();

Console.WriteLine("O valor digitado foi: " + chute);

Console.ReadLine();
