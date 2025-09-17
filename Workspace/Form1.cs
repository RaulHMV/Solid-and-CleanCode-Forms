using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workspace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boton1_Click(object sender, EventArgs e)
        {
            string input = input1.Text;
            inicio();

        }
        private void inicio() {
            boton1.Hide();
            Cnombre.Hide();
            input1.Hide();
            Chola.Text= $"Hola {input1.Text}" ;
            Chola.Show();
            Cselecciona.Show();
            comboBox1.Show();
            boton2.Show();
        }
        private void Calcular()
        {
            Csalario.Show();
            input2.Show();
            dataGridView1.Show();
            boton3.Show();
            Chola.Hide();
            Cselecciona.Hide();
            comboBox1.Hide();
            boton2.Hide();
            botonImprimir.Show();
            btnRegresar.Show();
        }
        private void descalcular()
        {
            Csalario.Hide();
            input2.Hide();
            dataGridView1.Hide();
            boton3.Hide();
            botonImprimir.Hide();
            boton1.Show();
            Cnombre.Show();
            input1.Show();
            btnRegresar.Hide();
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Profesores")
            {
;               Calcular();
            }
            else if (comboBox1.Text == "Profesores 1-10")
            {
                Calcular();

            }
            else if (comboBox1.Text == "Profesores +10")
            {
                Calcular();

            }
        }
        private double iff(double salario)
            {
                if (salario <= 0)
                {
                    return 1;
                }
            return salario;
        }
        private IProfesorRepository repo = new ProfesorRepository();

        private void boton3_Click(object sender, EventArgs e)
        {
            if (input2.Text == "")
            {
                input2.Text = "1";
            }
            double salario = double.Parse(input2.Text);
            salario = iff(salario);

            Profesor prof;
            if (comboBox1.Text == "Profesores")
                prof = new ProfesorNormal { Nombre = input1.Text, Salario = salario, AniosTrabajando = 0 };
            else if (comboBox1.Text == "Profesores 1-10")
                prof = new Profesor1a10 { Nombre = input1.Text, Salario = salario, AniosTrabajando = 5 };
            else
                prof = new ProfesorMas10 { Nombre = input1.Text, Salario = salario, AniosTrabajando = 12 };

            repo.AgregarProfesor(prof);
        }

        private void botonImprimir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repo.ObtenerProfesores()
                                   .Select(p => new { p.Nombre, SalarioConAumento = p.CalcularAumento() })
                                   .ToList();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            descalcular();
            inicio();
        }
    }
}
