internal class Program
{
    private static void Main(string[] args)
    {
        int fila, columna;
        int[,] matriz = new int[4, 4];

        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                matriz[fila, columna] = columna + 1;
            }
        }

        Console.WriteLine("Matriz de columnas");

        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                Console.Write(matriz[fila, columna] + " ");
            }
            Console.WriteLine();
        }
    }
}