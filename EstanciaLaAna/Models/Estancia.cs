using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaLaAna.Models
{
    public class Estancia
    {

        public string Nombre { get; set; }

        public Casco Casco { get; set; }

         ArrayList puestos = new ArrayList();
      

        public Estancia(string nombre,string idCampo,double sup) {
            this.Nombre = nombre;
            this.Casco = new Casco();
            this.Casco.Administrador = "Sin asignar";
            puestos.Add(new Puesto());
            ((Puesto)puestos[0]).Responsable = "Sin asignar"; //esto es el casteo de tipo puesto, porq C# no sabe de que es el object.

            Campo campo = new Campo(idCampo,sup);

            campos.Add(campo);
        }

        #region administrar campos
        ArrayList campos = new ArrayList();

        public Campo AgregarCampos(string identf,double superf) 
        {
            Campo campito = new Campo(identf,superf);
            campos.Add(campito);
            return campito;
        }

        public Campo VerCampo(int idx)
        {
            if (campos != null && idx>= 0 && idx<campos.Count)
            {
                return campos[idx] as Campo;
                
            }
            return null;
        }


        public int VerCantidadCampos()
        {
            if (campos !=null)
            {
                return campos.Count;
            }
            return -1;
        }
        #endregion
    }
}
