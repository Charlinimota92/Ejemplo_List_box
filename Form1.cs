using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_List_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            
            lst_Series.Items.Add(txt_Series.Text);

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        { 
            int indice = lst_Series.SelectedIndex;

            // Verificar si hay un elemento seleccionado en el ListBox
            if (indice != -1)
            {
                
                lst_Series.Items.RemoveAt(indice);

                // Limpiar el contenido del Label de índice seleccionado
                lbl_Indice_Seleccionado.Text = "";
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            lst_Series.Items.Clear();
            lbl_Indice_Seleccionado.Text = "";
            txt_Series.Clear();

        }

        private void lst_Series_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lst_Series.SelectedIndex != -1)
            {
               
                int indiceSeleccionado = lst_Series.SelectedIndex;

                
                lbl_Indice_Seleccionado.Text = "Índice Seleccionado: " + indiceSeleccionado.ToString();
                lbl_Indice_Seleccionado.ForeColor = Color.Blue;
            }
            else
            {
                
                lbl_Indice_Seleccionado.Text = "";
            }
        }
    }
}