internal partial class Program
{

    /*
    Hacer el programa que calcula el
    promedio, calificación máxima y mínima
    de un salón de clases usando el ArrayList.
    
    */
    private static void Main(string[] args)
    {
        List<int> datos = new List<int>();
        double promedio = 0;

        datos.Add(88);
        datos.Add(77);
        datos.Add(71);
        datos.Add(99);

        int calmayor = datos[0];
        int calmenor = datos[0];

        for (int i = 0; i < datos.Count; i++)
        {
            promedio = datos[i] + promedio;

            if(datos[i] > calmayor)
            {
                calmayor = datos[i];
            }

            if(datos[i] < calmenor)
            {
                calmenor = datos[i];
            }
           
        }

        promedio = promedio / datos.Count;

        System.Console.WriteLine($"El promedio es: {promedio}");
        System.Console.WriteLine($"La calificacion mas alta es: {calmayor}");
        System.Console.WriteLine($"La calificacion mas baja es: {calmenor}");



    }
}