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


        public List<Documento> ListaDocumentos { get => listaDocumentos; }
        public Departamento Locacion { get => locacion; }
        public string Marca { get => marca; }
        public TipoDoc Tipo { get => tipo; }

        public Escaner(string marca, TipoDoc tipo)
        {
            this.marca = marca;
            this.listaDocumentos = new List<Documento>();
            this.tipo = tipo;

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
                return (dc == d);
            }
            return false;    
        }

        public static bool operator !=(Escaner e, Documento d)
        {
            foreach (Documento dc in e.listaDocumentos)
            {
                return !(dc == d);
            }
            return true;
        }

        public static bool operator +(Escaner e, Documento d)
        {
           
                
            if (e != d && d.Estado == Paso.Inicio)
            {
                if(e.tipo == TipoDoc.libro && d is Libro)
                {
                    e.CambiarEstadoDocumento(d);
                    e.listaDocumentos.Add(d);
                    return true;
                }
                else if (e.tipo == TipoDoc.mapa && d is Mapa)
                {
                    e.CambiarEstadoDocumento(d);
                    e.listaDocumentos.Add(d);
                    return true;
                }
                       
            }
            return false;








        }

        public bool CambiarEstadoDocumento(Documento d)
        {
           return  d.AvanzarEstado();
        }

 
    }
}
