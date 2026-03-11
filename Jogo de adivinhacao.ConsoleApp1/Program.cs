// Objetivos 

// V1
// 1. Nosso jogo deve aceitar o input do jogador e exibir o valor digitado
// 2. Nosso jogo deve gerar um numero secreto aleatorio
// 3. Nosso jogo deve validar a tentativa do jogador e exibir uma mensagem
// 4. Nosso jogo deve permitir multiplas tentativas

// V2
// 1. Nosso jogo deve implementar a funcionalidade de Dificuldade e Tentativas limitadas
// 2. Nosso jogo deve implementar uma funcionalidade de validaçao de numeros repetidos

using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;

while (true == true)
{
    int[] numerosDigitados = new int[100];
    int contadorNumerosDigitados = 0;
    
    Console.Clear();

    Console.WriteLine("\n------------------------------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Escolha o nivel de dificuldade: ");
    Console.WriteLine("\n------------------------------------------");
    Console.WriteLine("1 - Facil (10 tentativas)");
    Console.WriteLine("2 - Medio (5 tentativas)");
    Console.WriteLine("3 - Dificil (3 tentativas)");
    Console.WriteLine("------------------------------------------");

    Console.Write("\nDigite sua escolha: ");
    string? dificuldade = Console.ReadLine();

    int numeroMaximo;
    int tentativasMaximas;

    switch (dificuldade)
    {
        case "1":
            numeroMaximo = 20;
            tentativasMaximas = 10;
            break;

        case "2":
            numeroMaximo = 50;
            tentativasMaximas = 5;
            break;

        case "3":
            numeroMaximo = 100;
            tentativasMaximas = 3;
            break;

        default:
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Por favor, selecione uma dificuldade valida.");
            Console.Write("Digite ENTER para continuar...");
            Console.ReadLine();
            continue;
    }

    int numeroAleatorio = RandomNumberGenerator.GetInt32(1, numeroMaximo + 1);

    for (int tentativa = 1; tentativa <= tentativasMaximas; tentativa++)
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Tentativa {tentativa} de {tentativasMaximas}.");
        Console.WriteLine("------------------------------------------");

        Console.Write($"\nInforme um número de 1 a {numeroMaximo}: ");
        string? chute = Console.ReadLine();


        int numeroDigitado = Convert.ToInt32(chute);

        bool numeroEstaRepetido = false; 

        for (int contadorNumeros = 0; contadorNumeros < numerosDigitados.Length; contadorNumeros++)
        {
            if (numerosDigitados[contadorNumeros] == numeroDigitado)
            {
                numeroEstaRepetido = true;
                break;
            }
        }

        if (numeroEstaRepetido == true)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Voce ja digitou esse numero, tente novamente.");
            Console.WriteLine("------------------------------------------");
            Console.Write("Digite ENTER para continuar...");
            Console.ReadLine();

            tentativa--;

            continue;
            
        }

        if (contadorNumerosDigitados < numerosDigitados.Length)
        {
            numerosDigitados[contadorNumerosDigitados] = numeroDigitado;

            contadorNumerosDigitados++;
        }

        if (numeroDigitado == numeroAleatorio)
        {
            Console.WriteLine("------------------------------------------");
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
            Console.WriteLine("O numero digitado foi menor que o numero secreto.");
            Console.WriteLine("------------------------------------------");
        } 

        if (tentativa == tentativasMaximas)
        {
            Console.WriteLine($"\nVoce usou todas as suas tentativas! O numero era {numeroAleatorio}.");
            Console.WriteLine("------------------------------------------");
            break;
        }

        Console.WriteLine("\nPressione ENTER para tentar novamente.");
        Console.ReadLine();
    }

    Console.Write("\nDeseja continuar? (S/N): ");
    string? opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar?.ToUpper() != "S")
    {
        break;
    }


}


