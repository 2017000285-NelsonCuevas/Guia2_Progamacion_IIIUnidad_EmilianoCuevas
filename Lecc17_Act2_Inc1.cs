internal class Program
{
    private static void Main(string[] args)
    {
        int fila, columna;
        int[,] matrizIdentidad = new int[4, 4];

        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                if (fila == columna)
                {
                    matrizIdentidad[fila, columna] = 1;
                }
                else
                {
                    matrizIdentidad[fila, columna] = 0;
                }
            }
        }

        Console.WriteLine("Matriz Identidad");

        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                Console.Write(matrizIdentidad[fila, columna] + " ");
            }
            Console.WriteLine();
        }
    }
}
