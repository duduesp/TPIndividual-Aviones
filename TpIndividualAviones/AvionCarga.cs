using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpIndividualAviones
{
    public class AvionCarga: Avion
    {
        #region Propiedades
        public float Peso { get; set; }
        public string TipoDeCarga { get; set; }

        #endregion

        #region Constructores

        public AvionCarga() { }
        public AvionCarga(string Piloto, string Copiloto, string Azafata, float peso, string tipoDeCarga):base(Piloto, Copiloto, Azafata)
        {
            this.Peso = peso;
            this.TipoDeCarga = tipoDeCarga;
        }

        #endregion

        #region Métodos

        public override string Aterriza()
        {
            return "El avión de carga aterriza";
        }
        public override string Despega()
        {
            return "El avión de carga despega";
        }
        public override string ToString()
        {
            return base.ToString() + $", Peso; {Peso}kg, Tipo de carga: {TipoDeCarga}";
        }

        #endregion
    }
}
