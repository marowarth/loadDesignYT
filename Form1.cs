namespace loadDesignYT
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
            panelNavBar.MouseDown += PanelNavBar_MouseDown;
            panelNavBar.MouseUp += PanelNavBar_MouseUp;
            panelNavBar.MouseMove += PanelNavBar_MouseMove;
        }
        private void PanelNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void PanelNavBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void PanelNavBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = PointToScreen(p1);
                Point p3 = new Point(p2.X - startPoint.X, p2.Y - startPoint.Y);
                Location = p3;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}