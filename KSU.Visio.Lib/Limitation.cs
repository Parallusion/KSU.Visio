﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KSU.Visio.Lib
{
	/// <summary>
	/// Класс "ограничение"
	/// </summary>
	public class Limitation:Figure
	{
		public Limitation(Point location, Size size) : base(location, size)
		{

		}

		public override Figure Clone()
		{
			Figure figure = new Limitation(Location, Size);
			figure.Selected = Selected;
			return figure;
		}

		public override void Draw(Graphics gr)
		{
			base.Draw(gr);
			int x1 = location.X;
			int y1 = location.Y;
			Point[] points = { new Point(x1, y1), new Point(x1, y1 + Convert.ToInt32(size.Height) - 1), new Point(x1 + Convert.ToInt32(size.Width) - 1, y1 + Convert.ToInt32(size.Height) - 1), new Point(x1 + Convert.ToInt32(size.Width) - 1, y1 + Convert.ToInt32(size.Height * 0.2)), new Point(x1 + Convert.ToInt32(size.Width * 6 / 7), y1 + Convert.ToInt32(size.Height * 0.2)), new Point(x1 + Convert.ToInt32(size.Width * 6 / 7), y1), new Point(x1 + Convert.ToInt32(size.Width) - 1, y1 + Convert.ToInt32(size.Height * 0.2)), new Point(x1 + Convert.ToInt32(size.Width * 6 / 7), y1) };
			gr.DrawPolygon(pen, points);
		}
	}
}
