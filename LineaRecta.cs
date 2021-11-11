using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEjeCartesiano
{
    public class LineaRecta
    {
        public LineaRecta(Punto punto1, Punto punto2)
        {
            PrimerPunto = punto1;
            SegundoPunto = punto2;

            //aumentamos esto para la tarea
        }
        public LineaRecta()
        {

        }

        public Punto PrimerPunto { get; set; }
        public Punto SegundoPunto { get; set; }

        public double CalcularDistanciaPuntos()
        {
            ////mi formula
            //double distanciaAB = Convert.ToDouble(Math.Sqrt(Math.Pow((SegundoPunto.CoordX - PrimerPunto.CoordX), 2) + Math.Pow((SegundoPunto.CoordY - PrimerPunto.CoordY), 2)));

            //formula del docente
            int difCoordX = SegundoPunto.CoordX - PrimerPunto.CoordX;
            int difCoordY = SegundoPunto.CoordY - PrimerPunto.CoordY;

            double potX = Math.Pow(difCoordX, 2);
            double potY = Math.Pow(difCoordY, 2);

            return Math.Sqrt(potX + potY);
        }
        public double CalcularPendiente()
        {
            int difCoordX = SegundoPunto.CoordX - PrimerPunto.CoordX;
            int difCoordY = SegundoPunto.CoordY - PrimerPunto.CoordY;
            return difCoordY / difCoordX;
        }

        //funciones para mostrar la pendiente y la distancia entre puntos
        public string MostrarFuncionesLinea()
        {
            return string.Format("La distancia entre los puntos de coordenadas ({0},{1}) y ({2},{3}) es {4} y su pendiente es {5}", PrimerPunto.CoordX, PrimerPunto.CoordY, SegundoPunto.CoordX, SegundoPunto.CoordY,
                CalcularDistanciaPuntos(), CalcularPendiente() + "\n");
        }
    }
}
