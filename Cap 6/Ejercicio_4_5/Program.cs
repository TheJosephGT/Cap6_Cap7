internal partial class Program
{

    /*
    4 Modificar el programa de la escuela para
    que utilice funciones.

    5 Crear un programa que pase un arreglo
    jagged como parámetro a una función.
    
    */
    private static void Main(string[] args)
    {
        int[][] jaggerArray = new int[1][];

        jaggerArray[0] = new int[5]
        {
            88, 99, 73, 81, 70
        };

        System.Console.WriteLine($"La calificacion mayor es: {Mayor(jaggerArray)}");
    }

    public static int Mayor(int[][] jaggerArray)
    {
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

        return calmayor;
    }
}