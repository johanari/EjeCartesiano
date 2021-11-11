using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEjeCartesiano
{
    public class Punto
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }

        //constructor
        public Punto(int coordX, int coordY) //asignar valor a sus propiedades
        {
            CoordX = coordX;
            CoordY = coordY;
        }

        //caracteristicas funcion o metodo
        public string MostrarCoordenadas()
        {
            string plano = "";
            if (CoordX >= 0 && CoordY >= 0)
            {
                plano = "I";
            }
            else if (CoordX < 0 && CoordY >= 0)
            {
                plano = "II";
            }
            else if (CoordX < 0 && CoordY < 0)
            {
                plano = "III";
            }
            else if (CoordX >= 0 && CoordY < 0)
            {
                plano = "IV";
            }
            return string.Format("Mis coordenadas son {0} y {1} y estoy en el plano {2}", CoordX, CoordY, plano);
        }
    }
}
