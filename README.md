# Jogo de Adivinhação 🎯


## Visão Geral 

O sistema consiste em um desafio de lógica onde o usuário deve descobrir um valor oculto através de palpites estratégicos, utilizando uma interface simples via console.

## Detalhes 🔍
O objetivo principal é identificar o número secreto respeitando o limite de jogadas disponíveis. A dificuldade selecionada define o nível de desafio da partida, exigindo que o jogador utilize o raciocínio lógico e as orientações do sistema para vencer antes que suas chances acabem.

Os níveis de dificuldade são: 

🟢 **Fácil** = 15 chances 

🟡 **Médio** = 10 chances 

🔴 **Difícil** = 5 chances

##  Interação 🎮
Os jogadores interagem por meio do console, digitando números e recebendo feedback instantâneo sobre suas escolhas. O jogo termina quando o usuário adivinha o número secreto ou quando as chances se encerram.

## Principais funcionalidades 🛠️

**Geração de Número Secreto**: No início de cada jogo, um número secreto é gerado aleatoriamente entre 1 e 20.

**Seleção de Dificuldade**: Os jogadores podem escolher entre três níveis de dificuldade (Fácil, Médio, Difícil), que influenciam o número de tentativas disponíveis.

**Feedback Instantâneo**: Após cada tentativa, o jogo fornece feedback indicando se o número escolhido é maior ou menor que o número secreto.



## Instruções de Uso 💻

1.  Obtenha o código via clone de repositório ou download do arquivo `.zip`.
2.  Acesse o diretório raiz através do terminal.
3.  Execute a restauração dos pacotes do projeto:
    ```bash
    dotnet restore
    ```
4.  Inicie a aplicação:
    ```bash
    dotnet run --project JogoDeAdivinhacao.


## Requisitos de Sistema

.NET SDK 10.0 ou superior.
