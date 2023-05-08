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
    public partial class Buscar : Form
    {
        private List<Medicamento> listaMedicamentos;
        public Buscar(List<Medicamento> listaMedicamentos)
        {
            InitializeComponent();
            this.listaMedicamentos = listaMedicamentos;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool encontrado = listaMedicamentos.Any(medicamento => medicamento.Nombre == txtBusqueda.Text);

            if (encontrado)
            {
                MessageBox.Show("Se encontró un medicamento con dicho nombre.");
            }
            else
            {
                MessageBox.Show("No se encontró un medicamento con dicho nombre.");
            }



        }

       
    }
}
