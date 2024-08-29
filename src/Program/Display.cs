using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class Display // Esta clase es la experta en la visualización del tablero y mostrarlo en la consola.
{ 
    public void ImprimirTablero(bool[,] board) // ImprimirTablero es responsable de mostrar el tablero en la consola, maneja la visualización, no la lógica del juego.
    {
        int width = board.GetLength(0); //variabe que representa el ancho del tablero
        int height = board.GetLength(1); //variabe que representa altura del tablero
       
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(board[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            // Pausa antes de calcular y mostrar la siguiente generación.
            Thread.Sleep(300);
            // Calcular la siguiente generación del tablero.
            // Delegar la responsabilidad a la clase Estructura que es experta en la lógica del juego.
            board = new Estructura().procesarGeneracion(board);
        } 
    }
}