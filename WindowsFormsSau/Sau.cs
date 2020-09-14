using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSau
{
    class Sau
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private readonly int sauWidth = 70;
        private readonly int sauHeight = 50;

        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }

        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }

        public bool AntiRadar { private set; get; }
        public bool DopPushka { private set; get; }
        public bool Man { private set; get; }

        public Sau(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool antiradar, bool dopPushka, bool man)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            AntiRadar = antiradar;
            DopPushka = dopPushka;
            Man = man;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - sauWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - sauHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brBlack = new SolidBrush(Color.Black);
            Brush brRed = new SolidBrush(Color.Red);
            //gusenica
            g.FillEllipse(brBlack, _startPosX, _startPosY + sauHeight - 15, 20, 15);
            g.FillEllipse(brBlack, _startPosX + 19, _startPosY + sauHeight - 15, 20, 15);
            g.FillEllipse(brBlack, _startPosX + 38, _startPosY + sauHeight - 15, 20, 15);
            g.DrawRectangle(pen, _startPosX + 9, _startPosY + sauHeight - 15, 40, 15);

            Brush brOrange = new SolidBrush(Color.Orange);
            //bashnya
            g.FillRectangle(brOrange, _startPosX + 10, _startPosY + sauHeight - 30, 30, 15);
            //dulo
            g.FillRectangle(brBlack, _startPosX + 40, _startPosY + sauHeight - 24, 30, 2);

            Pen pGr = new Pen(Color.Green);
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
                g.DrawLine(pen, _startPosX + 13, _startPosY + sauHeight - 30, _startPosX + 13, _startPosY + sauHeight - 38);
                g.DrawLine(pen, _startPosX + 14, _startPosY + sauHeight - 30, _startPosX + 14, _startPosY + sauHeight - 38);
                g.DrawLine(pen, _startPosX + 15, _startPosY + sauHeight - 30, _startPosX + 15, _startPosY + sauHeight - 38);
                //golova
                g.FillEllipse(brBlack, _startPosX + 12, _startPosY + sauHeight - 44, 6, 7);
                //ruka
                g.DrawLine(pen, _startPosX + 15, _startPosY + sauHeight - 34, _startPosX + 20, _startPosY + sauHeight - 34);
            }
        }
    }
}