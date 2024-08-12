using acid.fun.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace acid.fun
{
    public partial class CrosshairOverlay : Form
    {
        public CrosshairOverlay()
        {
            InitializeComponent();
            this.BackColor = Color.Magenta; // Choose any color that is not likely to be used in your application
            this.TransparencyKey = Color.Magenta;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.Bounds.Size;

            this.SetStyle(ControlStyles.Selectable, false);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80020; // WS_EX_LAYERED | WS_EX_TRANSPARENT | WS_EX_NOACTIVATE
                return cp;
            }
        }


        private void CrosshairOverlay_Load(object sender, EventArgs e)
        {

        }

        private void CrosshairOverlay_Paint(object sender, PaintEventArgs e)
        {
            int dotSize = Settings.Default.crossSize; // Adjust the size of the dot as needed
            int crosshairSize = Settings.Default.crossSize; // Adjust the size of the dot as needed

            int yOffset = 14; // Adjust the vertical offset as needed
            Pen pen;

            if (Settings.Default.crossType == "Cross")
            {
                using (pen = new Pen(Color.Red, 2))
                {
                    pen.Color = Settings.Default.crossColor;

                    // Vertical line
                    e.Graphics.DrawLine(pen, this.Width / 2, this.Height / 2 - crosshairSize - yOffset, this.Width / 2, this.Height / 2 + crosshairSize - yOffset);

                    // Horizontal line
                    e.Graphics.DrawLine(pen, this.Width / 2 - crosshairSize, this.Height / 2 - yOffset, this.Width / 2 + crosshairSize, this.Height / 2 - yOffset);
                }
            }
            else
            {
                using (pen = new Pen(Color.Red, 2))
                {
                    // Calculate the top-left corner of the rectangle that will form the dot
                    int x = (this.Width / 2) - (dotSize / 2);
                    int y = (this.Height / 2) - (dotSize / 2) - yOffset;
                    pen.Color = Settings.Default.crossColor;
                    // Draw the dot
                    e.Graphics.FillEllipse(pen.Brush, x, y, dotSize, dotSize);
                }
            }



        }
    }
}
