using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Component_I
{
    /// <summary>
    /// class to draw Rectangle
    /// </summary>
    class Rectangle:Shape
    {
        private int x, y, w, h;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">origin x- coordinate</param>
        /// <param name="b">origin y- corordinate</param>
        /// <param name="c">width of the rectangle</param>
        /// <param name="d">height of the rectangle</param>
        public void saved_values(int a, int b, int c, int d)
        {
            x = a;
            y = b;
            w = c;
            h = d;
        }
        /// <summary>
        /// overriding
        /// </summary>
        /// <param name="g">object for graphics</param>
        public override void Draw_shape(Graphics g)
        {
            Pen mew3 = new Pen(Color.Black, 2);
            g.DrawRectangle(mew3, x, y, w, h);
        }
    }
}
