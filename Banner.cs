using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Banner : ABanner, IBannerOperations
    {
        public Banner(int rowNum, int columnNum) : base(rowNum, columnNum) { }

        public Banner() : base() { }
        void IBannerOperations.Clear()
        {
            for (int i = 0; i < RowNum; i++)
            {
                for (int j = 0; j < ColumnNum; j++)
                {
                    this[i, j] = Color.Black; 
                }
            }
        }

        void IBannerOperations.DrawLine(int rowIndex, Color drawingColor)
        {
            if (rowIndex < 0 || rowIndex >= RowNum)
                throw new ArgumentOutOfRangeException(nameof(rowIndex), "sor indexen kivul");

            for (int j = 0; j < ColumnNum; j++)
            {
                this[rowIndex, j] = drawingColor; 
            }
        }

        void IBannerOperations.RotateToLeft()
        {
            Color[,] newPixel = new Color[RowNum, ColumnNum];
            for (int i = 0; i < RowNum; i++)
            {
                for (int j = 0; j < ColumnNum; j++)
                {
                    newPixel[i, j] = this[RowNum - i - 1, ColumnNum - j - 1]; 
                }
            }
            pixel = newPixel;
        }

        void IBannerOperations.RotateToRight()
        {
            Color[,] newPixel = new Color[RowNum, ColumnNum];
            for (int i = 0; i < RowNum; i++)
            {
                for (int j = 0; j < ColumnNum; j++)
                {
                    newPixel[i, j] = this[RowNum - i - 1, ColumnNum - j - 1]; 
                }
            }
            pixel = newPixel;
        }


        void IBannerOperations.ShiftToLeft(Color fillColor)
        {
            for (int i = 0; i < RowNum; i++)
            {
                for (int j = 1; j < ColumnNum; j++)
                {
                    this[i, j - 1] = this[i, j]; 
                }
                this[i, ColumnNum - 1] = fillColor; 
            }
        }

        void IBannerOperations.ShiftToRight(Color fillColor)
        {
            for (int i = 0; i < RowNum; i++)
            {
                for (int j = ColumnNum - 1; j > 0; j--)
                {
                    this[i, j] = this[i, j - 1]; 
                }
                this[i, 0] = fillColor; 
            }
        }
    }
}

