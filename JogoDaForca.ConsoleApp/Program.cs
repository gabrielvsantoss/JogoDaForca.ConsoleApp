namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        public static int idade;

        static void Main(string[] args)
        {
            JogoForca.SortearPalavraSecreta();

            char[] letrasEncontradas = JogoForca.ConfigurarArrayLetrasEncontradas();

            int QuantidadeDeErros = 0;
            bool JogadorGanhou = false;
            bool JogadorPerdeu = false;

            do
            {
                JogoForca.ExibirForca(QuantidadeDeErros, letrasEncontradas);

                char chute = ObterChute();

                bool LetraFoiEncontrada = false;

                JogoForca.VerificarLetraDigitada(letrasEncontradas, chute, LetraFoiEncontrada);

                QuantidadeDeErros = JogoForca.VerificacaoDeAcertoOuErro(LetraFoiEncontrada, QuantidadeDeErros);

                JogadorGanhou = JogoForca.VerificacaoDeVitoria(letrasEncontradas, JogadorGanhou, JogadorPerdeu, QuantidadeDeErros);

                JogadorPerdeu = JogoForca.VerificacaoDeDerrota(JogadorPerdeu, QuantidadeDeErros);

            } while (JogadorGanhou == false && JogadorPerdeu == false);

        }

        public static char ObterChute()
        {
            Console.Write("Digite a letra: ");
            string palavra = Console.ReadLine().ToUpper();

            while (palavra.Length > 1)
            {
                Console.WriteLine("Informe apenas um caractere");
                Console.ReadLine();

                Console.Write("Digite a letra: ");
                palavra = Console.ReadLine().ToUpper();
            }

            char chute = palavra[0];

            return chute;
        }
    }
}