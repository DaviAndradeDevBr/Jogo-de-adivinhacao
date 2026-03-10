// Objetivos 

// V1
// 1. Nosso jogo deve aceitar o input do jogador e exibir o valor digitado
// 2. Nosso jogo deve gerar um numero secreto aleatorio
// 3. Nosso jogo deve validar a tentativa do jogador e exibir uma mensagem
// 4. Nosso jogo deve permitir multiplas tentativas

using System;
using System.Security.Cryptography;

while (true == true)
{
    Console.Clear();

    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("------------------------------------------");

    int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

    Console.Write("Informe um número de 1 a 20: ");
    string? chute = Console.ReadLine();


    int numeroDigitado = Convert.ToInt32(chute);

    if (numeroDigitado == numeroAleatorio)
    {
        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine("Parabéns, você acertou!");
        Console.WriteLine("------------------------------------------");
    }

    else if (numeroDigitado > numeroAleatorio)
    {
        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine("O número digitado é maior que o número secreto.");
        Console.WriteLine("------------------------------------------");
    }

    else
    {
        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine("O número digitado é menor que o número secreto.");
        Console.WriteLine("------------------------------------------");
    }


    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();

    Console.Write("\nDeseja continuar? (S/N): ");
    string? opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar?.ToUpper() != "S")
    {
        break;
    }


}


