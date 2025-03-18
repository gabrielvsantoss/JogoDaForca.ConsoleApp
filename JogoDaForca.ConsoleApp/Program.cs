namespace JogoDaForcaConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
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

            Random geradordenumeros = new Random();

            int indiceescolhido = geradordenumeros.Next(palavras.Length);
            string palavraEscolhida = palavras[indiceescolhido];

            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int CaractereAtual = 0; CaractereAtual < letrasEncontradas.Length; CaractereAtual++)
            {
                letrasEncontradas[CaractereAtual] = '_';
            }

            int QuantidadeDeErros = 0;
            bool JogadorAcertou = false;
            bool JogadorPerdeu = false;

            do
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

                Console.WriteLine("Digite um caractere");
                string palavra = Console.ReadLine().ToUpper();

                if (palavra.Length > 1)
                {
                    Console.WriteLine("Informe apenas um caractere");
                    continue;
                }
                bool LetraFoiEncontrada = false;
                char chute = palavra[0];

                for (int ContadorDeCaracteres = 0; ContadorDeCaracteres < palavraEscolhida.Length; ContadorDeCaracteres++)
                {
                    char CaractereAtual = palavraEscolhida[ContadorDeCaracteres];

                    if (chute == CaractereAtual)
                    {
                        letrasEncontradas[ContadorDeCaracteres] = CaractereAtual;
                        LetraFoiEncontrada = true;
                    }
                }
                if (LetraFoiEncontrada == false)
                {
                    QuantidadeDeErros++;
                }
                string palavraEncontradaCompleta = String.Join("", letrasEncontradas);

                JogadorAcertou = palavraEncontradaCompleta == palavraEscolhida;
                JogadorPerdeu = QuantidadeDeErros > 5;

                if (JogadorAcertou)
                {
                    Console.WriteLine($"Voce acertou a palavra escolhida {palavraEscolhida}, Parabens!");
                    Console.ReadLine();
                }

                if (JogadorPerdeu)
                {
                    Console.WriteLine($"Voce perdeuu a palavra escolalalhida era: {palavraEscolhida}");
                    Console.ReadLine();
                }


            } while (JogadorAcertou == false && JogadorPerdeu == false);

        }
    }
}