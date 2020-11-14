using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.BackColor = Color.White;
            this.Paint += teken;
        }

        public void teken(object o, PaintEventArgs pea) 
        {
            float startAngle = 0.0F;
            float sweepAngle = 180.0F;

            int positie = 20;

            pea.Graphics.FillEllipse(Brushes.Yellow, positie, positie, 100, 100);
            pea.Graphics.FillEllipse(Brushes.White, positie+20, positie+20, 20, 20);
            pea.Graphics.FillEllipse(Brushes.White, positie+60, positie+20, 20, 20);
            pea.Graphics.DrawEllipse(Pens.Black, positie+20, positie+20, 20, 20);
            pea.Graphics.DrawEllipse(Pens.Black, positie+60, positie+20, 20, 20);
            pea.Graphics.DrawEllipse(Pens.Black, positie, positie, 100, 100);
            pea.Graphics.DrawArc(Pens.Black, getRect(positie), startAngle, sweepAngle);


        }

        public Rectangle getRect(int positie) 
        {
            Rectangle rect = new Rectangle(positie+25, positie+50, 50, 30);
            return rect;
        }

    }
}
