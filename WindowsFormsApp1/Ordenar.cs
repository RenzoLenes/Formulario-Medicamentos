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
    public partial class Ordenar : Form
    {
        private List<Medicamento> listaMedicamentos;
        public Ordenar(List<Medicamento> listaMedicamentos)
        {
            InitializeComponent();
            this.listaMedicamentos = listaMedicamentos;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            listaMedicamentos.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listaMedicamentos;

        }

        
    }
}
