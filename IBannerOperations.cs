using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal interface IBannerOperations
    {
        public void Clear();//fekete szin
        public void RotateToLeft();//egy pixel balra forgat

        public void RotateToRight();

        public void ShiftToLeft(Color fillColor); //egy pixel balra megy
        public void ShiftToRight(Color fillColor);

        public void DrawLine(int rowIndex, Color drawingColor);

    }
}
