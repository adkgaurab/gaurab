using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Component_I
{
    /// <summary>
    /// class to draw circle
    /// </summary>
    class Circle: Shape
    {
        private int r, x, y;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">origin x- coordinate</param>
        /// <param name="b">origin y- coordinate</param>
        /// <param name="c">radius of circle</param>
        public void saved_values(int a, int b, int c) {
            x = a;
            y = b;
            r = c;
        }
        public override void Draw_shape(Graphics g)
        {
            Pen mew2 = new Pen(Color.Black,2);
            g.DrawEllipse(mew2, x, y, r, r);
        }
    }
}
