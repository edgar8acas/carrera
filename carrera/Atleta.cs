using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrera
{
    class Atleta
    {
        private String _nombre;
        private int _posicion;

        public String Nombre
        {
            get { return _nombre; }
        }

        public int Posicion
        {
            get { return _posicion; }
            set { _posicion = value; }
        }

        public Atleta(String nombre)
        {
            _nombre = nombre;
            _posicion = 0;
        }

        public String ImprimirPosicion()
        {
            return _nombre + " está en " + _posicion;
        }


    }
}
