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
    public partial class Menu : Form
    {

        public List<Medicamento> listaMedicamentos;
        public Menu()
        {
            InitializeComponent();
            listaMedicamentos = new List<Medicamento>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la opción seleccionada del ComboBox
            

            // Ejecutar la acción correspondiente a la opción seleccionada
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Configurar las opciones del ComboBox
            comboBox1.Items.Add("Registrar medicamento");
            comboBox1.Items.Add("Mostrar lista de medicamentos");
            comboBox1.Items.Add("Buscar medicamentos por nombre");
            comboBox1.Items.Add("Eliminar medicamento");
            comboBox1.Items.Add("Ordenar lista de medicamentos por nombre");
            comboBox1.Items.Add("Salir");

            // Seleccionar la primera opción por defecto
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opcion = comboBox1.SelectedItem.ToString();
   
            switch (opcion)
            {
                case "Registrar medicamento":
                    Agregar Agregar = new Agregar(listaMedicamentos);
                    Agregar.ShowDialog();
                    break;

                case "Mostrar lista de medicamentos":
   

                    Mostrar Mostrar = new Mostrar(listaMedicamentos);
                    Mostrar.ShowDialog();
                    break;

                case "Buscar medicamentos por nombre":
                    Buscar Buscar = new Buscar(listaMedicamentos);
                    Buscar.ShowDialog();
                    break;

                case "Eliminar medicamento":
                    Eliminar Eliminar = new Eliminar(listaMedicamentos);
                    Eliminar.ShowDialog();
                    break;

                case "Ordenar lista de medicamentos por nombre":
                    Ordenar Ordenar = new Ordenar(listaMedicamentos);
                    Ordenar.ShowDialog();
                    break;

                case "Salir":
                    MessageBox.Show("¡Hasta luego!");
                    this.Close();
                    break;

                default:
                    MessageBox.Show("Opción inválida. Intente nuevamente.");
                    break;
            }
        }
     
    }
}
