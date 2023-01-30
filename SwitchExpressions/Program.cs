namespace SwitchExpressions
{
    internal class Program
    {
        enum Periodo
        {
            M,T,N
        }

        static void Main(string[] args)
        {
            Periodo periodo = Periodo.M;
            string descricao;
            _ = (periodo switch
            { 
                Periodo.M => descricao = "Manha",
                Periodo.T => descricao = "Tarde",
                Periodo.N => descricao = "Noite",
                _ => descricao = "periodo Invalido"
            });
            Console.WriteLine("Periodo Informado: " + descricao);

            
        }
    }
}