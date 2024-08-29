using System.IO;
using System.Text;

namespace Ucu.Poo.GameOfLife;

public class Archivo // Esta clase es la experta en leer y convertir el texto en un tablero. 
{
    public bool[,] LeerArchivo(string url) // LeerArchivo lee el archivo y lo convierte en una matriz booleana.
    {
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        for (int y = 0; y < contentLines.Length; y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if (contentLines[y][x] == '1')
                {
                    board[x, y] = true;
                }
            }
        }

        return board;
    }
}