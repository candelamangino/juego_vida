using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class Display
{
    public void ImprimirTablero(bool[,] board)
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
            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================
            Thread.Sleep(300);
            board = new Estructura().procesarGeneracion(board);
        } 
    }
}