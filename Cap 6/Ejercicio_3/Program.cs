internal partial class Program
{

    /*
    Agregar el cálculo de la mayor
    calificación para el programa con arreglo
    jagged.
    */
    private static void Main(string[] args)
    {
        int[][] jaggerArray = new int[1][];

        jaggerArray[0] = new int[5]
        {
            88, 99, 73, 81, 70
        };

        int calmayor = jaggerArray[0][0];

        for(int i=0; i < jaggerArray.Length; i++)
        {
            for (int j = 0; j < jaggerArray[i].Length; j++)
            {
                if(jaggerArray[i][j] > calmayor)
                {
                    calmayor = jaggerArray[i][j];
                }
            }
        }

        System.Console.WriteLine($"La calificacion mayor es: {calmayor}");
    }
}