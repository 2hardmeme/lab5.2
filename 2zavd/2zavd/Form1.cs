using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2zavd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string arr = textBox1.Text;
            string[] c = arr.Split(' ');
            Circle circ = new Circle(int.Parse(c[0]), int.Parse(c[1]), 80, this);
            circ.MoveRight(int.Parse(c[2]));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string arr = textBox2.Text;
            string[] c = arr.Split(' ');
            Square sq = new Square(int.Parse(c[0]), int.Parse(c[1]), 80, this);
            sq.MoveRight(int.Parse(c[2]));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string arr = textBox3.Text;
            string[] c = arr.Split(' ');
            Rhomb rhomb = new Rhomb(int.Parse(c[0]), int.Parse(c[1]), int.Parse(c[2]), int.Parse(c[3]), this);
            rhomb.MoveRight(int.Parse(c[4]));
        }
    }
}