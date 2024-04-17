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

        private void DrawRectangle(PaintEventArgs e)
        {
            int rectWidth = 300;
            int rectHeight = 200;

            int rectX = (Size.Width / 2) - rectWidth;
            int rectY = (Size.Height / 2);

            var gp = new GraphicsPath();
            var rc = new Rectangle(rectX, rectY, rectWidth, rectHeight);
            gp.AddRectangle(rc);

            e.Graphics.FillRegion(Brushes.Black, new Region(gp));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawRectangle(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}