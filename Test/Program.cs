using Entidades;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {

            Escaner escaner1 = new Escaner("subaru", TipoDoc.libro);
            Escaner escaner2 = new Escaner("Mitsubishi", TipoDoc.mapa);
            Libro libro1 = new Libro("donquikote", "lucio", 1900, "120", "02020", 20);
            Libro libro2 = new Libro("mancha", "nicolas", 1910, "121", "03030", 20);
            Mapa mapa1 = new Mapa("America Latina", "Americo", 1520, "122", "04040", 10, 15);
            Mapa mapa2 = new Mapa("Argentina", "Gardel", 1810, "123", "05050", 20, 25);

            Console.WriteLine(libro1.ToString());
            Console.WriteLine(escaner1 + libro1);
            Console.WriteLine(escaner1 + libro2);
            Console.WriteLine(escaner1 + libro1);
            Console.WriteLine(escaner2 + mapa1);
            Console.WriteLine($"{escaner2 + mapa2}\n");
            Console.WriteLine(libro1.ToString());
            Console.WriteLine(mapa1.ToString());
            //Informes.MostrarDistribuidos(escaner1, out int extension, out int cantidad, out string resumen);
            //Console.WriteLine($"\nextension: {extension}");
            //Console.WriteLine($"cantidad: {cantidad}");
            //Console.WriteLine($"{resumen}");





            /*Libro libro1 = new Libro("donquikote", "lucio", 1900, "120", "123", 20);
            Libro libro2 = new Libro("donquikote", "lucio", 1900, "120", "123", 20);
            Libro libro3 = new Libro("donquikote", "lucio", 1900, "120", "321", 20);
            Libro libro4 = new Libro("donquikote", "lucio", 1900, "120", "111", 20);



            Console.WriteLine(libro1 == libro2); // True, mismo Barcode
            Console.WriteLine(libro1 == libro3); // True, mismo ISBN
            Console.WriteLine(libro1 == libro4); // True, mismo Titulo y Autor
            Console.WriteLine(libro2 == libro3); // False, no cumplen ninguno de los criterios*/

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
