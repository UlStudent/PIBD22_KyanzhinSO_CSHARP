using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSau
{
	public class Sau : ArmorVehicle
	{
		public Color DopColor { private set; get; }

		public bool AntiRadar { private set; get; }
		public bool DopPushka { private set; get; }
		public bool Man { private set; get; }

		public Sau(int maxSpeed, float weight, Color mainColor, Color dopColor,
			bool antiradar, bool dopPushka, bool man) : base(maxSpeed, weight, mainColor, 70, 50)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			AntiRadar = antiradar;
			DopPushka = dopPushka;
			Man = man;
		}

		public override void DrawTransport(Graphics g)
		{
			//отрисовка основного тела
			base.DrawTransport(g);

			Pen pen = new Pen(Color.Black);
			Brush brBlack = new SolidBrush(Color.Black);
			Pen pGr = new Pen(Color.Green);
            Pen penDopColor = new Pen(DopColor);
			if (AntiRadar)
			{
				g.DrawLine(pGr, _startPosX + 24, _startPosY + sauHeight - 30, _startPosX + 24, _startPosY + sauHeight - 45);
				g.DrawLine(pGr, _startPosX + 15, _startPosY + sauHeight - 45, _startPosX + 39, _startPosY + sauHeight - 45);
			}
			if (DopPushka)
			{
				g.DrawLine(pen, _startPosX + 35, _startPosY + sauHeight - 30, _startPosX + 50, _startPosY + sauHeight - 40);
				g.DrawLine(pen, _startPosX + 34, _startPosY + sauHeight - 30, _startPosX + 49, _startPosY + sauHeight - 40);
				g.DrawLine(pen, _startPosX + 33, _startPosY + sauHeight - 30, _startPosX + 48, _startPosY + sauHeight - 40);
				g.DrawLine(pen, _startPosX + 32, _startPosY + sauHeight - 30, _startPosX + 47, _startPosY + sauHeight - 40);
				g.FillRectangle(brBlack, _startPosX + 49, _startPosY + sauHeight - 42, 5, 5);
			}
			if (Man)
			{
				//body
				g.DrawLine(penDopColor, _startPosX + 13, _startPosY + sauHeight - 30, _startPosX + 13, _startPosY + sauHeight - 38);
				g.DrawLine(penDopColor, _startPosX + 14, _startPosY + sauHeight - 30, _startPosX + 14, _startPosY + sauHeight - 38);
				g.DrawLine(penDopColor, _startPosX + 15, _startPosY + sauHeight - 30, _startPosX + 15, _startPosY + sauHeight - 38);
				//golova
				g.FillEllipse(brBlack, _startPosX + 12, _startPosY + sauHeight - 44, 6, 7);
				//ruka
				g.DrawLine(penDopColor, _startPosX + 15, _startPosY + sauHeight - 34, _startPosX + 20, _startPosY + sauHeight - 34);
			}
		}
	}
}