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
            this.BackColor = Color.Yellow;
            this.Paint += Teken;
        }

        public void Teken(object o, PaintEventArgs pea) 
        {
            pea.Graphics.DrawLine(Pens.Red, 20, 20, 40, 60);
            pea.Graphics.DrawEllipse(Pens.Black, 100, 30, 30, 100);
            pea.Graphics.DrawLine(new Pen(Color.Red, 5), 20, 50, 50, 100);
        
        }

    }
}
