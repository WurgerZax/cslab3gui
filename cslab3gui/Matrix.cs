using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cslab3gui
{
    public class Matrix
    {
        const int SIZE = 3;

        int[,] array = new int[SIZE, SIZE];

        byte currentRow = 0, currentColumn = 0;// строки и колонки матриц

        public int matrixSize { get => SIZE; }
        public byte CurrentRow { get => currentRow; }
        public byte CurrentColumn { get => currentColumn; }

        public Matrix(int a = 0)
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    array[i, j] = a;
                }
            }
        }

        public void SetElement(int value)
        {
            if (currentColumn >= SIZE)
            {
                currentColumn = 0;
                currentRow++;
            }

            if (currentRow >= SIZE)
                currentRow = 0;

            array[currentRow, currentColumn++] = value;
        }

        static public Matrix operator +(Matrix matA, Matrix matB)
        {
            Matrix matrix = new Matrix();

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    matrix.array[i, j] = matA.array[i, j] + matB.array[i, j];
                }
            }
            return matrix;
        }

        static public Matrix operator -(Matrix matA, Matrix matB)
        {
            Matrix matMin = new Matrix();

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    matMin.array[i, j] = matA.array[i, j] - matB.array[i, j];
                }
            }
            return matMin;
        }

        static public Matrix operator *(Matrix matA, Matrix matB)
        {
            Matrix MatMult = new Matrix();

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    for (int k = 0; k < SIZE; k++)
                    {
                        MatMult.array[i, j] += matA.array[i, k] * matB.array[k, j];
                    }
                }
            }

            return MatMult;
        }

        static public Matrix operator *(Matrix matA, int digit) // умножение на число
        {
            Matrix matNumber = new Matrix();

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    matNumber.array[i, j] = matA.array[i, j] * digit;
                }
            }
            return matNumber;
        }

        static public Matrix operator *(int digit, Matrix matA) // умножение на число
        {
            Matrix matNumber = new Matrix();

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    matNumber.array[i, j] = matA.array[i, j] * digit;
                }
            }
            return matNumber;
        }

        public bool Check()
        {
            bool result = true;

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (i != j)
                    {
                        if (array[i, j] != 0)
                        {
                            result = false;
                            break;
                        }
                    }
                }
                if (!result)
                    break;
            }

            return result;
        }

        public bool Check0()
        {
            bool result = true;

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (array[i, j] != 0)
                    {
                        result = false;
                        break;
                    }
                }
                if (!result)
                    break;
            }
            return result;
        }

        public bool Check1()
        {
            bool result = true;

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (i == j)
                    {
                        if (array[i, j] != 1)
                        {
                            result = false;
                            break;
                        }
                    }
                    else if (array[i, j] != 0)
                    {
                        result = false;
                        break;
                    }
                }
                if (!result)
                    break;
            }

            return result;
        }

        public override string ToString()
        {
            string line = "";

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    line += array[i, j] + " ";
                }
                line += "\n";
            }

            return line;
        }

        //int dimensionGorizontal;
        //int dimensionVertical;

        // не является диагональной, т.к. не все элементы вне главной диагонали равны нулю
        // не явялется нулевой, т.к. есть элементы не равные нулю 
        // не единичная, т.к. не все элементы главной диагонали равны единице

        // аналогично матрице А

        //int BA = Matrix.Multiply(matrixA, matrixB);
    }
}