using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hola_mundo_form1_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Muestra cuandros de dialogo emergentes con el texto entre comillas, se inician desde el form1
            //no es necesario iniciarlos y solo se iniciarn cuando abre el programa
            MessageBox.Show("Hola Mundo! primer paso listo");
            MessageBox.Show("Come Tierra");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //al dar click en boton1 ostrara un cuandro de dialogo con SI o No, al dar click en si saldra del programa.
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            }

        private void Button2_Click(object sender, EventArgs e)
        {
            //el boton 2 toma el texto de textbox1 y lo muestra en un cuadro de dialogo emergente
            MessageBox.Show(textBox1.Text);
            
        }
    } 
}
