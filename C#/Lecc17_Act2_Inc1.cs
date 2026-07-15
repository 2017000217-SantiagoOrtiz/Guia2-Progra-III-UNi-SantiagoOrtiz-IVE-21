internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mI = new int[4, 4];

        for (int nF = 0; nF < 4; nF++)
        {
            for (int nC = 0; nC < 4; nC++)
            {
                if (nF == nC)
                {
                    mI[nF, nC] = 1;
                }
                else
                {
                    mI[nF, nC] = 0;
                }
            }
        }

        Console.WriteLine("Matriz Identidad");
        for (int nF = 0; nF < 4; nF++)
        {
            for (int nC = 0; nC < 4; nC++)
            {
                Console.Write(mI[nF, nC] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}