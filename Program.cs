using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEjeCartesiano
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(5, 15);
            Punto punto2 = new Punto(-3, 10);
            Punto punto3 = new Punto(-10, -12);
            Punto punto4 = new Punto(-18, 24);
            Punto punto5 = new Punto(3, 9);

            EjeCartesiano cartesiano1 = new EjeCartesiano();
            cartesiano1.AgregarPunto(punto1);
            cartesiano1.AgregarPunto(punto2);
            cartesiano1.AgregarPunto(punto3);
            cartesiano1.AgregarPunto(punto4);
            cartesiano1.AgregarPunto(punto5);
            cartesiano1.MostrarPlanos();
            cartesiano1.MostrarDistancias();
        }
    }
}
