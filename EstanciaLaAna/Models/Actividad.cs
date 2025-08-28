
using System.Collections.Generic;

namespace EstanciaLaAna.Models
{
    public abstract class Actividad
    {
        public int Periodo { get; set; }
        public string Descripcion { get; set; }

        protected List<Parcela> lotesAsignados = new List<Parcela>();

        public Actividad(int periodo, string descripcion, Parcela p)
        {
            this.Periodo = periodo;
            this.Descripcion = descripcion;

            
        }

        abstract public double CalcularProduccion();
        abstract public double CalcularRendimiento();

    }
}
