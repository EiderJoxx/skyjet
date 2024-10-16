using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Vuelo
    {
        public Vuelo() { }

        public Vuelo(string codigo, string procedencia, string destino, DateTime fecha)
        {
            Codigo = codigo;
            Procedencia = procedencia;
            Destino = destino;
            Fecha = fecha;
        }

        public Vuelo(string codigo, string procedencia, string destino, DateTime fecha, int numAsiento)
        {
            Codigo = codigo;
            Procedencia = procedencia;
            Destino = destino;
            Fecha = fecha;
            NumAsiento = numAsiento;
        }

        public string Codigo { get; set; }
        public string Procedencia { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha { get; set; }
        public int NumAsiento { get; set; }
    }
}