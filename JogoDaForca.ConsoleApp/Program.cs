namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = Forca.arraydepalavras();
            int indiceescolhido = Forca.geradordeindice(palavras);
            string palavraEscolhida = Forca.palavraEscolhidaa(palavras, indiceescolhido);
            char[] letrasEncontradas = new char[palavraEscolhida.Length];
            letrasEncontradas = Forca.Alteradordecaractere(letrasEncontradas);
            int QuantidadeDeErros = 0;
            bool JogadorGanhou = false;
            bool JogadorPerdeu = false;

            do
            {
                Forca.Menu(QuantidadeDeErros, letrasEncontradas);
                string palavra = Forca.InteracaoComOUsuario();
                bool LetraFoiEncontrada = false;
                char chute = palavra[0];

                (letrasEncontradas, LetraFoiEncontrada) = Forca.VerificacaoDeLetraDigitada(palavraEscolhida,letrasEncontradas,chute,LetraFoiEncontrada);

                QuantidadeDeErros = Forca.VerificacaoDeAcertoOuErro(LetraFoiEncontrada, QuantidadeDeErros);

                JogadorGanhou = Forca.VerificacaoDeVitoria(letrasEncontradas, JogadorGanhou, JogadorPerdeu, QuantidadeDeErros, palavraEscolhida);
                JogadorPerdeu = Forca.VerificacaoDeDerrota(JogadorPerdeu,QuantidadeDeErros,palavraEscolhida);



            } while (JogadorGanhou == false && JogadorPerdeu == false);

        }
    }
}