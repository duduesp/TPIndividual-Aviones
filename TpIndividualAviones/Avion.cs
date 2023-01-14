using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TpIndividualAviones
{
    public abstract class Avion
    {
        #region Propiedades

        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string Azafata { get; set; }
        #endregion

        #region Constructores

        public Avion() { }
        public Avion (string Piloto, string Copiloto, string Azafata)
        {
            this.Piloto = Piloto;
            this.Copiloto = Copiloto;
            this.Azafata = Azafata;
        }
        #endregion

        #region Metodos

        public abstract string Aterriza();
        public abstract string Despega();
        public override string ToString()
        {
            return $"Piloto: {Piloto}, Copiloto: {Copiloto}, Azafata: {Azafata}";
        }


        #endregion
    }
}
