using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivo archivo = new Archivo();
            Estructura estructura = new Estructura();
            Display display = new Display();

            bool[,] board = archivo.leerArchivo("board.txt");
            display.ImprimirTablero(board);
        }
    }
}
