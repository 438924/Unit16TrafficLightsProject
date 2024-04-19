using System.Drawing.Drawing2D;
using System.Transactions;

namespace Unit16TrafficLightsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drawTopEllipse1(PaintEventArgs e)
        {
            var gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(110, 15, 150, 150);
            var r = new System.Drawing.Region(gp);
            Graphics gr = e.Graphics;
            gr.FillRegion(Brushes.Gray, r);
        }

        private void drawMiddleEllipse1(PaintEventArgs e)
        {
            var gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(110, 15, 150, 150);
            var r = new System.Drawing.Region(gp);
            Graphics gr = e.Graphics;
            gr.FillRegion(Brushes.Gray, r);
        }

        private void drawBottomEllipse1(PaintEventArgs e)
        {
            var gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(110, 15, 150, 150);
            var r = new System.Drawing.Region(gp);
            Graphics gr = e.Graphics;
            gr.FillRegion(Brushes.Gray, r);
        }

        private void drawRectangle1(PaintEventArgs e)
        {
            var gp = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rc = new Rectangle(50, 40, 250, 500);
            gp.AddRectangle(rc);
            var r = new System.Drawing.Region(gp);
            Graphics gr = e.Graphics;
            gr.FillRegion(Brushes.Black, r);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawRectangle1(e);
            drawTopEllipse1(e);
            drawMiddleEllipse1(e);
            drawBottomEllipse1(e);
     
        }
    }
}