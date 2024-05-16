using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escaner
    {
        private List<Documento> listaDocumentos;
        private Departamento locacion;
        private string marca;
        private TipoDoc tipo;

        public Escaner(string marca, TipoDoc tipo)
        {
            this.marca = marca;
            this.listaDocumentos = new List<Documento>();
            if (TipoDoc.mapa == tipo)
            {
                this.locacion = Departamento.mapoteca;
            }
            else
            {
                this.locacion = Departamento.procesosTecnicos;
            }

            
        }

        public static bool operator ==(Escaner e, Documento d)
        {
            foreach (Documento dc in e.listaDocumentos)
            {
                if (dc == d) return true;
            }
            return false;    
        }

        public static bool operator !=(Escaner e, Documento d)
        {
            foreach (Documento dc in e.listaDocumentos)
            {
                if (!(dc == d)) return true;
            }
            return false;
        }

        public static bool operator +(Escaner e, Documento d)
        {

        }

        public List<Documento> ListaDocumentos { get => listaDocumentos;}
        public Departamento Locacion { get => locacion; }
        public string Marca { get => marca;}
        public TipoDoc Tipo { get => tipo; }
    }
}
