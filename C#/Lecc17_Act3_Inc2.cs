internal class Program
{
    private static void Main(string[] args)
    {
        int[,] t = new int[4, 4];
        int f, c, m, x = 0, yy = 0;

        for (f = 0; f < 4; f++)
        {
            for (c = 0; c < 3; c++)
            {
                Console.Write($"Ingrese un número para la posición [{f + 1},{c + 1}]: ");
                t[f, c] = int.Parse(Console.ReadLine());
            }
        }

        m = t[0, 0];
        x = 0;
        yy = 0;

        for (f = 0; f < 4; f++)
        {
            for (c = 0; c < 4; c++)
            {
                if (t[f, c] > m)
                {
                    m = t[f, c];
                    x = f;
                    yy = c;
                }
            }
        }

        Console.WriteLine($"El número mayor es: {m}");
        Console.WriteLine($"Está en la fila: {x + 1}");
        Console.WriteLine($"Y en la columna: {yy + 1}");
    }
}