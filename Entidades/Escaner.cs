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

        public enum Departamento
        {
            nulo,
            mapoteca,
            procesosTecnicos
        }
        public enum TipoDoc
        {
            libro,
            mapa
        }

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

        public bool CambiarEstadoDocumento(Documento d)
        {
           if( this == d)
           {
                if(d is Libro && this.locacion == Departamento.mapoteca)
                {
                    return false;
                }
                else if (d is Mapa && this.locacion == Departamento.procesosTecnicos)
                {
                    return false;
                }
                else return d.AvanzarEstado();
           }
            return false;
        }


        public static bool operator ==(Escaner e, Documento d)
        {
            foreach (Documento dc in e.listaDocumentos)
            {
                if (dc is Mapa mapa && d is Mapa mapa2)
                {
                    if (mapa == mapa2)
                    {
                        return true;
                    }
                }
                else if (dc is Libro libro && d is Libro libro2)
                {
                    if (libro == libro2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Escaner e, Documento d)
        {
            return !(e == d);
        }

        public static bool operator +(Escaner e, Documento d)
        {
           
            if (e != d && d.Estado ==  Documento.Paso.Inicio)
            {
                if(e.tipo == TipoDoc.libro && d is Libro)
                {
                    e.listaDocumentos.Add(d);
                    e.CambiarEstadoDocumento(d);
                    return true;
                }
                else if (e.tipo == TipoDoc.mapa && d is Mapa)
                {
                    e.listaDocumentos.Add(d);
                    e.CambiarEstadoDocumento(d);
                    return true;
                }
                       
            }
            return false;

        }
    }
}
