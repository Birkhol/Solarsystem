using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solarsystem_Graphic
{

    public partial class Form1 : Form
    {
        
        private Point pos = new(850, 425);

        public Form1()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Brush sol = new SolidBrush(Color.Yellow);

            g.FillEllipse(sol, (this.ClientSize.Width/2), (this.ClientSize.Height/2), 69, 69);

        }

    }
}
