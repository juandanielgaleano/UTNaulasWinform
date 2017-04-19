using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAula
{
    public class Alumno
    {
        private eSexo _sexo;
        public eSexo sexo
        {
            set { this.sexo = value; }
            get { return this._sexo; }
        }
        private int _legajo;
        public int legajo
        {
            set { this._legajo = value; }
            get { return this._legajo; }

        }
        private string _nombre;
        public string nombre
        {
            set { this._nombre = value; }
            get { return this._nombre; }
        }
        public Alumno(string nombre, int legajo, eSexo sexo)
        { 

        }
     
        


    }

}
