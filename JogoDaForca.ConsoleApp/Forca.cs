

namespace JogoDaForca.ConsoleApp
{
    public class Forca
    {
        public static string[] arraydepalavras()
        {
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

            return palavras;
        }
        public static int geradordeindice(string[] palavras)
        {
            Random geradordenumeros = new Random();

            int indiceescolhido = geradordenumeros.Next(palavras.Length);

            return indiceescolhido;
        }

        public static string  palavraEscolhidaa(string[] palavras, int indiceescolhido)
        {
            string palavraEscolhida = palavras[indiceescolhido];

            return palavraEscolhida;

        }

        public   static char[]   Alteradordecaractere(char[] letrasEncontradas)
        {

            for (int CaractereAtual = 0; CaractereAtual < letrasEncontradas.Length; CaractereAtual++)
            {
                letrasEncontradas[CaractereAtual] = '_';
            }

            return letrasEncontradas;
        }

        public static string Menu(int QuantidadeDeErros, char[] letrasEncontradas)
        {
            string menu = "";

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
            return menu;
        }

        public static string InteracaoComOUsuario()
        {
            Console.WriteLine("Digite um caractere");
            string palavra = Console.ReadLine().ToUpper();

            if (palavra.Length > 1)
            {
                Console.WriteLine("Informe apenas um caractere");
                Console.ReadLine();
            }

            return palavra;
        }

        public static (char[],bool)  VerificacaoDeLetraDigitada(string palavraEscolhida, char[] letrasEncontradas, char chute, bool LetraFoiEncontrada)
        {
            for (int ContadorDeCaracteres = 0; ContadorDeCaracteres < palavraEscolhida.Length; ContadorDeCaracteres++)
            {
                char CaractereAtual = palavraEscolhida[ContadorDeCaracteres];

                if (chute == CaractereAtual)
                {
                    letrasEncontradas[ContadorDeCaracteres] = CaractereAtual;
                    LetraFoiEncontrada = true;
                }

            }

            return (letrasEncontradas,LetraFoiEncontrada);

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

        public  static bool  VerificacaoDeVitoria(char[] letrasEncontradas,bool JogadorGanhou, bool JogadorPerdeu, int QuantidadeDeErros, string palavraEscolhida)
        {
            string palavraEncontradaCompleta = String.Join("", letrasEncontradas);

            JogadorGanhou = palavraEncontradaCompleta == palavraEscolhida;

            if (JogadorGanhou)
            {
                Console.WriteLine($"Voce acertou a palavra escolhida {palavraEscolhida}, Parabens!");
                Console.ReadLine();
            }

            return JogadorGanhou;

            
        }

        public static bool VerificacaoDeDerrota(bool JogadorPerdeu, int QuantidadeDeErros, string palavraEscolhida)
        {

            JogadorPerdeu = QuantidadeDeErros > 5;

            if (JogadorPerdeu)
            {
                Console.WriteLine($"Voce perdeuu a palavra escolhida era: {palavraEscolhida}");
                Console.ReadLine();
            }

            return JogadorPerdeu;
        }

    }
}
