using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrera
{
    class Carrera
    {

        private Atleta _atleta1;
        private Atleta _atleta2;
        private Random _avance;

        public Carrera(string nombreA1, string nombreA2)
        {
            _atleta1 = new Atleta(nombreA1);
            _atleta2 = new Atleta(nombreA2);
            _avance = new Random(DateTime.Now.Millisecond);
        }

        public void Correr(Atleta atleta)
        {
            int numeroAleatorio = _avance.Next(1, 10);
            if (numeroAleatorio <= 5)
                atleta.Posicion += 2;
            else if (numeroAleatorio <= 8)
                atleta.Posicion += 1;
            else
                atleta.Posicion += 3;
        }

        public String GenerarCarrera()
        {
            String cadena = "";
            while(_atleta1.Posicion < 100 && _atleta2.Posicion < 100)
            {
                Correr(_atleta1);
                cadena += _atleta1.ImprimirPosicion() + Environment.NewLine;
                if (_atleta1.Posicion >= 100)
                {
                    int diferencia = Math.Abs(_atleta1.Posicion - _atleta2.Posicion);
                    if (diferencia > 3)
                        break;
                    else if (_atleta1.Posicion > _atleta2.Posicion)
                    {
                        Correr(_atleta2);
                        cadena += _atleta2.ImprimirPosicion() + Environment.NewLine;
                        break;
                    }
                }

                Correr(_atleta2);
                cadena += _atleta2.ImprimirPosicion() + Environment.NewLine;
                if (_atleta2.Posicion >= 100)
                    break;
            }

            if(_atleta1.Posicion > _atleta2.Posicion)
            {
                cadena += _atleta1.Nombre + " ganó.";
            }
            else
            {
                cadena += _atleta2.Nombre + " ganó.";
            }

            return cadena;
        }
    }
}
