using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prismatik_LedStrip_Config {
    public partial class F_Preview : Form {

        public Label[]pixels = new Label[256];
        public int npixels;

        public F_Preview() {
            InitializeComponent();
        }

        public void resize(int Height, int Width) {
            if (Width > 0 && Height > 0) { this.Size = new Size(Width, Height); }
        }

        public void createPixel(int i, int x, int y, int sx, int sy) {
            this.Controls.Remove(pixels[i]);
           pixels[i] = new Label();
           pixels[i].Location = new Point(x,y);
           pixels[i].Width = sx;
           pixels[i].Height = sy;

           pixels[i].Text = (i+1).ToString();
           pixels[i].BackColor = Color.FromKnownColor(KnownColor.DarkGray);
           pixels[i].ForeColor = Color.FromKnownColor(KnownColor.White);
           pixels[i].BorderStyle = BorderStyle.Fixed3D;

            //this.Controls.Add(pixels[i]);
            this.Controls.Add(pixels[i]);
        }

        public void unfocus() {
            for (int j = 0; j < npixels; j++) {
                pixels[j].ForeColor = Color.FromKnownColor(KnownColor.White);
            }
        }

        public void focus(int i) {
            pixels[i].ForeColor = Color.FromKnownColor(KnownColor.Red);
            pixels[i].BringToFront();
        }

        public void focusPixel(int i) {
            unfocus();
            focus(i);
        }

        private void F_Preview_Load(object sender, EventArgs e) {

        }
    }
}
