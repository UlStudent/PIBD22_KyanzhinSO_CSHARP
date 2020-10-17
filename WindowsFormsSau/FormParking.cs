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
    public partial class FormParking : Form
    {
        private readonly Parking<ArmorVehicle> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ArmorVehicle>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        private void buttonSetArmorVehicle_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var armorVehicle = new ArmorVehicle(100, 1000, dialog.Color);

                if (parking + armorVehicle)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        private void buttonSetSau_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var sau = new Sau(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    if (parking + sau)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void buttonTakeVehicle_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPosition.Text != "")
            {
                var Sau = parking - Convert.ToInt32(maskedTextBoxPosition.Text);
                if (Sau != null)
                {
                    FormVehicle form = new FormVehicle();
                    form.SetSau(Sau);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
