using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Agregar;

namespace WindowsFormsApp1
{
    public partial class Eliminar : Form
    {
        private List<Medicamento> listaMedicamentos;
        public Eliminar(List<Medicamento> listaMedicamentos)
        {
            InitializeComponent();
            this.listaMedicamentos = listaMedicamentos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool encontrado = false;

            for (int i = 0; i < listaMedicamentos.Count; i++)
            {
                if (txtEliminar.Text == listaMedicamentos[i].Codigo)
                {
                    listaMedicamentos.RemoveAt(i);
                    encontrado = true;
                    break; // Se encontró y eliminó el elemento, así que se puede salir del bucle
                }
            }

            if (encontrado)
            {
                MessageBox.Show("Elemento encontrado y eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró ningún elemento con ese código", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
