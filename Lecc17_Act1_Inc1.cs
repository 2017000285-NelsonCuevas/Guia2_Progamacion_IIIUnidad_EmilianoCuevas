internal class Program
{
    private static void Main(string[] args)
    {
        string[,] donas = new string[2, 4];
        int fila, columna;

        donas[0, 0] = "Chocolate";
        donas[0, 1] = "Fresa";
        donas[0, 2] = "Vainilla";
        donas[0, 3] = "Glaseada";

        donas[1, 0] = "Caramelo";
        donas[1, 1] = "Cafe";
        donas[1, 2] = "Limon";
        donas[1, 3] = "Canela";

        for (fila = 0; fila < 2; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                Console.Write(donas[fila, columna] + " | ");
            }
            Console.WriteLine();
        }
    }
}