

using System.Collections;

internal class Program
{
    /*
    
    Hacer un programa que funcione como un
    diccionario, con palabra y definición,
    usando el Hashtable.
    
    */
    private static void Main(string[] args)
    {
            Hashtable diccionario = new Hashtable();

            diccionario.Add("lapiz", "utensilio para escribir");
            diccionario.Add("pc", "computadora");
            diccionario.Add("messi", "el mejor del mundo");

            try
            {
                Console.WriteLine($"El significado de PC es: {diccionario["pc"]}");
            }
            catch (Exception)
            {
                Console.WriteLine("No existe esa palabra!");
            }


    }
}