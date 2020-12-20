﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSau
{
    public class ArmorVehicle : Vehicle, IEquatable<ArmorVehicle>
    {
        protected readonly int sauWidth = 70;
        protected readonly int sauHeight = 50;
        protected readonly char separator = ':';

        public ArmorVehicle(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public ArmorVehicle(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        protected ArmorVehicle(int maxSpeed, float weight, Color mainColor, int sauWidth, int sauHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.sauWidth = sauWidth;
            this.sauHeight = sauHeight;
        }

        public override void MoveTransport(Direction direction)
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

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brBlack = new SolidBrush(Color.Black);
            //gusenicа
            g.FillEllipse(brBlack, _startPosX, _startPosY + sauHeight - 15, 20, 15);
            g.FillEllipse(brBlack, _startPosX + 19, _startPosY + sauHeight - 15, 20, 15);
            g.FillEllipse(brBlack, _startPosX + 38, _startPosY + sauHeight - 15, 20, 15);
            g.DrawRectangle(pen, _startPosX + 9, _startPosY + sauHeight - 15, 40, 15);

            Brush brMainColor = new SolidBrush(MainColor);
            //bashnya
            g.FillRectangle(brMainColor, _startPosX + 10, _startPosY + sauHeight - 30, 30, 15);
            //dulo
            g.FillRectangle(brBlack, _startPosX + 40, _startPosY + sauHeight - 24, 30, 2);
        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }

        public bool Equals(ArmorVehicle other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is ArmorVehicle VehicleObj))
            {
                return false;
            }
            else
            {
                return Equals(VehicleObj);
            }
        }
    }
}
