using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eyes
{
    public partial class Form1 : Form
    {
        int muisX, muisY; //oogPositieX, oogPositieY, oogFormaat, pupilFormaat;
        // float xPunt, yPunt;

        public Form1()
        {
            //int oogPositieX = 50;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Eyes";
            this.Text = "Eyes";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawEye);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
        }

        private void DrawEye(object sender, PaintEventArgs e)
        {
            int oogPositieX = 50;
            int oogPositieY = 50;
            int oogFormaat = 100;
            int pupilFormaat = 25;

            var (xPunt, yPunt) = berekenOog(oogPositieX, oogPositieY, oogFormaat, pupilFormaat);
            var (xPunt2, yPunt2) = berekenOog(oogPositieX+200, oogPositieY, oogFormaat, pupilFormaat);

            e.Graphics.DrawEllipse(Pens.Black, oogPositieX, oogPositieY, oogFormaat, oogFormaat);
            e.Graphics.FillEllipse(Brushes.Blue, xPunt, yPunt, pupilFormaat, pupilFormaat); 
            
            e.Graphics.DrawEllipse(Pens.Black, oogPositieX+200, oogPositieY, oogFormaat, oogFormaat);
            e.Graphics.FillEllipse(Brushes.Blue, xPunt2, yPunt2, pupilFormaat, pupilFormaat); 
  
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            muisX = e.X;
            muisY = e.Y;
            Invalidate();
        }

        private (float, float) berekenOog(int oogPositieX, int oogPositieY, int oogFormaat, int pupilFormaat) 
        {
            float straalPupil = pupilFormaat / 2;
            float straalOog = oogFormaat / 2;

            float middenOogX = oogPositieX + straalOog;
            float middenOogY = oogPositieY + straalOog;

            float dx = muisX - middenOogX;
            float dy = muisY - middenOogY;
            double d = Math.Sqrt((dy * dy) + (dx * dx));

            double factorOog = (straalOog - straalPupil) / d;

            float yPunt = (float)(factorOog * dy) + middenOogY;
            float xPunt = (float)(factorOog * dx) + middenOogX;

            xPunt = xPunt - straalPupil;
            yPunt = yPunt - straalPupil;

            return (xPunt, yPunt);
        }
    }
}
