internal class Program
{
    private static void Main(string[] args)
    {
        int[,] t = new int[4, 3];
        int n, s;

        for (int f = 0; f < 4; f++)
        {
            s = 0; 
            for (int c = 0; c < 3; c++)
            {
                Console.Write($"Ingrese un número para la posición [{f},{c}]: ");
                n = int.Parse(Console.ReadLine());

                t[f, c] = n;
                s += n;
            }

            Console.WriteLine($"La suma de la fila {f + 1} es: {s}");
            Console.WriteLine();
        }
    }
}