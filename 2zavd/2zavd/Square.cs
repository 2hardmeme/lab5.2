﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2zavd
{
    class Square : Figure
    {
        protected Form1 form2;
        public int size { get; }
        
        public Square(int x, int y, int s, Form1 form2) : base(x, y)
        {
            this.size = s;
            this.form2 = form2;
        }
        public override void DrawBlack()
        {
            Graphics graphics2 = form2.CreateGraphics();
            graphics2.DrawRectangle(Pens.Black, this.x_coordinate, this.y_coordinate, size, size);
        }
        public override void HideDrawingBackGround()
        {
            Graphics graphics2 = form2.CreateGraphics();
            graphics2.DrawRectangle(new Pen(form2.BackColor), this.x_coordinate, this.y_coordinate, size, size);
        }
    }
}