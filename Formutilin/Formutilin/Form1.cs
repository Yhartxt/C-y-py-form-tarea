using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formutilin
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle X = this.ClientRectangle;

            Color color1 = Color.AliceBlue;
            Color color2 = Color.CadetBlue;

            using (LinearGradientBrush brush = new LinearGradientBrush(X, color1, color2, 260))
            {
                g.FillRectangle(brush, X);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_sabe_Click(object sender, EventArgs e)
        {
            string nombre = Txb_nombre.Text;
            string apelli = Txb_Apelldio.Text;
            int telefono = int.Parse(Txb_Edad.Text);
            float Altrua = float.Parse(Txb_Estaura.Text);
            int edad = int.Parse(Txb_Edad.Text);
            string genero = lbl_masculino.Checked ? "Masculino" : "Femenino";
            string cnt = $"Nombre: {nombre}\nApellido {apelli}\n Telefono {telefono}\nAltura {Altrua}\nGenero {genero}";
            string Archivo = @"D:\Users\gisel\Formulario echo.txt";
            File.WriteAllText(Archivo, cnt);
            MessageBox.Show("Se a guardado con exito");

        }
    }
}
