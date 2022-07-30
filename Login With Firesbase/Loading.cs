using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Login_Sample
{
    [DefaultEvent("click")]
    public partial class Loading : Form
    {
        int size = 20;
        float distance = 45;
        Color clor1 = Color.Blue, clor2 = Color.Orange;
        Timer t = new Timer();
        string txt = "Authenticating using firebase";
        public Loading()
        {
            InitializeComponent();
            DoubleBuffered = true;
            t.Interval = 60;
            t.Start();
            t.Tick += (s, e) => {
                angle = angle % 360 + 1;
            };
            ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public float angle
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
                Invalidate();
            }
        }
        public int Borderradius
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(new Rectangle(0, 0, size, size), 180, 90);
            gp.AddArc(new Rectangle(Width - size, 0, size, size), -90, 90);
            gp.AddArc(new Rectangle(Width - size, Height - size, size, size), 0, 90);
            gp.AddArc(new Rectangle(0, Height - size, size, size), 90, 90);
            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, clor1, clor2, distance), gp);
            e.Graphics.DrawString(txt, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat()
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            });
            base.OnPaint(e);
        }
        public Color Color
        {
            get
            {
                return clor1;
            }
            set
            {
                clor1 = value;
                Invalidate();
            }
        }
        public Color Color1
        {
            get
            {
                return clor2;
            }
            set
            {
                clor2 = value;
                Invalidate();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            new Timer
            {
                Enabled = true,
                Interval = 1000
            }.Tick += (s, ex) =>
            {
                ((Timer)s).Enabled = false;
                Dashboard DAsh = new Dashboard();
                DAsh.Show();
                this.Hide();
            };
        }
    }
}
