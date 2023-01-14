using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpIndividualAviones
{
    public class AvionComercial:Avion
    {
        #region Propiedades
        public int Capacidad { get; set; }
        public string Empresa { get; set; }
        #endregion

        #region Constructores

        public AvionComercial() { }
        public AvionComercial(string Piloto, string Copiloto, string Azafata, int Capacidad, string Empresa): base(Piloto, Copiloto, Azafata)
        {
            this.Capacidad= Capacidad;
            this.Empresa= Empresa;
        }
        #endregion

        #region Métodos 

        public override string Aterriza()
        {
            return "El avión comercial aterriza";
        }
        public override string Despega()
        {
            return "El avión comercial despega";
        }
        public override string ToString()
        {
            return base.ToString() + $", Capacidad: {Capacidad}, Empresa: {Empresa}";
        }



        #endregion
    }
}
