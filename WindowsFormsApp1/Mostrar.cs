using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static WindowsFormsApp1.Agregar;

namespace WindowsFormsApp1
{
    public partial class Mostrar : Form
    {
  

        public Mostrar(List<Medicamento> listaMedicamentos)
        {
            InitializeComponent();

            

            

            // Agregar medicamento manualmente
            


            // Configurar la DataGridView para mostrar los medicamentos
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listaMedicamentos;
        }

        
    }
}
