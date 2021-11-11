using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEjeCartesiano
{
    class EjeCartesiano
    {
        public EjeCartesiano()
        {
            ListaPuntos = new Punto[5];
        }
        private Punto[] ListaPuntos { get; set; }

        public void AgregarPunto(Punto punto)
        {
            ListaPuntos[LastIndex()] = punto;
        }

        private int LastIndex()
        {
            for (int index = 0; index < ListaPuntos.Length; index++)
            {
                if (ListaPuntos[index] == null)
                {
                    return index;
                }
            }
            return 0;
        }

        public void MostrarPlanos()
        {
            foreach (Punto punto in ListaPuntos)
            {
                Console.WriteLine(punto.MostrarCoordenadas());
            }
        }

        public void MostrarDistancias()
        {
            //for(int index = 0; index< ListaPuntos.Length - 1; index++)
            //{
            //    LineaRecta lineaAux = new LineaRecta(ListaPuntos[index], ListaPuntos[index+1]);
            //    Console.WriteLine("Para el punto {0} con el punto {1}", index + 1, index+2);
            //    Console.WriteLine(lineaAux.MostrarFuncionesLinea());
            //}
            for (int index = 0; index < ListaPuntos.Length - 1; index++)
            {
                LineaRecta lineaAux = new LineaRecta(ListaPuntos[index], ListaPuntos[index + 1]);
                Console.WriteLine("Para el punto {0} con el punto {1}", index + 1, index + 2);
                Console.WriteLine(lineaAux.MostrarFuncionesLinea());
                for (int index2 = 0; index2 < index; index2++)
                {
                    LineaRecta lineaAux2 = new LineaRecta(ListaPuntos[index2], ListaPuntos[index + 1]);
                    Console.WriteLine("Para el punto {0} con el punto {1}", index2 + 1, index + 2);
                    Console.WriteLine(lineaAux2.MostrarFuncionesLinea());
                }

            }
        }
    }
}
