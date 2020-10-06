using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSau
{
    public partial class FormSau : Form
    {
        private ITransport sau;

        public FormSau()
        {
            InitializeComponent();
        }

        public void SetSau(ITransport sau)
        {
            this.sau = sau;
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxSau.Width, pictureBoxSau.Height);
            Graphics gr = Graphics.FromImage(bmp);
            sau.DrawTransport(gr);
            pictureBoxSau.Image = bmp;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    sau.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    sau.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    sau.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    sau.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
