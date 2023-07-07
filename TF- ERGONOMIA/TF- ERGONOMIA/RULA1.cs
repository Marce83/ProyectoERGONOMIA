using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.ENTITIES;
using TF.WIN;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TF.WIN
{
    public partial class RULA1 : Form
    {
       private RULARESULTADO formResultado;


        public RULA1()
        {
            InitializeComponent();
            formResultado = new RULARESULTADO();
        }

        public void RULA1_Load(object sender, EventArgs e)
        {


            // Puntuación de Brazo
            cboBrazoposicion.Items.Add(new ComboBoxOption("-20° a 20°", 1));
            cboBrazoposicion.Items.Add(new ComboBoxOption(">20 extensión", 2));
            cboBrazoposicion.Items.Add(new ComboBoxOption("20° a 45°", 2));
            cboBrazoposicion.Items.Add(new ComboBoxOption("45° a 90°", 3));
            cboBrazoposicion.Items.Add(new ComboBoxOption(">90°", 4));
            cboBrazoAbdApo.Items.Add(new ComboBoxOption("Normal", 0));
            cboBrazoAbdApo.Items.Add(new ComboBoxOption("Abducido", 1));
            cboBrazoAbdApo.Items.Add(new ComboBoxOption("Apoyado", -1));
            cboBrazoAbdApo.Items.Add(new ComboBoxOption("Abducido y Apoyado", 0));
            cbobrazoHombro.Items.Add(new ComboBoxOption("Hombro Normal", 0));
            cbobrazoHombro.Items.Add(new ComboBoxOption("Hombro Elevado", 1));

            // Puntuación Ante Brazo  
            antebrazoposicion.Items.Add(new ComboBoxOption("0° a 60°", 2));
            antebrazoposicion.Items.Add(new ComboBoxOption("60° a 100°", 1));
            antebrazoposicion.Items.Add(new ComboBoxOption(">100°", 2));
            antebrazocruza.Items.Add(new ComboBoxOption("Despejado del Cuerpo", 1));
            antebrazocruza.Items.Add(new ComboBoxOption("Cruza Línea del Cuerpo", 1));


            // Puntuación Muñeca
            muñecaposicion.Items.Add(new ComboBoxOption("Neutra", 1));
            muñecaposicion.Items.Add(new ComboBoxOption("0° a 15° de Flexión / Extensión", 2));
            muñecaposicion.Items.Add(new ComboBoxOption(">15°", 3));
            muñecadesviado.Items.Add(new ComboBoxOption("Desv. Radial", 1));
            muñecadesviado.Items.Add(new ComboBoxOption("Desv. Cubita", 1));

            // Puntuacion Giro de Muñeca
            cbogiroMuñeca.Items.Add(new ComboBoxOption("Rango Medio", 1));
            cbogiroMuñeca.Items.Add(new ComboBoxOption("Rango Final de Giro", 2));

        }

        private void cboBrazoposicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado1();

         }

        private void cboBrazoAbdApo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado1();
        }

        private void cbobrazoHombro_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado1();
        }

        private void MostrarResultado1()
        {
            int resultado1 = ObtenerNumeroSeleccionado(cboBrazoposicion) + ObtenerNumeroSeleccionado(cboBrazoAbdApo) + ObtenerNumeroSeleccionado(cbobrazoHombro);

            if (resultado1 == 0)
            {
                resultado1 = 1;
            }

            txtBrazoFinal.Text = resultado1.ToString();
        }

        private void antebrazoposicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado2();
        }

        private void antebrazocruza_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado2();
        }

        private void MostrarResultado2()
        {
            int resultado2 = ObtenerNumeroSeleccionado(antebrazoposicion) + ObtenerNumeroSeleccionado(antebrazocruza);

            if (resultado2 == 0)
            {
                resultado2 = 1;
            }

            txtantebrazofinal.Text = resultado2.ToString();
        }

        private void muñecaposicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado3();
        }

        private void muñecadesviado_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado3();
        }
        private void cbogiroMuñeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado3();
        }
        private void MostrarResultado3()
        {
            int resultado3 = ObtenerNumeroSeleccionado(muñecaposicion) + ObtenerNumeroSeleccionado(muñecadesviado) + ObtenerNumeroSeleccionado(cbogiroMuñeca);

            if (resultado3 == 0)
            {
                resultado3 = 1;
            }

            txtmunecafinal.Text = resultado3.ToString();
        }



        private int ObtenerNumeroSeleccionado(MaterialComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                ComboBoxOption selectedOption = comboBox.SelectedItem as ComboBoxOption;

                if (selectedOption != null)
                {
                    return selectedOption.Numero;
                }
            }

            return 0;
        }

        private void btnpagina2_Click(object sender, EventArgs e)
        {
            RULA2 oRULA2 = new RULA2();
            oRULA2.Show();
        }


    }
}

