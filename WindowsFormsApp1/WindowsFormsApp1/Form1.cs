using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int forma = figura.SelectedIndex;
            switch (forma)
            {
                case 0:
                    Triangulo t = new Triangulo();
                    t.Show();
                    break;
                case 1:
                    Cuadrado c = new Cuadrado();
                    c.Show();
                    break;
                case 2:
                    Circulo ci = new Circulo();
                    ci.Show();
                    break;
                case 3:
                    Rectangulo r = new Rectangulo();
                    r.Show();
                    break;
                case 4:
                    Pentagono re = new Pentagono();
                    re.Show();
                    break;

                case 5:
                    Rombo ro = new Rombo();
                    ro.Show();
                    break;

                case 6:
                    Romboide rom = new Romboide();
                    rom.Show();
                    break;

                case 7:
                    Trapecio tr = new Trapecio();
                    tr.Show();
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
