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
    public partial class FormVehicleConfig : Form
    {
        Vehicle vehicle = null;

        private Action<Vehicle> eventAddVehicle;

        public FormVehicleConfig()
        {
            InitializeComponent();
            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawTransport()
        {
            if (vehicle != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxVehicle.Width, pictureBoxVehicle.Height);
                Graphics gr = Graphics.FromImage(bmp);
                vehicle.SetPosition(5, 5, pictureBoxVehicle.Width, pictureBoxVehicle.Height);
                vehicle.DrawTransport(gr);
                pictureBoxVehicle.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddVehicle == null)
            {
                eventAddVehicle = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddVehicle += ev;
            }
        }

        private void labelArmorVehicle_MouseDown(object sender, MouseEventArgs e)
        {
            labelArmorVehicle.DoDragDrop(labelArmorVehicle.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelSau_MouseDown(object sender, MouseEventArgs e)
        {
            labelSau.DoDragDrop(labelSau.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelVehicle_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelVehicle_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Бронированный автомобиль":
                    vehicle = new ArmorVehicle((int)numericUpDownVehicleMaxSpeed.Value, (int)numericUpDownVehicleWeight.Value, Color.White);

                    break;
                case "Сау":
                    vehicle = new Sau((int)numericUpDownVehicleMaxSpeed.Value, (int)numericUpDownVehicleWeight.Value, Color.White, Color.Black, checkBoxAntiRadar.Checked, checkBoxDopPushka.Checked, checkBoxMan.Checked);
                    break;
            }
            DrawTransport();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (vehicle != null)
            {
                vehicle.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTransport();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (vehicle != null)
            {
                if (vehicle is Sau)
                {
                    (vehicle as Sau).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTransport();
                }
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddVehicle?.Invoke(vehicle);
            Close();
        }
    }
}