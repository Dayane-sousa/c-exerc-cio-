using System;

class Program
{
    // ==================================================
    // 1. POÇÃO DE VIDA
    // ==================================================
    static int PocaoDeVida(int vidaRecuperada)
    {
        int vidaAtual = 50;
        int resultado = vidaAtual + vidaRecuperada;

        return resultado;
    }
 

    // ==================================================
    // 2. RECOMPENSA POR DERROTAR INIMIGO
    // ==================================================
    static int RecompensaInimigo(int moedasRecebidas)
    {
        int moedasAtuais = 120;

        int resultado = moedasAtuais + moedasRecebidas;

        return resultado;
    }

    // ==================================================
    // 3. DANO RECEBIDO PELO INIMIGO
    // ==================================================
    static int CalcularVidaRestante(int danoCausado)
    {
        int vidaInimigo = 100;

        int resultado = vidaInimigo - danoCausado;

        if (resultado < 0)
        {
            resultado = 0;
        }

        return resultado;
    }

    // ==================================================
    // 4. COMPRA DE ITENS
    // ==================================================
    static int ComprarItem(int precoItem)
    {
        int moedasAtuais = 200;

        if (precoItem < 0 || precoItem > moedasAtuais)
        {
            return moedasAtuais;
        }

        int resultado = moedasAtuais - precoItem;

        return resultado;
    }

    // ==================================================
    // 5. COLETANDO MOEDAS PELO MAPA
    // ==================================================
    static int CalcularPontosMoedas(int moedasColetadas, int pontuacaoAtual)
    {
        for (int i = 1; i <= moedasColetadas; i++)
        {
            pontuacaoAtual += 10;

            Console.WriteLine(
                $"Moeda coletada! Pontuação atual: {pontuacaoAtual}"
            );
        }

        return pontuacaoAtual;
    }

    // ==================================================
    // 6. ATAQUES CONSECUTIVOS
    // ==================================================
    static int CalcularDanoTotal(int quantidadeAtaques)
    {
        int danoTotal = 0;
        int danoPorAtaque = 15;

        for (int i = 1; i <= quantidadeAtaques; i++)
        {
            danoTotal += danoPorAtaque;
        }

        return danoTotal;
    }

    // ==================================================
    // 7. O CHEFE FINAL
    // ==================================================
    static int CalcularAtaquesParaDerrotarChefe(int danoPorAtaque)
    {
        int vidaChefe = 500;
        int quantidadeAtaques = 0;

        if (danoPorAtaque <= 0)
        {
            return 0;
        }

        while (vidaChefe > 0)
        {
            quantidadeAtaques++;

            vidaChefe -= danoPorAtaque;

            Console.WriteLine(
                $"Ataque {quantidadeAtaques}! Vida do chefe: {vidaChefe}"
            );
        }

        Console.WriteLine("Chefe derrotado!");
        Console.WriteLine($"Total de ataques: {quantidadeAtaques}");

        return quantidadeAtaques;
    }

    // ==================================================
    // 8. POÇÕES DE CURA
    // ==================================================
    static int UsarPocao(int vidaAtual, int tipoPocao)
    {
        int cura = 0;

        if (tipoPocao == 1)
        {
            cura = 10;
        }
        else if (tipoPocao == 2)
        {
            cura = 30;
        }
        else if (tipoPocao == 3)
        {
            cura = 60;
        }
        else
        {
            return vidaAtual;
        }

        vidaAtual += cura;

        if (vidaAtual > 100)
        {
            vidaAtual = 100;
        }

        return vidaAtual;
    }

    // ==================================================
    // 9. ESCUDO DO PERSONAGEM
    // ==================================================
    static int CalcularDanoRecebido(int danoInimigo, bool escudoAtivado)
    {
        if (danoInimigo < 0)
        {
            return 0;
        }

        if (escudoAtivado)
        {
            return danoInimigo / 2;
        }
        else
        {
            return danoInimigo;
        }
    }

    // ==================================================
    // 10. CLASSIFICAÇÃO DA RECOMPENSA
    // ==================================================
    static string ClassificarRecompensa(int pontosConquistados)
    {
        if (pontosConquistados < 100)
        {
            return "Bronze";
        }
        else if (pontosConquistados < 500)
        {
            return "Prata";
        }
        else if (pontosConquistados < 1000)
        {
            return "Ouro";
        }
        else
        {
            return "Diamante";
        }
    }

    // ==================================================
    // EXEMPLO 1 - DANO CAUSADO PELO PERSONAGEM
    // ==================================================
    static int CalcularDano(int bonusDano)
    {
        int ataqueBase = 25;

        int resultado = ataqueBase + bonusDano;

        return resultado;
    }

    // ==================================================
    // EXEMPLO 2 - SISTEMA DE PONTUAÇÃO POR MISSÕES
    // ==================================================
    static int AtualizarPontuacao(int pontuacaoJogador, int qtdMissoes)
    {
        for (int i = 1; i <= qtdMissoes; i++)
        {
            pontuacaoJogador += 100;

            Console.WriteLine(
                $"Missão {i} | Pontuação: 100 | Total: {pontuacaoJogador}"
            );
        }

        return pontuacaoJogador;
    }

    // ==================================================
    // EXEMPLO 3 - DIFICULDADE DO INIMIGO
    // ==================================================
    static string ClassificarInimigo(int nivelInimigo)
    {
        if (nivelInimigo <= 0)
        {
            return "Nível inválido";
        }
        else if (nivelInimigo <= 5)
        {
            return "Inimigo Fácil";
        }
        else if (nivelInimigo <= 10)
        {
            return "Inimigo Médio";
        }
        else if (nivelInimigo <= 20)
        {
            return "Inimigo Difícil";
        }
        else
        {
            return "Chefe";
        }
    }

    // ==================================================
    // MÉTODO PRINCIPAL
    // ==================================================
    static void Main(string[] args)
    {
        Console.WriteLine("===== SA GAMES =====");

        Console.WriteLine("\n1. Poção de vida: " + PocaoDeVida(10));

        Console.WriteLine("2. Recompensa: " + RecompensaInimigo(35));

        Console.WriteLine("3. Vida restante do inimigo: " + CalcularVidaRestante(30));

        Console.WriteLine("4. Moedas restantes: " + ComprarItem(75));

        Console.WriteLine("\n5. Coletando moedas:");
        Console.WriteLine("Pontuação final: " + CalcularPontosMoedas(8, 10));

        Console.WriteLine("\n6. Dano total: " + CalcularDanoTotal(4));

        Console.WriteLine("\n7. Batalha contra o chefe:");
        CalcularAtaquesParaDerrotarChefe(15);

        Console.WriteLine("\n8. Vida após poção: " + UsarPocao(80, 2));

        Console.WriteLine("9. Dano recebido: " + CalcularDanoRecebido(40, true));

        Console.WriteLine("10. Recompensa: " + ClassificarRecompensa(750));

        Console.WriteLine("\nExemplo 1 - Dano: " + CalcularDano(15));

        Console.WriteLine("\nExemplo 2 - Pontuação:");
        AtualizarPontuacao(50, 3);

        Console.WriteLine("\nExemplo 3 - Inimigo: " + ClassificarInimigo(15));

        Console.WriteLine("\n===== FIM DO PROGRAMA =====");
    }
}
