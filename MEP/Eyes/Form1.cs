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
        int muisX, muisY, oogPositieX, oogPositieY, oogFormaat, pupilFormaat;
        float xPunt, yPunt;

        public Form1()
        {
    
            InitializeComponent();
        }

        private void DrawEye(object sender, PaintEventArgs e)
        {
            oogPositieX = 50;
            oogPositieY = 50;
            oogFormaat = 100;
            pupilFormaat = 25;

            float straalPupil = pupilFormaat / 2;
            float straalOog = oogFormaat / 2;

            float middenOogX = oogPositieX + straalOog;
            float middenOogY = oogPositieY + straalOog;

            float dx = muisX - middenOogX;
            float dy = muisY - middenOogY;
            double d = Math.Sqrt((dy * dy) + (dx * dx));

            double factorOog = (straalOog - straalPupil) / d;

            yPunt = (float)(factorOog * dy) + middenOogX;
            xPunt = (float)(factorOog * dx) + middenOogY;

            xPunt = xPunt - straalPupil;
            yPunt = yPunt - straalPupil;

            e.Graphics.DrawEllipse(Pens.Black, oogPositieX, oogPositieY, oogFormaat, oogFormaat);
            e.Graphics.FillEllipse(Brushes.Blue, xPunt, yPunt, pupilFormaat, pupilFormaat);            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            muisX = e.X;
            muisY = e.Y;
            Invalidate();
        }
    }
}
