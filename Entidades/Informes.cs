using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static  class Informes
    {
        public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e,Paso.Distribuido, out extension, out cantidad, out resumen);
        }

        private static void MostrarDocumentosPorEstado(Escaner e, Paso estado, out int extension, out int cantidad, out string resumen)
        {
            extension = 0;
            cantidad = 0;
            StringBuilder sb = new StringBuilder();

            foreach (Documento dc in e.ListaDocumentos)
            {
                if (dc.Estado == estado)
                {
                    cantidad++;
                    if (dc is Libro libro)
                    {
                        extension += libro.NumPaginas;
                    }
                    else if (dc is Mapa mapa)
                    {
                        extension += mapa.Superficie;
                    }
                    else
                    {
                        sb.AppendLine("No se pudo un libro,ni mapa");
                    }
                    sb.AppendLine(dc.ToString());
                }
                else
                {
                    sb.AppendLine("El estado es distinto");
                }
            }
            resumen = sb.ToString();
        }

        
        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Paso.EnEscaner, out extension, out cantidad, out resumen);
        }

        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Paso.EnRevision, out extension, out cantidad, out resumen);
        }

        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Paso.Terminado, out extension, out cantidad, out resumen);
        }


    }
}
