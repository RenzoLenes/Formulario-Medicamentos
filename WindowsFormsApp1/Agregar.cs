using System;
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
    public partial class Agregar : Form
    {
        private List<Medicamento> listaMedicamentos;

        public Agregar(List<Medicamento> listaMedicamentos)
        {
            InitializeComponent();
            this.listaMedicamentos = listaMedicamentos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaMedicamentos != null)
            {
                // Obtener los datos del medicamento del formulario
                string codigo = txtCodigo.Text;
                string nombre = txtNombre.Text;
                int cantidad = int.Parse(txtCantidad.Text);
                double precio = double.Parse(txtPrecioUnitario.Text);

                // Crear el objeto Medicamento y agregarlo a la lista
                Medicamento medicamento = new Medicamento(codigo, nombre, cantidad, precio);
                listaMedicamentos.Add(medicamento);

                // Mostrar mensaje de éxito
                MessageBox.Show("El medicamento ha sido agregado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos del formulario
                txtCodigo.Clear();
                txtNombre.Clear();
                txtCantidad.Clear();
                txtPrecioUnitario.Clear();
            }
            else
            {
                MessageBox.Show("La lista de medicamentos no ha sido inicializada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Medicamento
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public double Precio { get; set; }

            public Medicamento(string codigo, string nombre, int cantidad, double precio)
            {
                Codigo = codigo;
                Nombre = nombre;
                Cantidad = cantidad;
                Precio = precio;
            }
        }
    }
}
