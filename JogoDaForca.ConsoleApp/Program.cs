namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JogoForca.IniciarJogo();

            while (true)
            {
                JogoForca.ExibirForca();

                char chute = ObterChuteUsuario();

                JogoForca.VerificarChute(chute);

                if (JogoForca.JogadorGanhou())
                {
                    JogoForca.ApresentarMensagemVitoria();
                    break;
                }
                else if (JogoForca.JogadorPerdeu())
                {
                    JogoForca.ApresentarMensagemDerrota();
                    break;
                }
            } 
        }

        public static char ObterChuteUsuario()
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