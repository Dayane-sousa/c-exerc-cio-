using System; 

class Program
{
    static void Main(string[] args)
    {

        // ==================================================
        // EXEMPLO TESTE 2 - SISTEMA DE PONTUAÇÃO POR MISSÕES
       // ==================================================

        Console.WriteLine("=== TESTE 2: PONTUAÇÃO POR MISSÕES ===");

        int pontuacaoInicial = 50;
        int qtdMissoes = 3;

        Console.WriteLine($"Pontuação inicial: {pontuacaoInicial}");
        Console.WriteLine($"Quantidade de missões: {qtdMissoes}");
        

        int pontuacaoFinal = AtualizarPontuacao(
            pontuacaoInicial,
            qtdMissoes
        );

        Console.WriteLine();
        Console.WriteLine($"Pontuação final: {pontuacaoFinal}");
        Console.WriteLine();
    
    }
    //calculo
    static int AtualizarPontuacao(int pontuacao, int missoes)
    {
        int pontosPorMissao = 10;

        return pontuacao + (missoes * pontosPorMissao);
    }
}

