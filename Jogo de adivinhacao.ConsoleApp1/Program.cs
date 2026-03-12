// Objetivos 

// V1
// 1. Nosso jogo deve aceitar o input do jogador e exibir o valor digitado
// 2. Nosso jogo deve gerar um número secreto aleatório
// 3. Nosso jogo deve validar a tentativa do jogador e exibir uma mensagem
// 4. Nosso jogo deve permitir múltiplas tentativas

// V2
// 1. Nosso jogo deve implementar a funcionalidade de Dificuldade e Tentativas limitadas
// 2. Nosso jogo deve implementar uma funcionalidade de validação de números repetidos
// 3. Nosso jogo deve implementar uma funcionalidade de Pontuaçao

using System;

using System.Security.Cryptography;


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // 1. Desenha a tela de menu e espera o input do usuário (dificuldade)
            string? dificuldadeEscolhida = ExibirMenuEscolhaDificuldade();

            // 2. Configuração do Jogo
            int[] configuracoes = ConfigurarPartida(dificuldadeEscolhida);

            int numeroMaximo = configuracoes[0];
            int tentativasMaximas = configuracoes[1];

            if (tentativasMaximas == 0)
            {
                continue;
            }

            // 3. Execução do Jogo
            ExecutarPartida(numeroMaximo, tentativasMaximas);

            // 4. Pergunta se o jogador vai continuar o jogo
            if (!JogadorDesejaContinuar())
                break;
        }
    }

    static string? ExibirMenuEscolhaDificuldade()
    {
        Console.Clear();

        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine("Jogo de Adivinhação");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Escolha o nível de dificuldade: ");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("1 - Fácil (10 tentativas)");
        Console.WriteLine("2 - Médio (5 tentativas)");
        Console.WriteLine("3 - Difícil (3 tentativas)");
        Console.WriteLine("------------------------------------------");

        Console.Write("\nDigite sua escolha: ");
        string? dificuldade = Console.ReadLine();

        return dificuldade;
    }

    static int[] ConfigurarPartida(string? dificuldadeEscolhida)
    {
        int numeroMaximo = 0;
        int tentativasMaximas = 0;

        switch (dificuldadeEscolhida)
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
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Por favor, selecione uma dificuldade válida.");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();
                break;

        }

        int[] configuracoes = new int[2];

        configuracoes[0] = numeroMaximo;
        configuracoes[1] = tentativasMaximas;

        return configuracoes;

    }

    static void ExecutarPartida(int numeroMaximo, int tentativasMaximas)
    {
        int[] numerosDigitados = new int[tentativasMaximas];
        int contadorNumerosDigitados = 0;
        int pontuacao = 1000;

        int numeroAleatorio = RandomNumberGenerator.GetInt32(1, numeroMaximo + 1);

        for (int tentativa = 1; tentativa <= tentativasMaximas; tentativa++)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Tentativa {tentativa} de {tentativasMaximas}.");
            Console.WriteLine("------------------------------------------");

            Console.Write($"Informe um número de 1 a {numeroMaximo}: ");
            string? chute = Console.ReadLine();


            int numeroDigitado = Convert.ToInt32(chute);

            bool numeroEstaRepetido = false;

            for (int indiceChecado = 0; indiceChecado < numerosDigitados.Length; indiceChecado++)
            {
                if (numerosDigitados[indiceChecado] == numeroDigitado)
                {
                    numeroEstaRepetido = true;
                    break;
                }
            }

            if (numeroEstaRepetido == true)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Você já digitou esse número, tente novamente.");
                Console.WriteLine("------------------------------------------");
                Console.Write("\nPressione ENTER para continuar...");
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

                break;
            }

            else if (numeroDigitado > numeroAleatorio)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("O número digitado é maior que o número secreto.");
                Console.WriteLine("------------------------------------------");
            }

            else
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("O número digitado é menor que o número secreto.");
                Console.WriteLine("------------------------------------------");
            }

            int diferencaNumerica = Math.Abs(numeroAleatorio - numeroDigitado);

            if (diferencaNumerica >= 10)
            {
                pontuacao -= 100;
            }

            else if (diferencaNumerica >= 5)
            {
                pontuacao -= 50;
            }

            else
            {
                pontuacao -= 20;
            }

            Console.WriteLine("Sua pontuação é: " + pontuacao);
            Console.WriteLine("------------------------------------------");
            Console.Write("\nPressione ENTER para continuar...");
            Console.ReadLine();

            if (tentativa == tentativasMaximas)
            {
                Console.WriteLine($"Você usou todas as suas tentativas! O número era {numeroAleatorio}.");
                Console.WriteLine("------------------------------------------");
                break;
            }
        }
    }

    static bool JogadorDesejaContinuar()
    {
        Console.Write("\nDeseja continuar? (S/N): ");
        string? opcaoContinuar = Console.ReadLine();

        if (opcaoContinuar?.ToUpper() != "S")
            return false;


        return true;
    }


}


