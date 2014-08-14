using System;
using System.Drawing;
using System.Windows.Forms;

namespace AngelCalculation
{
    public partial class Form1 : Form
    {
        private Pen linePen = Pens.Red;
        private readonly Point center;
        private Point endPoint;
        private readonly Random random;

        public Form1()
        {
            InitializeComponent();

            pbCanvas.BackColor = Color.White;
            pbCanvas.Paint += pbCanvas_Paint;
            center = new Point(pbCanvas.Width/2, pbCanvas.Height/2);
            endPoint = center;
            random = new Random();
            tbAngle.Text = "90";
            tbLower.Text = "0";
            tbUpper.Text = "180";
        }

        void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, center.X, center.Y, 1 , 1);
            g.DrawLine(linePen, center, endPoint);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            endPoint = GetRandomAnglePoint(int.Parse(tbLower.Text), int.Parse(tbUpper.Text));
            linePen = Pens.DarkGreen;
            pbCanvas.Invalidate();
        }

        private void btnDraw_Click(object sender, EventArgs e) {
            endPoint = GetAngledPoint(int.Parse(tbAngle.Text));
            linePen = Pens.BlueViolet;
            pbCanvas.Invalidate();
        }

        private Point GetAngledPoint(int degrees) {
            double angle = Math.PI * degrees / 180.0;
            double sinAngle = Math.Sin(angle);
            double cosAngle = Math.Cos(angle);

            double xAngle = sinAngle;
            double yAngle = cosAngle;

            double speed = 100; // in this case the distance to the target point

            return new Point((int)(center.X + (speed * xAngle)), (int)(center.Y + (speed * yAngle)));
        }

        private Point GetRandomAnglePoint(int lowerBound, int upperBound) {
            int degrees = random.Next(lowerBound, upperBound);
            return GetAngledPoint(degrees);
        }
    }
}
