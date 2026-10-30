 using System;
 {
    static void Main(string[] args)
    {
        // ==================================================
        // EXEMPLO TESTE 3 - DIFICULDADE DO INIMIGO
        // ==================================================
        Console.WriteLine("=== TESTE 3: DIFICULDADE DO INIMIGO ===");

        int nivel1 = 3;
        int nivel2 = 8;
        int nivel3 = 15;
        int nivel4 = 25;
        int nivel5 = 41;

    Console.WriteLine(
            $"Nível {nivel1}: {ClassificarInimigo(nivel1)}"
        );

        Console.WriteLine(
            $"Nível {nivel2}: {ClassificarInimigo(nivel2)}"
        );

        Console.WriteLine(
            $"Nível {nivel3}: {ClassificarInimigo(nivel3)}"
        );

        Console.WriteLine(
            $"Nível {nivel4}: {ClassificarInimigo(nivel4)}"
        );

        Console.WriteLine(
            $"Nível {nivel5}: {ClassificarInimigo(nivel5)}"
        );

        Console.WriteLine();
    }

        // ==================================================
        // SEUS TESTES
        // ==================================================
    static string ClassificarInimigo(int nivel)
{
    if (nivel <= 5)
        return "Fácil";
    else if (nivel <= 10)
        return "Médio";
    else if (nivel <= 20)
        return "Difícil";
    else if (nivel <= 30)
        return "Muito difícil";
    else
        return "Nível inválido";
}

}