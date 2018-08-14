using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Enemigo
    {
        public int PosX;
        public int PosY;


        private int _puntos;
        public int Puntos
        {
            get
            {
                return _puntos;
            }
            set
            {
               if(_puntos < 100)
                {
                    _puntos = 100;
                }
            }
        }


        public void movimiento()
        {

        }

        public void disparo()
        {

        }

        public void explotar()
        {

        }
    }
}
