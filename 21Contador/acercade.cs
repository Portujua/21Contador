using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _21Contador
{
    public partial class acercade : Form
    {
        public acercade()
        {
            InitializeComponent();
        }

        private void acercade_Load(object sender, EventArgs e)
        {
            MessageBox.Show("El juego \"Contador 21\" esta basado en la habilidad de contar cartas expresado en la pelicula \"21 Blackjack\".", "Acerca de...");
        }
    }
}
