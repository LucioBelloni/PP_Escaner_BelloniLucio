using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entidades
{
    public abstract class Documento
    {
        private int anio;
        private string autor;
        private string barcode;
        private Paso estado;
        private string numNormalizado;
        private string titulo;

        public enum Paso
        {
            Inicio,
            Distribuido,
            EnEscaner,
            EnRevision,
            Terminado
        }

        public int Anio { get => anio; }
        public string Autor { get => autor; }
        public string Barcode { get => barcode; }
        public Paso Estado { get => estado; }
        protected string NumNormalizado { get => numNormalizado; }
        public string Titulo { get => titulo; }

        public Documento(string titulo, string autor, int anio, string numNormalizado, string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.numNormalizado = numNormalizado;
            this.barcode = barcode;
            this.estado = Paso.Inicio;
        }

        public bool AvanzarEstado()
        {
            switch (Estado)
            {
                case Paso.Inicio:
                    estado = Paso.Distribuido;
                    break;
                case Paso.Distribuido:
                    estado = Paso.EnEscaner;
                    break;
                case Paso.EnEscaner:
                    estado = Paso.EnRevision;
                    break;
                case Paso.EnRevision:
                    estado = Paso.Terminado;
                    break;
                default:
                    return false;

            }
            return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Titulo: {this.titulo} ");
            sb.AppendLine($"Autor: {this.autor} ");
            sb.AppendLine($"Año: {this.anio} ");
            sb.AppendLine($"Cód. de barras: {this.barcode} ");
            sb.AppendLine($"Número de páginas: {this.numNormalizado} ");
            sb.AppendLine($"Estado: {this.estado} ");

            return sb.ToString();
        }





    }
}
