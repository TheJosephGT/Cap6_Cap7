internal class Program
{

    /*
    Agregar el cálculo del promedio para el
    programa con arreglo jagged.
    */
    private static void Main(string[] args)
    {
        double promedio=0;
        int[][] jaggerArray = new int[1][];
        jaggerArray[0] = new int[3]
        {
            10, 20 ,50
        };



        Console.Clear();
        for(int i=0; i < jaggerArray.Length; i++)
        {
            for(int j=0; j < jaggerArray[i].Length; j++)
            {
                promedio = jaggerArray[i][j] + promedio;
            }
        }
        

        promedio = promedio / jaggerArray[0].Length; 

        System.Console.WriteLine($"El promedio de las edades es de: {promedio}");
    }
}