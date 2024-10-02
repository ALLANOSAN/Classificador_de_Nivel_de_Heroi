using System;

class Program
{
    static void Main()
    {
        // Variáveis para armazenar o nome e a quantidade de experiência (XP) do herói
        string? nome;
        

        // Solicita o nome do herói
        Console.Write("Digite o nome do herói: ");
        nome = Console.ReadLine();
        if (nome == null)
        {
            Console.WriteLine("Nome não pode ser nulo.");
            return;
        }

        // Solicita a quantidade de XP do herói
        Console.Write("Digite a quantidade de experiência (XP) do herói: ");
        string? xpEntrada = Console.ReadLine();
        if (xpEntrada == null || !int.TryParse(xpEntrada, out int xp))
        {
            Console.WriteLine("XP inválido.");
            return;
        }

        // Variável para armazenar o nível do herói
        string nivel;

        // Estrutura de decisão para determinar o nível do herói com base no XP
        if (xp < 1000)
        {
            nivel = "Ferro";
        }
        else if (xp >= 1001 && xp <= 2000)
        {
            nivel = "Bronze";
        }
        else if (xp >= 2001 && xp <= 5000)
        {
            nivel = "Prata";
        }
        else if (xp >= 5001 && xp <= 7000)
        {
            nivel = "Ouro";
        }
        else if (xp >= 7001 && xp <= 8000)
        {
            nivel = "Platina";
        }
        else if (xp >= 8001 && xp <= 9000)
        {
            nivel = "Ascendente";
        }
        else if (xp >= 9001 && xp <= 10000)
        {
            nivel = "Imortal";
        }
        else
        {
            nivel = "Radiante";
        }

        // Exibe a mensagem com o nome e o nível do herói
        Console.WriteLine($"O Herói de nome {nome} está no nível de {nivel}");
    }
}
