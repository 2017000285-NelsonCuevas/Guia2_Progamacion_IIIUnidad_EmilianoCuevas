internal class Program
{
    private static void Main(string[] args)
    {
        int fila, columna, mayor, x, y;
        int[,] tabla = new int[4, 4];

        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                Console.Write("Ingrese un numero: ");
                tabla[fila, columna] = Convert.ToInt32(Console.ReadLine());
            }
        }

        mayor = tabla[0, 0];
        x = 0;
        y = 0;

        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                if (tabla[fila, columna] > mayor)
                {
                    mayor = tabla[fila, columna];
                    x = fila;
                    y = columna;
                }
            }
        }

        Console.WriteLine("El numero mayor es: " + mayor);
        Console.WriteLine("Esta en la fila: " + (x + 1));
        Console.WriteLine("Esta en la columna: " + (y + 1));
    }
}
