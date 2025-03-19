

namespace JogoDaForca.ConsoleApp
{
    public class JogoForca
    {
        public static string palavraSecreta;
        public static char[] letrasEncontradas;
        public static int quantidadeDeErros;

        public static void IniciarJogo()
        {
            SortearPalavraSecreta();

            ConfigurarLetrasEncontradas();
        }

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

        public static void ConfigurarLetrasEncontradas() 
        {
            //inicio - input
            letrasEncontradas = new char[palavraSecreta.Length];

            //meio - processamento
            for (int CaractereAtual = 0; CaractereAtual < letrasEncontradas.Length; CaractereAtual++)
            {
                letrasEncontradas[CaractereAtual] = '_';
            }                        
        }

        public static void ExibirForca()
        {            
            string cabecadodesenho = quantidadeDeErros >= 1 ? "o" : "";
            string troncododesenho = quantidadeDeErros >= 2 ? "x" : "";
            string troncoinferiordodesenho = quantidadeDeErros >= 2 ? " x " : "";
            string bracoesquerdododesenho = quantidadeDeErros >= 3 ? "/" : "";
            string bracodireitododesenho = quantidadeDeErros >= 4 ? "\\" : "";
            string pernasdodesenho = quantidadeDeErros >= 5 ? "/ \\" : "";
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
            Console.WriteLine($"Quantidade de erros do jogador: {quantidadeDeErros}");
            Console.WriteLine($"------------------------------");
        }

        public static void VerificarChute(char chute)
        {
            bool letraFoiEncontrada = false;

            for (int ContadorDeCaracteres = 0; ContadorDeCaracteres < palavraSecreta.Length; ContadorDeCaracteres++)
            {
                char CaractereAtual = palavraSecreta[ContadorDeCaracteres];

                if (chute == CaractereAtual)
                {
                    letrasEncontradas[ContadorDeCaracteres] = CaractereAtual;
                    letraFoiEncontrada = true;
                }
            }

            if (letraFoiEncontrada == false)            
                quantidadeDeErros++;            
        }

        public static bool JogadorGanhou()
        {
            string palavraEncontradaCompleta = String.Join("", letrasEncontradas);

            bool jogadorGanhou = palavraEncontradaCompleta == palavraSecreta;

            return jogadorGanhou;
        }

        public static bool JogadorPerdeu()
        {
            bool jogadorPerdeu = quantidadeDeErros >= 5;

            return jogadorPerdeu;
        }

        public static void ApresentarMensagemVitoria()
        {
            Console.WriteLine($"Voce acertou a palavra escolhida {palavraSecreta}, Parabens!");
            Console.ReadLine();
        }

        public static void ApresentarMensagemDerrota()
        {
            Console.WriteLine($"Voce perdeu a palavra escolhida era: {palavraSecreta}");
            Console.ReadLine();
        }

       
    }
}
