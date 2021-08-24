using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    public class Number4
    {
        private int[,] squareMatrix;
        private int columnLength = 0;
        private int rowsLength = 0;
        private int positionColumn = 0;
        private int positionRow = 0;
        
        public void SetMatrixSize(int columnLength, int rowsLength)
        {
            this.columnLength = columnLength;
            this.rowsLength = rowsLength;
            squareMatrix = new int[columnLength, rowsLength];
            Console.WriteLine(squareMatrix[0, 0]);
        }

        public void AddElement(int number)
        {
            //Console.WriteLine(squareMatrix[0,0]);
            squareMatrix[positionColumn, positionRow] = number;
            if (positionColumn < columnLength - 1)
            {
                positionColumn++;
            }
            else
            {
                positionColumn = 0;
                positionRow++;
            }
        }

        public void ShowMatrixOnTheScreen()
        {
            for(int i = 0; i < columnLength; i++)
            {
                for(int j = 0; j < rowsLength; j++)
                {
                    Console.Write(squareMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
