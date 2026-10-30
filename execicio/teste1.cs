using System;

class Program
{
    static void Main(string[] args)
    {
		// ==================================================
        // EXEMPLO TESTE 1 - DANO CAUSADO PELO PERSONAGEM
        // ==================================================
        Console.WriteLine("=== TESTE 1: DANO DO PERSONAGEM ===");

        int bonusDano = 15;
        int ataque = 25;
        int danoTotal = CalcularDano(bonusDano + ataque);

        Console.WriteLine($"Ataque base: 25");
        Console.WriteLine($"Bônus da arma: {bonusDano}");
        Console.WriteLine($"Dano total: {danoTotal}");

    }
    //metodo
     static int CalcularDano(int dano)
    {
        return dano;
    }
}

