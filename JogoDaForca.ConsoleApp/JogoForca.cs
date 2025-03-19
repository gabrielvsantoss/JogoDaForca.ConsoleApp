

namespace JogoDaForca.ConsoleApp
{
    public class JogoForca
    {
        public static string palavraSecreta;

        public static void SortearPalavraSecreta()
        {
            //inicio - input
            string[] palavras = {
                    "ABACATE",
                    "ABACAXI",
                    "ACEROLA",
                    "ACAI",
                    "ARACA",
                    "ABACATE",
                    "BACABA",
                    "BACURI",
                    "BANANA",
                    "CAJA",
                    "CAJU",
                    "CARAMBOLA",
                    "CUPUACU",
                    "GRAVIOLA",
                    "GOIABA",
                    "JABUTICABA",
                    "JENIPAPO",
                    "MACA",
                    "MANGABA",
                    "MANGA",
                    "MARACUJA",
                    "MURICI",
                    "PEQUI",
                    "PITANGA",
                    "PITAYA",
                    "SAPOTI",
                    "TANGERINA",
                    "UMBU",
                    "UVA",
                    "UVAIA"
                };

            //meio - processamento
            Random geradorNumeros = new Random();            

            int indiceEscolhido = geradorNumeros.Next(palavras.Length);

            palavraSecreta = palavras[indiceEscolhido];
        }

        public static char[] ConfigurarArrayLetrasEncontradas() 
        {
            //inicio - input
            char[] letrasEncontradas = new char[palavraSecreta.Length];

            //meio - processamento
            for (int CaractereAtual = 0; CaractereAtual < letrasEncontradas.Length; CaractereAtual++)
            {
                letrasEncontradas[CaractereAtual] = '_';
            }

            //fim - output
            return letrasEncontradas;
        }

        public static void ExibirForca(int QuantidadeDeErros, char[] letrasEncontradas)
        {            
            string cabecadodesenho = QuantidadeDeErros >= 1 ? "o" : "";
            string troncododesenho = QuantidadeDeErros >= 2 ? "x" : "";
            string troncoinferiordodesenho = QuantidadeDeErros >= 2 ? " x " : "";
            string bracoesquerdododesenho = QuantidadeDeErros >= 3 ? "/" : "";
            string bracodireitododesenho = QuantidadeDeErros >= 4 ? "\\" : "";
            string pernasdodesenho = QuantidadeDeErros >= 5 ? "/ \\" : "";
            Console.Clear();

            string LetrasEncontradasCompleta = string.Join(" ", letrasEncontradas);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |         {0}      ", cabecadodesenho);
            Console.WriteLine(" |        {0}{1}{2} ", bracoesquerdododesenho, troncododesenho, bracodireitododesenho);
            Console.WriteLine(" |        {0}       ", troncoinferiordodesenho);
            Console.WriteLine(" |        {0}       ", pernasdodesenho);
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"palavra escolhida: {LetrasEncontradasCompleta}");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"Quantidade de erros do jogador: {QuantidadeDeErros}");
            Console.WriteLine($"------------------------------");
        }

        public static bool VerificarLetraDigitada(char[] letrasEncontradas, char chute, bool LetraFoiEncontrada)
        {
            for (int ContadorDeCaracteres = 0; ContadorDeCaracteres < palavraSecreta.Length; ContadorDeCaracteres++)
            {
                char CaractereAtual = palavraSecreta[ContadorDeCaracteres];

                if (chute == CaractereAtual)
                {
                    letrasEncontradas[ContadorDeCaracteres] = CaractereAtual;
                    LetraFoiEncontrada = true;
                }
            }

            return LetraFoiEncontrada;

        }

        public static bool LetraFoiEncontradaa(char[] letrasencontradas, bool LetraFoiEncontrada)
        {
            return LetraFoiEncontrada;
        }

        public static int VerificacaoDeAcertoOuErro(bool LetraFoiEncontrada, int QuantidadeDeErros)
        {

            if (LetraFoiEncontrada == false)
            {
                QuantidadeDeErros++;
            }

            return QuantidadeDeErros;

        }

        public static bool VerificacaoDeVitoria(char[] letrasEncontradas, bool JogadorGanhou, bool JogadorPerdeu, int QuantidadeDeErros)
        {
            string palavraEncontradaCompleta = String.Join("", letrasEncontradas);

            JogadorGanhou = palavraEncontradaCompleta == palavraSecreta;

            if (JogadorGanhou)
            {
                Console.WriteLine($"Voce acertou a palavra escolhida {palavraSecreta}, Parabens!");
                Console.ReadLine();
            }

            return JogadorGanhou;


        }

        public static bool VerificacaoDeDerrota(bool JogadorPerdeu, int QuantidadeDeErros)
        {

            JogadorPerdeu = QuantidadeDeErros > 5;

            if (JogadorPerdeu)
            {
                Console.WriteLine($"Voce perdeuu a palavra escolhida era: {palavraSecreta}");
                Console.ReadLine();
            }

            return JogadorPerdeu;
        }

    }
}
