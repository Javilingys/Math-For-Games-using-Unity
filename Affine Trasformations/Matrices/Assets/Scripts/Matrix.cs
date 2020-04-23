using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Matrix
{
    float[] values;
    int rows;
    int cols;

    public Matrix(int r, int c, float[] v)
    {
        rows = r;
        cols = c;
        values = new float[rows * cols];
        Array.Copy(v, values, rows * cols);
    }

    public override string ToString()
    {
        string matrix = "";

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                matrix += values[r * cols + c] + " ";
            }
            matrix += "\n";
        }

        return matrix;
    }

    static public Matrix operator + (Matrix a, Matrix b)
    {
        if (a.rows != b.rows || a.cols != b.cols)
        {
            return null;
        }
        Matrix result = new Matrix(a.rows, a.cols, a.values);
        int length = a.rows * a.cols;
        for (int i = 0; i < length; i++)
        {
            result.values[i] += b.values[i];
        }
        return result;
    }
}
