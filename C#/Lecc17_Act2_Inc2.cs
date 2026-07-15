internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mC = new int[4, 4];

        for (int nF = 0; nF < 4; nF++)
        {
            for (int nC = 0; nC < 4; nC++)
            {
                mC[nF, nC] = nC + 1;
            }
        }

        Console.WriteLine("Matriz Columnas");
        for (int nF = 0; nF < 4; nF++)
        {
            for (int nC = 0; nC < 4; nC++)
            {
                Console.Write(mC[nF, nC] + " ");
            }
            Console.WriteLine();
        }
    }
}