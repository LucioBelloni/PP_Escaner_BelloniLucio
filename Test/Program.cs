using Entidades;


namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            int extension;
            int cantidad;
            string resumen;

            Console.WriteLine($"\n################################################# TEST LIBROS #################################################n");

            Escaner escaner_libros = new Escaner("Samsung", TipoDoc.libro);

            //// Libros iguales -> codebar iguales
            Libro libro_1 = new Libro("luces de bohemia", "hugo", 1995, "4565", "22222", 20);
            Libro libro_2 = new Libro("crimen y castigo", "mateo", 1980, "8468", "22222", 30);

            //// Libros iguales -> numNormalizado iguales
            Libro libro_3 = new Libro("100 años de Soledad", "Lucas", 1970, "9611", "44444", 40);
            Libro libro_4 = new Libro("La casa de los espíritus", "Leo", 1985, "9611", "55555", 50);

            //// Libros iguales -> titulo y autor iguales
            Libro libro_5 = new Libro("Preludio a la fundación", "Daniel", 1950, "9846", "66666", 60);
            Libro libro_6 = new Libro("Preludio a la fundación", "Daniel", 1951, "9846", "77777", 70);

            Console.WriteLine($"\n################ estado = True ################\n");
            bool estado_1 = libro_1 == libro_2;
            Console.WriteLine($"estado = {estado_1}");

            Console.WriteLine($"\n################ estado = True ################\n");
            bool estado_2 = libro_3 == libro_4;
            Console.WriteLine($"estado = {estado_2}");

            Console.WriteLine($"\n################ estado = True ################\n");
            bool estado_3 = libro_5 == libro_6;
            Console.WriteLine($"estado = {estado_3}");

            // Agregar libros
            bool ingreso_1 = escaner_libros + libro_1;
            bool ingreso_2 = escaner_libros + libro_3;
            bool ingreso_3 = escaner_libros + libro_5;

            // Agregar libros duplicados
            bool ingreso_4 = escaner_libros + libro_2;
            bool ingreso_5 = escaner_libros + libro_4;
            bool ingreso_6 = escaner_libros + libro_6;

            Console.WriteLine($"\n################ ingreso_1 = True ################\n");
            Console.WriteLine($"ingreso_1 = {ingreso_1}");

            Console.WriteLine($"\n################ ingreso_2 = True ################\n");
            Console.WriteLine($"ingreso_2 = {ingreso_2}");

            Console.WriteLine($"\n################ ingreso_3 = True ################\n");
            Console.WriteLine($"ingreso_3 = {ingreso_3}");

            Console.WriteLine($"\n################ ingreso_4 = False ################\n");
            Console.WriteLine($"ingreso_4 = {ingreso_4}");

            Console.WriteLine($"\n################ ingreso_5 = False ################\n");
            Console.WriteLine($"ingreso_5 = {ingreso_5}");

            Console.WriteLine($"\n################ ingreso_6 = False ################\n");
            Console.WriteLine($"ingreso_6 = {ingreso_6}");

            // Informe libros Distribuidos
            Informes.MostrarDistribuidos(escaner_libros, out extension, out cantidad, out resumen);

            // Cambiar el estado de los libros en escaner de libros
            Console.WriteLine($"\n################ 3 True ################\n");
            Console.WriteLine(escaner_libros.CambiarEstadoDocumento(libro_1));
            Console.WriteLine(escaner_libros.CambiarEstadoDocumento(libro_3));
            Console.WriteLine(escaner_libros.CambiarEstadoDocumento(libro_5));

            // Informe libros EnEscaner
            Informes.MostrarEnEscaner(escaner_libros, out extension, out cantidad, out resumen);

            // Cambiar el estado de los libros en escaner de libros
            Console.WriteLine($"\n################ 3 True ################\n");
            Console.WriteLine(escaner_libros.CambiarEstadoDocumento(libro_1));
            Console.WriteLine(escaner_libros.CambiarEstadoDocumento(libro_3));
            Console.WriteLine(escaner_libros.CambiarEstadoDocumento(libro_5));

            // Informe libros EnRevision
            Informes.MostrarEnRevision(escaner_libros, out extension, out cantidad, out resumen);

            // Cambiar el estado de los libros en escaner de libros
            Console.WriteLine($"\n################ 3 True ################\n");
            Console.WriteLine(escaner_libros.CambiarEstadoDocumento(libro_1));
            Console.WriteLine(escaner_libros.CambiarEstadoDocumento(libro_3));
            Console.WriteLine(escaner_libros.CambiarEstadoDocumento(libro_5));

            // Informe libros Terminados
            Informes.MostrarTerminados(escaner_libros, out extension, out cantidad, out resumen);

            // Cambiar el estado de los libros en escaner de libros
            Console.WriteLine($"\n################ 3 False ################\n");
            Console.WriteLine(escaner_libros.CambiarEstadoDocumento(libro_1));
            Console.WriteLine(escaner_libros.CambiarEstadoDocumento(libro_3));
            Console.WriteLine(escaner_libros.CambiarEstadoDocumento(libro_5));

            // Se le pasa al metodo de cambiar estado (de un escaner de libros) un mapa
            Console.WriteLine($"\n################ estado = False ################\n");
            Mapa mapa = new Mapa("", "", 1, "", "", 1, 1);
            bool estado_4 = escaner_libros.CambiarEstadoDocumento(mapa);
            Console.WriteLine($"estado = {estado_4}");

            // Se le pasa al metodo de cambiar estado (de un escaner de libros) un libro que no se encuentra en la lista
            Console.WriteLine($"\n################ estado = False ################\n");
            Libro libro = new Libro("", "", 2, "", "", 2);
            bool estado_5 = escaner_libros.CambiarEstadoDocumento(libro);
            Console.WriteLine($"estado = {estado_5}");

            Console.WriteLine($"\n################ estado = True ################\n");
            // Se le pasa al metodo de cambiar estado (de un escaner de libros) un libro que se encuentra en la lista
            Libro libro_7 = new Libro("", "", 2, "", "", 2);
            bool ingreso = escaner_libros + libro_7;
            bool estado_6 = escaner_libros.CambiarEstadoDocumento(libro_7);
            Console.WriteLine($"estado = {estado_6}");

            Console.WriteLine($"\n################################################# TEST MAPAS #################################################n");

            Escaner escaner_mapas = new Escaner("Hp", TipoDoc.mapa);

            //// Mapas iguales -> codebar iguales
            Mapa mapa_1 = new Mapa("Mundo", "Instituto de geografia 1", 1995, "", "22222", 20, 70);
            Mapa mapa_2 = new Mapa("Buenos Aires", "Instituto de geografia 2", 1980, "", "22222", 30, 80);

            //// Mapas iguales -> titulo, autor, año, superficie iguales
            Mapa mapa_3 = new Mapa("Cordoba", "Instituto de geografia 3", 1970, "", "44444", 40, 90);
            Mapa mapa_4 = new Mapa("Cordoba", "Instituto de geografia 3", 1970, "", "55555", 40, 90);

            Console.WriteLine($"\n################ estado = True ################\n");
            bool estado_7 = mapa_1 == mapa_2;
            Console.WriteLine($"estado = {estado_7}");

            Console.WriteLine($"\n################ estado = True ################\n");
            bool estado_8 = mapa_3 == mapa_4;
            Console.WriteLine($"estado = {estado_8}");

            // Agregar mapas
            bool ingreso_7 = escaner_mapas + mapa_1;
            bool ingreso_8 = escaner_mapas + mapa_3;

            // Agregar mapas duplicados
            bool ingreso_9 = escaner_mapas + mapa_2;
            bool ingreso_10 = escaner_mapas + mapa_4;

            Console.WriteLine($"\n################ ingreso_7 = True ################\n");
            Console.WriteLine($"ingreso_7 = {ingreso_7}");

            Console.WriteLine($"\n################ ingreso_8 = True ################\n");
            Console.WriteLine($"ingreso_8 = {ingreso_8}");

            Console.WriteLine($"\n################ ingreso_9 = False ################\n");
            Console.WriteLine($"ingreso_9 = {ingreso_9}");

            Console.WriteLine($"\n################ ingreso_10 = False ################\n");
            Console.WriteLine($"ingreso_10 = {ingreso_10}");

            // Informe mapas Distribuidos
            Informes.MostrarDistribuidos(escaner_mapas, out extension, out cantidad, out resumen);

            // Cambiar el estado de los mapas en escaner de mapas
            Console.WriteLine($"\n################ 2 True ################\n");
            Console.WriteLine(escaner_mapas.CambiarEstadoDocumento(mapa_1));
            Console.WriteLine(escaner_mapas.CambiarEstadoDocumento(mapa_3));

            // Informe mapas EnEscaner
            Informes.MostrarEnEscaner(escaner_mapas, out extension, out cantidad, out resumen);

            // Cambiar el estado de los mapas en escaner de mapas
            Console.WriteLine($"\n################ 2 True ################\n");
            Console.WriteLine(escaner_mapas.CambiarEstadoDocumento(mapa_1));
            Console.WriteLine(escaner_mapas.CambiarEstadoDocumento(mapa_3));

            // Informe mapas EnRevision
            Informes.MostrarEnRevision(escaner_mapas, out extension, out cantidad, out resumen);

            // Cambiar el estado de los mapas en escaner de mapas
            Console.WriteLine($"\n################ 2 True ################\n");
            Console.WriteLine(escaner_mapas.CambiarEstadoDocumento(mapa_1));
            Console.WriteLine(escaner_mapas.CambiarEstadoDocumento(mapa_3));

            // Informe mapas Terminados
            Informes.MostrarTerminados(escaner_mapas, out extension, out cantidad, out resumen);

            // Cambiar el estado de los mapas en escaner de mapas
            Console.WriteLine($"\n################ 2 False ################\n");
            Console.WriteLine(escaner_mapas.CambiarEstadoDocumento(mapa_1));
            Console.WriteLine(escaner_mapas.CambiarEstadoDocumento(mapa_3));

            // Se le pasa al metodo de cambiar estado (de un escaner de mapas) un libro
            Console.WriteLine($"\n################ estado = False ################\n");
            Libro libro_ = new Libro("", "", 2, "", "", 2);
            bool estado_9 = escaner_mapas.CambiarEstadoDocumento(libro_);
            Console.WriteLine($"estado = {estado_9}");

            // Se le pasa al metodo de cambiar estado (de un escaner de mapas) un mapa que no se encuentra en la lista
            Console.WriteLine($"\n################ estado = False ################\n");
            Mapa mapa_ = new Mapa("", "", 1, "", "", 1, 1);
            bool estado_10 = escaner_mapas.CambiarEstadoDocumento(libro);
            Console.WriteLine($"estado = {estado_10}");

            // Se le pasa al metodo de cambiar estado (de un escaner de mapas) un mapa que se encuentra en la lista
            Console.WriteLine($"\n################ estado = True ################\n");
            Mapa mapa_5 = new Mapa("", "", 1, "", "", 1, 1);
            bool ingreso_ = escaner_mapas + mapa_5;
            bool estado_11 = escaner_mapas.CambiarEstadoDocumento(mapa_5);
            Console.WriteLine($"estado = {estado_11}");



















            /*
            Escaner escaner1 = new Escaner("subaru", TipoDoc.libro);
            Escaner escaner2 = new Escaner("Mitsubishi", TipoDoc.mapa);
            Escaner escaner3 = new Escaner("putita", TipoDoc.mapa);
            Libro libro1 = new Libro("donquikote", "lucio", 10, "120", "02020", 20);
            Libro libro2 = new Libro("mancha", "nicolas", 1910, "121", "03030", 20);
            Libro libro3 = new Libro("mancha", "nicolas", 1910, "121", "03030", 20);
            Libro libro4 = new Libro("mancha", "nicolas", 1910, "121", "03030", 20);

            Mapa mapa1 = new Mapa("America Latina", "Americo", 1520, "122", "04040", 10, 15);
            Mapa mapa2 = new Mapa("Argentina", "Gardel", 1810, "123", "05050", 20, 25);
            Mapa mapa3 = new Mapa("Argentina", "Gardel", 1810, "123", "05050", 20, 25);



            Console.WriteLine(escaner1 + mapa1);
            Console.WriteLine(escaner1 + libro1);
            Console.WriteLine(escaner1 + libro2);
            Console.WriteLine(escaner1 + libro1);
            Console.WriteLine(escaner1 + mapa1);
            Console.WriteLine(escaner1 + mapa2);
            Console.WriteLine(escaner1 + mapa2);
            Console.WriteLine(escaner1 + mapa3);


            foreach (Documento dc in escaner1.ListaDocumentos)
            {
                Console.WriteLine(dc.ToString());
            }
            */

            /*
            Console.WriteLine(libro1.ToString());
            Console.WriteLine(escaner1 + libro1);
            Console.WriteLine(escaner1 + libro2);
            Console.WriteLine(escaner1 + libro1);
            Console.WriteLine(escaner2 + mapa1);
            Console.WriteLine($"{escaner2 + mapa2}\n");
            Console.WriteLine(libro1.ToString());
            Console.WriteLine(mapa1.ToString());

      
            Informes.MostrarDistribuidos(escaner2, out int extension, out int cantidad, out string resumen);
            Console.WriteLine($"\nextension: {extension}");
            Console.WriteLine($"cantidad: {cantidad}");
            Console.WriteLine($"{resumen}");
            */



            //Informes.MostrarDistribuidos(escaner1, out int extension, out int cantidad, out string resumen);
            //Console.WriteLine($"\nextension: {extension}");
            //Console.WriteLine($"cantidad: {cantidad}");
            //Console.WriteLine($"{resumen}");






        }
    }
}
