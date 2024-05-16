using Entidades;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {

            Libro libro1 = new Libro( "donquikote","lucio",1900, "120", "123", 20);
            Libro libro2 = new Libro("donquikote", "lucio", 1900, "120", "123", 20);
            Libro libro3 = new Libro("donquikote", "lucio", 1900, "120", "321", 20);
            Libro libro4 = new Libro("donquikote", "lucio", 1900, "120", "111", 20);



            Console.WriteLine(libro1 == libro2); // True, mismo Barcode
            Console.WriteLine(libro1 == libro3); // True, mismo ISBN
            Console.WriteLine(libro1 == libro4); // True, mismo Titulo y Autor
            Console.WriteLine(libro2 == libro3); // False, no cumplen ninguno de los criterios





            /*Documento documento = new Documento("xd","a",10,"as","asd");

            while (documento.AvanzarEstado())
            {
                Console.WriteLine($"Estado Actual: {documento.Estado}");
            }

            bool resultado = documento.AvanzarEstado();
            Console.WriteLine($"Intentar avanzar después de terminado: {resultado}");
            */
        }
    }
}
