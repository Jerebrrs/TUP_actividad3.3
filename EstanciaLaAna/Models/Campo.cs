using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaLaAna.Models
{
    public class Campo
    {
        public string Identificador { get; set; }
        public double Superficie { get; set; }
        public Campo(string identificador, double superficie)
        {
            this.Identificador = identificador;
            this.Superficie = superficie;
        }
    }
}
