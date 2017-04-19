using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAula
{
    public class Aula
    {
        private int _numero;
        private List<Alumno>_miLista;
        public Aula()
        {
            this._miLista = new List<Alumno>();
        }
        private List<Alumno> miLista
        {
            get { return this._miLista; }
            
        }

    }
}
