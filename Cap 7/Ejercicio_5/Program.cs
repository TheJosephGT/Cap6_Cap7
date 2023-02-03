using System.Collections;

internal class Program
{
    /*
    Hacer un programa que funcione como
    una agenda telefónica y que guarde el
    nombre de la persona y su número
    telefónico.
    */
    private static void Main(string[] args)
    {
        Hashtable agenda = new Hashtable();

        System.Console.Write($"Ingrese el nombre de la persona: ");
        string nombre = Console.ReadLine();


        System.Console.Write($"Ingrese el numero de telefono: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        agenda.Add(numero, nombre);
    }
}