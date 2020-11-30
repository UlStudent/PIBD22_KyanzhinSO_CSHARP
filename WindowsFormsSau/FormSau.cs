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

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxSau.Width, pictureBoxSau.Height);
            Graphics gr = Graphics.FromImage(bmp);
            sau.DrawSau(gr);
            pictureBoxSau.Image = bmp;
        }

        private void buttonCreateBasSau_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sau = new basSau(rnd.Next(100, 300), rnd.Next(1000, 2000),
           Color.Yellow);
            sau.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxSau.Width,
           pictureBoxSau.Height);
            Draw();
        }

        private void buttonCreateSau_Click(object sender, EventArgs e)
            sau.DrawTransport(gr);
            pictureBoxSau.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sau = new Sau(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
           Color.Yellow, true, true, true);
            sau.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxSau.Width,
           pictureBoxSau.Height);
            Draw();
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
            Console.WriteLine("text");
        }
    }
}

