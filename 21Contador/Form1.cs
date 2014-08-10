using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;
using _21Contador.Properties;


namespace _21Contador
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        public static string checkExceptions(int i)
        {
            switch (i)
            {
                case 1:
                    return "<Click Izquierdo>";
                case 2:
                    return "<Click Derecho>";
                case 13:
                    return "<Enter>";
                case 9:
                    return "<Tab>";
                case 20:
                    return "<Bloq Mayus>";
                case 160:
                    return "<Shift Izquierdo>";
                case 161:
                    return "<Shift Derecho>";
                case 16:
                    return "";
                case 162:
                    return "<Ctrl>";
                case 163:
                    return "<Ctrl>";
                case 17:
                    return "";
                case 164:
                    return "<Alt>";
                case 165:
                    return "<Alt>";
                case 18:
                    return "";
                case 93:
                    return "<Menu Key>";
                case 37:
                    return "<Flecha Izquierda>";
                case 39:
                    return "<Flecha Derecha>";
                case 38:
                    return "<Flecha Arriba>";
                case 40:
                    return "<Flecha Abajo>";
                case 220:
                    return "\\";
                case 191:
                    return "/";
                case 222:
                    return "'";
                case 186:
                    return ";";
                case 8:
                    return "<Tecla de Borrar>";
                case 33:
                    return "<Page Up>";
                case 34:
                    return "<Page Down>";
                case 35:
                    return "<End>";
                case 36:
                    return "<Home>";
                case 144:
                    return "<Bloq Num>";
                case 44:
                    return "<Prnt Scrn>";
                case 45:
                    return "<Insert>";
                case 112:
                    return "<F1>";
                case 113:
                    return "<F2>";
                case 114:
                    return "<F3>";
                case 115:
                    return "<F4>";
                case 116:
                    return "<F5>";
                case 117:
                    return "<F6>";
                case 118:
                    return "<F7>";
                case 119:
                    return "<F8>";
                case 120:
                    return "<F9>";
                case 121:
                    return "<F10>";
                case 122:
                    return "<F11>";
                case 123:
                    return "<F12>";
                case 219:
                    return "[";
                case 221:
                    return "]";
                case 189:
                    return "-";
                case 187:
                    return "=";
                case 91:
                    return "<Windows Key>";
                case 188:
                    return ",";
                case 190:
                    return ".";

                case 107:
                    return "+";
                case 109:
                    return "-";
                case 111:
                    return "/";
                default:
                    return ((char)i).ToString();
            }
        }



        static Random ramdom = new Random();
        static int cuenta = 0;
        static int delay = 2000;
        static int NumeroCartas = 20;
        //SoundPlayer sonido = new SoundPlayer("D:\\Mis Documentos\\JUEGOS\\Daniel\\SONIDOOOOOOOOS\\Balas Nosotro.wav");
        //SoundPlayer ganar = new SoundPlayer("D:\\Mis Documentos\\JUEGOS\\Daniel\\SONIDOOOOOOOOS\\MuerteBoss.wav");
        //SoundPlayer perder = new SoundPlayer("D:\\Mis Documentos\\JUEGOS\\Daniel\\SONIDOOOOOOOOS\\muertesilla.wav");
        //File asdf = File.CreateText("asdf").Write("asdfasdfasdfasdf");     

        int cuenta_high = 0;
        


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            juegoToolStripMenuItem.Enabled = false;
            acercaDeToolStripMenuItem.Enabled = false;
            cuenta_high = 0;
            button1.Enabled = false;
            this.Refresh();
            int actual = 0;
            int norepetir = 0;
            cuenta = 0;


            bool habilidad = true;
            int tecla_num = 0;
            string tecla = "";
            
            /*********
             * 1 = + *
             * 2 = - *
             * 3 = / *
             *********/ 

            if (soloContarToolStripMenuItem.Checked)
            {
                #region Mental

                

                for (int i = 0; i < NumeroCartas; i++)
                {
                    while (actual == norepetir)
                    {
                        actual = ramdom.Next(1, 53);
                    }
                    norepetir = actual;

                    //Lista de Numeros para Identificar Cartas en SWITCH
                    /* 
                     * 1-13 Corazones
                     * 14-26 Diamantes
                     * 27-39 Treboles
                     * 40-52 Picas
                     */
                    //sonido.Play();

                    switch (actual)
                    {
                        #region Corazones
                        case 1:   // A Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_1);
                            break;
                        case 2:   // 2 Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_2);
                            break;
                        case 3:   // 3 Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_3);
                            break;
                        case 4:   // 4 Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_4);
                            break;
                        case 5:   // 5 Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_5);
                            break;
                        case 6:   // 6 Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_6);
                            break;
                        case 7:   // 7 Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_7);
                            break;
                        case 8:   //  8 Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_8);
                            break;
                        case 9:   // 9 Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_9);
                            cuenta = cuenta - 1;
                            break;
                        case 10:   // 10 Corazones
                            cuenta = cuenta - 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_10);
                            break;
                        case 11:  // J Corazones
                            cuenta = cuenta - 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_11);
                            break;
                        case 12:   // Q Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_12);
                            cuenta = cuenta - 1;
                            break;
                        case 13:    // K Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_13);
                            cuenta = cuenta - 1;
                            break;
                        #endregion

                        #region Diamantes
                        case 14:   // A Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_1);
                            cuenta = cuenta + 1;
                            break;
                        case 15:   // 2 Diamantes
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_2);
                            break;
                        case 16:   // 3 Diamantes
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_3);
                            break;
                        case 17:   // 4 Diamantes
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_4);
                            break;
                        case 18:   // 5 Diamantes
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_5);
                            break;
                        case 19:   // 6 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_6);
                            break;
                        case 20:   // 7 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_7);
                            break;
                        case 21:   //  8 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_8);
                            break;
                        case 22:   // 9 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_9);
                            cuenta = cuenta - 1;
                            break;
                        case 23:   // 10 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_10);
                            cuenta = cuenta - 1;
                            break;
                        case 24:  // J Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_11);
                            cuenta = cuenta - 1;
                            break;
                        case 25:   // Q Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_12);
                            cuenta = cuenta - 1;
                            break;
                        case 26:    // K Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_13);
                            cuenta = cuenta - 1;
                            break;
                        #endregion

                        #region Treboles
                        case 27:   // A Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_1);
                            cuenta = cuenta + 1;
                            break;
                        case 28:   // 2 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_2);
                            cuenta = cuenta + 1;
                            break;
                        case 29:   // 3 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_3);
                            cuenta = cuenta + 1;
                            break;
                        case 30:   // 4 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_4);
                            cuenta = cuenta + 1;
                            break;
                        case 31:   // 5 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_5);
                            cuenta = cuenta + 1;
                            break;
                        case 32:   // 6 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_6);
                            break;
                        case 33:   // 7 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_7);
                            break;
                        case 34:   //  8 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_8);
                            break;
                        case 35:   // 9 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_9);
                            cuenta = cuenta - 1;
                            break;
                        case 36:   // 10 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_10);
                            cuenta = cuenta - 1;
                            break;
                        case 37:  // J Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_11);
                            cuenta = cuenta - 1;
                            break;
                        case 38:   // Q Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_12);
                            cuenta = cuenta - 1;
                            break;
                        case 39:    // K Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_13);
                            cuenta = cuenta - 1;
                            break;
                        #endregion

                        #region Picas
                        case 40:   // A Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_1);
                            cuenta = cuenta + 1;
                            break;
                        case 41:   // 2 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_2);
                            cuenta = cuenta + 1;
                            break;
                        case 42:   // 3 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_3);
                            cuenta = cuenta + 1;
                            break;
                        case 43:   // 4 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_4);
                            cuenta = cuenta + 1;
                            break;
                        case 44:   // 5 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_5);
                            cuenta = cuenta + 1;
                            break;
                        case 45:   // 6 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_6);
                            break;
                        case 46:   // 7 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_7);
                            break;
                        case 47:   //  8 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_8);
                            break;
                        case 48:   // 9 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_9);
                            cuenta = cuenta - 1;
                            break;
                        case 49:   // 10 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_10);
                            cuenta = cuenta - 1;
                            break;
                        case 50:  // J Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_11);
                            cuenta = cuenta - 1;
                            break;
                        case 51:   // Q Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_12);
                            cuenta = cuenta - 1;
                            break;
                        case 52:    // K Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_13);
                            cuenta = cuenta - 1;
                            break;
                        #endregion
                    }
                    label2.Text = cuenta.ToString();
                    this.Refresh();
                    Thread.Sleep(delay);
                }
                #endregion

                textBox1.Visible = true;
                label3.Visible = true;
                button2.Visible = true;
            }
            else if (habilidadToolStripMenuItem.Checked)
            {
                #region Habilidad

                while (habilidad == true)
                {
                    tecla = "";
                    tecla_num = 0;

                    #region Para que no se repitan

                    while (actual == norepetir)
                    {
                        actual = ramdom.Next(1, 53);
                    }
                    norepetir = actual;

                    #endregion

                    #region Mostrar la carta

                    int aux = cuenta;

                    switch (actual)
                    {
                        #region Corazones
                        case 1:   // A Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_1);
                            break;
                        case 2:   // 2 Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_2);
                            break;
                        case 3:   // 3 Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_3);
                            break;
                        case 4:   // 4 Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_4);
                            break;
                        case 5:   // 5 Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_5);
                            break;
                        case 6:   // 6 Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_6);
                            break;
                        case 7:   // 7 Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_7);
                            break;
                        case 8:   //  8 Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_8);
                            break;
                        case 9:   // 9 Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_9);
                            cuenta = cuenta - 1;
                            break;
                        case 10:   // 10 Corazones
                            cuenta = cuenta - 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_10);
                            break;
                        case 11:  // J Corazones
                            cuenta = cuenta - 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_11);
                            break;
                        case 12:   // Q Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_12);
                            cuenta = cuenta - 1;
                            break;
                        case 13:    // K Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_13);
                            cuenta = cuenta - 1;
                            break;
                        #endregion

                        #region Diamantes
                        case 14:   // A Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_1);
                            cuenta = cuenta + 1;
                            break;
                        case 15:   // 2 Diamantes
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_2);
                            break;
                        case 16:   // 3 Diamantes
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_3);
                            break;
                        case 17:   // 4 Diamantes
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_4);
                            break;
                        case 18:   // 5 Diamantes
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_5);
                            break;
                        case 19:   // 6 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_6);
                            break;
                        case 20:   // 7 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_7);
                            break;
                        case 21:   //  8 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_8);
                            break;
                        case 22:   // 9 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_9);
                            cuenta = cuenta - 1;
                            break;
                        case 23:   // 10 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_10);
                            cuenta = cuenta - 1;
                            break;
                        case 24:  // J Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_11);
                            cuenta = cuenta - 1;
                            break;
                        case 25:   // Q Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_12);
                            cuenta = cuenta - 1;
                            break;
                        case 26:    // K Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_13);
                            cuenta = cuenta - 1;
                            break;
                        #endregion

                        #region Treboles
                        case 27:   // A Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_1);
                            cuenta = cuenta + 1;
                            break;
                        case 28:   // 2 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_2);
                            cuenta = cuenta + 1;
                            break;
                        case 29:   // 3 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_3);
                            cuenta = cuenta + 1;
                            break;
                        case 30:   // 4 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_4);
                            cuenta = cuenta + 1;
                            break;
                        case 31:   // 5 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_5);
                            cuenta = cuenta + 1;
                            break;
                        case 32:   // 6 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_6);
                            break;
                        case 33:   // 7 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_7);
                            break;
                        case 34:   //  8 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_8);
                            break;
                        case 35:   // 9 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_9);
                            cuenta = cuenta - 1;
                            break;
                        case 36:   // 10 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_10);
                            cuenta = cuenta - 1;
                            break;
                        case 37:  // J Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_11);
                            cuenta = cuenta - 1;
                            break;
                        case 38:   // Q Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_12);
                            cuenta = cuenta - 1;
                            break;
                        case 39:    // K Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_13);
                            cuenta = cuenta - 1;
                            break;
                        #endregion

                        #region Picas
                        case 40:   // A Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_1);
                            cuenta = cuenta + 1;
                            break;
                        case 41:   // 2 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_2);
                            cuenta = cuenta + 1;
                            break;
                        case 42:   // 3 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_3);
                            cuenta = cuenta + 1;
                            break;
                        case 43:   // 4 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_4);
                            cuenta = cuenta + 1;
                            break;
                        case 44:   // 5 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_5);
                            cuenta = cuenta + 1;
                            break;
                        case 45:   // 6 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_6);
                            break;
                        case 46:   // 7 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_7);
                            break;
                        case 47:   //  8 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_8);
                            break;
                        case 48:   // 9 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_9);
                            cuenta = cuenta - 1;
                            break;
                        case 49:   // 10 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_10);
                            cuenta = cuenta - 1;
                            break;
                        case 50:  // J Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_11);
                            cuenta = cuenta - 1;
                            break;
                        case 51:   // Q Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_12);
                            cuenta = cuenta - 1;
                            break;
                        case 52:    // K Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_13);
                            cuenta = cuenta - 1;
                            break;
                        #endregion
                    }

                    if (aux < cuenta)
                        tecla_num = 1;
                    else if (aux > cuenta)
                        tecla_num = 2;
                    else if (aux == cuenta)
                        tecla_num = 3;
                    
                    label2.Text = cuenta.ToString();
                    this.Refresh();

                    #endregion

                    Thread.Sleep(delay);

                    #region Buscar tecla

                    for (int i = 1; i < 255; i++)
                    {
                        int result = GetAsyncKeyState(i);

                        if (result != 0)
                        {

                            tecla = checkExceptions(i);
                            //MessageBox.Show(tecla);
                        }
                    }

                    #endregion
                    

                    #region Revisar si la tecla que se presiono es la qe es

                    if ((tecla == "+") && (tecla_num == 1))
                    {
                        cuenta_high++;
                    }
                    else if ((tecla == "-") && (tecla_num == 2))
                        cuenta_high++;
                    else if ((tecla == "/") && (tecla_num == 3))
                        cuenta_high++;
                    else
                        habilidad = false;

                    #endregion                    

                }
                               
                
                MessageBox.Show("Se acabo el tiempo!\nTuviste " + cuenta_high.ToString() + " aciertos!", "Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                #endregion
            }
            else if (mentalHabilidadToolStripMenuItem.Checked)
            {
                #region PRO

                while (habilidad == true)
                {
                    tecla = "";
                    tecla_num = 0;

                    #region Para que no se repitan

                    while (actual == norepetir)
                    {
                        actual = ramdom.Next(1, 53);
                    }
                    norepetir = actual;

                    #endregion

                    #region Mostrar la carta

                    int aux = cuenta;

                    switch (actual)
                    {
                        #region Corazones
                        case 1:   // A Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_1);
                            break;
                        case 2:   // 2 Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_2);
                            break;
                        case 3:   // 3 Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_3);
                            break;
                        case 4:   // 4 Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_4);
                            break;
                        case 5:   // 5 Corazones
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_5);
                            break;
                        case 6:   // 6 Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_6);
                            break;
                        case 7:   // 7 Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_7);
                            break;
                        case 8:   //  8 Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_8);
                            break;
                        case 9:   // 9 Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_9);
                            cuenta = cuenta - 1;
                            break;
                        case 10:   // 10 Corazones
                            cuenta = cuenta - 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_10);
                            break;
                        case 11:  // J Corazones
                            cuenta = cuenta - 1;
                            pictureBox1.Image = new Bitmap(Resources.Corazones_11);
                            break;
                        case 12:   // Q Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_12);
                            cuenta = cuenta - 1;
                            break;
                        case 13:    // K Corazones
                            pictureBox1.Image = new Bitmap(Resources.Corazones_13);
                            cuenta = cuenta - 1;
                            break;
                        #endregion

                        #region Diamantes
                        case 14:   // A Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_1);
                            cuenta = cuenta + 1;
                            break;
                        case 15:   // 2 Diamantes
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_2);
                            break;
                        case 16:   // 3 Diamantes
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_3);
                            break;
                        case 17:   // 4 Diamantes
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_4);
                            break;
                        case 18:   // 5 Diamantes
                            cuenta = cuenta + 1;
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_5);
                            break;
                        case 19:   // 6 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_6);
                            break;
                        case 20:   // 7 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_7);
                            break;
                        case 21:   //  8 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_8);
                            break;
                        case 22:   // 9 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_9);
                            cuenta = cuenta - 1;
                            break;
                        case 23:   // 10 Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_10);
                            cuenta = cuenta - 1;
                            break;
                        case 24:  // J Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_11);
                            cuenta = cuenta - 1;
                            break;
                        case 25:   // Q Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_12);
                            cuenta = cuenta - 1;
                            break;
                        case 26:    // K Diamantes
                            pictureBox1.Image = new Bitmap(Resources.Diamantes_13);
                            cuenta = cuenta - 1;
                            break;
                        #endregion

                        #region Treboles
                        case 27:   // A Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_1);
                            cuenta = cuenta + 1;
                            break;
                        case 28:   // 2 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_2);
                            cuenta = cuenta + 1;
                            break;
                        case 29:   // 3 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_3);
                            cuenta = cuenta + 1;
                            break;
                        case 30:   // 4 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_4);
                            cuenta = cuenta + 1;
                            break;
                        case 31:   // 5 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_5);
                            cuenta = cuenta + 1;
                            break;
                        case 32:   // 6 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_6);
                            break;
                        case 33:   // 7 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_7);
                            break;
                        case 34:   //  8 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_8);
                            break;
                        case 35:   // 9 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_9);
                            cuenta = cuenta - 1;
                            break;
                        case 36:   // 10 Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_10);
                            cuenta = cuenta - 1;
                            break;
                        case 37:  // J Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_11);
                            cuenta = cuenta - 1;
                            break;
                        case 38:   // Q Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_12);
                            cuenta = cuenta - 1;
                            break;
                        case 39:    // K Treboles
                            pictureBox1.Image = new Bitmap(Resources.Trebol_13);
                            cuenta = cuenta - 1;
                            break;
                        #endregion

                        #region Picas
                        case 40:   // A Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_1);
                            cuenta = cuenta + 1;
                            break;
                        case 41:   // 2 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_2);
                            cuenta = cuenta + 1;
                            break;
                        case 42:   // 3 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_3);
                            cuenta = cuenta + 1;
                            break;
                        case 43:   // 4 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_4);
                            cuenta = cuenta + 1;
                            break;
                        case 44:   // 5 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_5);
                            cuenta = cuenta + 1;
                            break;
                        case 45:   // 6 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_6);
                            break;
                        case 46:   // 7 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_7);
                            break;
                        case 47:   //  8 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_8);
                            break;
                        case 48:   // 9 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_9);
                            cuenta = cuenta - 1;
                            break;
                        case 49:   // 10 Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_10);
                            cuenta = cuenta - 1;
                            break;
                        case 50:  // J Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_11);
                            cuenta = cuenta - 1;
                            break;
                        case 51:   // Q Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_12);
                            cuenta = cuenta - 1;
                            break;
                        case 52:    // K Picas
                            pictureBox1.Image = new Bitmap(Resources.Picas_13);
                            cuenta = cuenta - 1;
                            break;
                        #endregion
                    }

                    if (aux < cuenta)
                        tecla_num = 1;
                    else if (aux > cuenta)
                        tecla_num = 2;
                    else if (aux == cuenta)
                        tecla_num = 3;

                    label2.Text = cuenta.ToString();
                    this.Refresh();

                    #endregion

                    Thread.Sleep(delay);

                    #region Buscar tecla

                    for (int i = 1; i < 255; i++)
                    {
                        int result = GetAsyncKeyState(i);

                        if (result != 0)
                        {

                            tecla = checkExceptions(i);
                            //MessageBox.Show(tecla);
                        }
                    }

                    #endregion


                    #region Revisar si la tecla que se presiono es la qe es

                    if ((tecla == "+") && (tecla_num == 1))
                    {
                        cuenta_high++;
                    }
                    else if ((tecla == "-") && (tecla_num == 2))
                        cuenta_high++;
                    else if ((tecla == "/") && (tecla_num == 3))
                        cuenta_high++;
                    else
                        habilidad = false;

                    #endregion

                    

                }
                textBox1.Visible = true;
                label3.Visible = true;
                button2.Visible = true;

                #endregion
            }
            else
                MessageBox.Show("Debe seleccionar un modo de juego!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (button2.Visible == false)
            {
                pictureBox1.Image = new Bitmap(Resources.Joker);
            
                button1.Enabled = true;
            }
            juegoToolStripMenuItem.Enabled = true;
            acercaDeToolStripMenuItem.Enabled = true;
            
        }

        private void label2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == cuenta)
            {
                //ganar.Play();
                if (cuenta_high != 0)
                    MessageBox.Show("21 BLACKJACK!", "Acertaste!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("People, we have a PRO here!", "Acertaste!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //perder.Play();
                MessageBox.Show("Nabster*", "Respuesta Equivocada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Visible = false;
            label3.Visible = false;
            button2.Visible = false;
            button1.Enabled = true;
            pictureBox1.Image = new Bitmap(Resources.Joker);
            this.Refresh();
            textBox1.Text = "";
            cuenta = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Para cambiar la dificultad hagalo mediante el menu. \nDificultad predeterminada: Facil");
            facilToolStripMenuItem.Checked = true;
            toolStripMenuItem2.Checked = true;
            label_dif.Text = "Facil";
            label_dif.ForeColor = Color.FromKnownColor(KnownColor.Yellow);
            label_numcartas.Text = NumeroCartas.ToString();
            pictureBox1.Image = new Bitmap(Resources.Joker);
            
            // Esconder la vaina de Mental xd
            label4.Visible = false;
            label_numcartas.Visible = false;

            button1.Enabled = false;
        }

        private void noobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noobToolStripMenuItem.Checked = true;
            facilToolStripMenuItem.Checked = false;
            medioToolStripMenuItem.Checked = false;
            dificilToolStripMenuItem.Checked = false;
            bossToolStripMenuItem.Checked = false;
            delay = 3000;
            label_dif.Text = "Noob";
            label_dif.ForeColor = Color.FromKnownColor(KnownColor.Aquamarine);
        }

        private void facilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noobToolStripMenuItem.Checked = false;
            facilToolStripMenuItem.Checked = true;
            medioToolStripMenuItem.Checked = false;
            dificilToolStripMenuItem.Checked = false;
            bossToolStripMenuItem.Checked = false;
            delay = 1700;
            label_dif.Text = "Facil";
            label_dif.ForeColor = Color.FromKnownColor(KnownColor.Yellow);
        }

        private void medioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noobToolStripMenuItem.Checked = false;
            facilToolStripMenuItem.Checked = false;
            medioToolStripMenuItem.Checked = true;
            dificilToolStripMenuItem.Checked = false;
            bossToolStripMenuItem.Checked = false;
            delay = 1200;
            label_dif.Text = "Medio";
            label_dif.ForeColor = Color.FromKnownColor(KnownColor.Red);
        }

        private void dificilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noobToolStripMenuItem.Checked = false;
            facilToolStripMenuItem.Checked = false;
            medioToolStripMenuItem.Checked = false;
            dificilToolStripMenuItem.Checked = true;
            bossToolStripMenuItem.Checked = false;
            delay = 700;
            label_dif.Text = "Dificil";
            label_dif.ForeColor = Color.FromKnownColor(KnownColor.Green);
        }

        private void bossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noobToolStripMenuItem.Checked = false;
            facilToolStripMenuItem.Checked = false;
            medioToolStripMenuItem.Checked = false;
            dificilToolStripMenuItem.Checked = false;
            bossToolStripMenuItem.Checked = true;
            delay = 450;
            label_dif.Text = "BOSS!";
            label_dif.ForeColor = Color.FromKnownColor(KnownColor.MidnightBlue);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NumeroCartas = 20;
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            label_numcartas.Text = NumeroCartas.ToString();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NumeroCartas = 30;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = true;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            label_numcartas.Text = NumeroCartas.ToString();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = true;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            NumeroCartas = 40;
            label_numcartas.Text = NumeroCartas.ToString();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            NumeroCartas = 50;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = true;
            toolStripMenuItem6.Checked = false;
            label_numcartas.Text = NumeroCartas.ToString();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            NumeroCartas = 60;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = true;
            label_numcartas.Text = NumeroCartas.ToString();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            acercade mostrar = new acercade();
            mostrar.Show();
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changelog mostrar = new changelog();
            mostrar.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void soloContarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soloContarToolStripMenuItem.Checked = true;
            habilidadToolStripMenuItem.Checked = false;
            mentalHabilidadToolStripMenuItem.Checked = false;
            label6.Text = "Mental";
            label4.Visible = true;
            label_numcartas.Visible = true;

            button1.Enabled = true;
        }

        private void habilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soloContarToolStripMenuItem.Checked = false;
            habilidadToolStripMenuItem.Checked = true;
            mentalHabilidadToolStripMenuItem.Checked = false;
            label6.Text = "Habilidad";


            //Esconder Mental
            label4.Visible = false;
            label_numcartas.Visible = false;


            button1.Enabled = true;
        }

        private void mentalHabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soloContarToolStripMenuItem.Checked = false;
            habilidadToolStripMenuItem.Checked = false;
            mentalHabilidadToolStripMenuItem.Checked = true;
            label6.Text = "Pro";

            //Esconder Mental
            label4.Visible = false;
            label_numcartas.Visible = false;

            button1.Enabled = true;
        }

        private void comoJugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(instruccion_label.Text, "Instrucciones");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(instruccion_label.Text, "Instrucciones");
        }

        

    }
}
