using System;

class Program
{
    static void Main()
    {
        // Variáveis para armazenar o nome e a quantidade de experiência (XP) do herói
        Console.Write("Digite o nome do herói: ");
        string? nome = Console.ReadLine();
        if (nome == null)
        {
            Console.WriteLine("Nome não pode ser nulo.");
            return;
        }

        Console.Write("Digite a quantidade de experiência (XP) do herói: ");
        string? xpInput = Console.ReadLine();
        if (xpInput == null || !int.TryParse(xpInput, out int xp))
        {
            Console.WriteLine("XP inválido.");
            return;
        }

        // Variável para armazenar o nível do herói
        string nivel;

        // Estrutura de decisão para determinar o nível do herói com base na XP
        if (xp < 1000)
        {
            nivel = "Ferro";
        }
        else if (xp <= 2000)
        {
            nivel = "Bronze";
        }
        else if (xp <= 5000)
        {
            nivel = "Prata";
        }
        else if (xp <= 7000)
        {
            nivel = "Ouro";
        }
        else if (xp <= 8000)
        {
            nivel = "Platina";
        }
        else if (xp <= 9000)
        {
            nivel = "Ascendente";
        }
        else if (xp <= 10000)
        {
            nivel = "Imortal";
        }
        else
        {
            nivel = "Radiante";
        }

        // Exibindo a mensagem final
        Console.WriteLine($"O Herói de nome {nome} está no nível de {nivel}");
    }
}