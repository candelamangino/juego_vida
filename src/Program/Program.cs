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
            // La clase Archivo es responsable de leer el archivo y cargar el estado inicial del tablero.
            Archivo archivo = new Archivo();
            // Lee el archivo y obtener el tablero inicial.
            bool[,] program = archivo.LeerArchivo("board.txt");
            // La clase Estructura es responsable de procesar las reglas del juego y la logica.
            Estructura estructura = new Estructura();
            // La clase Display es responsable de mostrar el estado del tablero maneja solo la visualización.
            Display display = new Display();
            while (true)
            {
                // Procesa la siguiente generación del tablero.
                program = estructura.procesarGeneracion(program);
                //Imprime el tablero.
                display.ImprimirTablero(program);
            }
        }
    }
}
