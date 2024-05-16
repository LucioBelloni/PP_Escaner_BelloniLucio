using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento
    {
        private int alto;
        private int ancho;

        public int Alto { get => alto;}
        public int Ancho { get => ancho;}
        public int Superficie { get => alto * ancho; }

        public Mapa(string titulo, string autor, int anio, string numNormalizado, string barcode, int alto , int ancho) : base(titulo, autor, anio, numNormalizado, barcode)
        {
            this.alto = alto;
            this.ancho = ancho;
            numNormalizado = "Los mapas No tienen numero ";
        }


        public static bool operator ==(Mapa m1, Mapa m2)
        {
            return m1.Barcode == m2.Barcode || (m1.Titulo == m2.Titulo &&  m1.Autor == m2.Autor && m1.Anio == m2.Anio && m1.Superficie == m2.Superficie);
        }

        public static bool operator !=(Mapa m1, Mapa m2)
        {
            return !(m1.Barcode == m2.Barcode || (m1.Titulo == m2.Titulo && m1.Autor == m2.Autor && m1.Anio == m2.Anio && m1.Superficie == m2.Superficie));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"El alto es: {this.alto}");
            sb.AppendLine($"El ancho es: {this.ancho}");
            sb.AppendLine($"Supericie: {this.Superficie} =   cm2"); // aca falta la cuenta xd 
            return sb.ToString();
        }

    }
}
