﻿using System;
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
    public partial class Cuadrado : Form
    {
        public Cuadrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Geometria g = new Geometria();
            double area = g.areacuadrado(Convert.ToInt32(lado.Value));
            MessageBox.Show("El area es de " + area);
        }
    }
}
