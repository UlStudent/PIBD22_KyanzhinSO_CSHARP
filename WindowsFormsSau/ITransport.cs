using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSau
{
	interface ITransport
	{
		void SetPosition(int x, int y, int width, int height);
		void MoveTransport(Direction direction);
		void DrawSau(Graphics g);
	}
}
