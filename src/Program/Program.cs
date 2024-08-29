using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivo archivo = new Archivo();
            bool[,] program = archivo.LeerArchivo("board.txt");
            Estructura estructura = new Estructura();
            Display display = new Display();
            while (true)
            {
                program = estructura.procesarGeneracion(program);
                display.ImprimirTablero(program);
            }
        }
    }
}
