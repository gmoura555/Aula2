namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] alunos = { "Guilherme", "Romulo", "Jhony",
                              "Paulo", "Vinicius", "Fernando" };

            foreach (var aluno in alunos)
            {
                Console.WriteLine("aluno: " + aluno.ToUpper());
            }
        }
    }
}