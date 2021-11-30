using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSampe
{
    class Triangle
    {
        private float bottom;
        private float height;
        private float[] sideLength = new float[3];
        private float surface;
        /// <summary>
        /// 三角形
        /// </summary>
        /// <param name="b">底辺</param>
        /// <param name="h">高さ</param>
        public Triangle(float b, float h)
        {
            this.bottom =b;
            this.height = h;
            surface = bottom * height / 2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="side1">辺の長さＡ</param>
        /// <param name="side2">辺の長さＢ</param>
        /// <param name="side3">辺の長さＣ</param>
        public Triangle(float side1, float side2, float side3)
        {
            this.sideLength[0] = side1;
            this.sideLength[1] = side2;
            this.sideLength[2] = side3;
            float s = (sideLength[0] + sideLength[1] + sideLength[2]) / 2;
            surface = MathF.Sqrt(s * (s - sideLength[0]) * (s - sideLength[1]) * (s - sideLength[2]));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>面積</returns>
        public float GetSurface()
        {
            return surface;
        }

    }
}
