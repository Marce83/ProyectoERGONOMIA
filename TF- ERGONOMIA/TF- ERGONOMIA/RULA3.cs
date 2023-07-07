using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class RULA3 : Form
    {
        private RULARESULTADO formResultado;
        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;



        public RULA3()
        {
            InitializeComponent();
            formResultado = new RULARESULTADO();

        }

        public void RULACARGA3_Load(object sender, EventArgs e)
        {

            //Puntuacion del Tronco
            cbotronco.Items.Add(new ComboBoxOption("De pie", 1));
            cbotronco.Items.Add(new ComboBoxOption("0° a 20°", 2));
            cbotronco.Items.Add(new ComboBoxOption("20° a 60°", 3));
            cbotronco.Items.Add(new ComboBoxOption(">60°", 4));
            cbotroncotorcion.Items.Add(new ComboBoxOption("Torsión", 1));
            cbotroncotorcion.Items.Add(new ComboBoxOption("Inclinación Lateral", 1));
            cbotroncotorcion.Items.Add(new ComboBoxOption("Torsión e Inclinación Lateral", 2));

            //Puntuación de las Piernas
            cbopiernas.Items.Add(new ComboBoxOption("Pies y piernas Apoyadas y Peso simétrico", 1));
            cbopiernas.Items.Add(new ComboBoxOption("Pies y piernas No Apoyadas y Peso asimétrico", 2));

            //Puntuación actividad Muscular ( Grupo B )
            cboactmuscular2.Items.Add(new ComboBoxOption("Actividad Dinámica", 0));
            cboactmuscular2.Items.Add(new ComboBoxOption("Actividad Estática", 1));

            //Puntuación Carga / Fuerza (Grupo B)
            cbocargafuerza2.Items.Add(new ComboBoxOption(">2 kg intermitente", 0));
            cbocargafuerza2.Items.Add(new ComboBoxOption("2kg y 10kg intermitente", 1));
            cbocargafuerza2.Items.Add(new ComboBoxOption("2kg y 10kg estática", 2));
            cbocargafuerza2.Items.Add(new ComboBoxOption(">10kg estática y brusca", 3));

        }
        private void cbotronco_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado();
        }

        private void cbotroncotorcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado();
        }

        private void MostrarResultado()
        {
            int resultado = ObtenerNumeroSeleccionado(cbotronco) + ObtenerNumeroSeleccionado(cbotroncotorcion);

            if (resultado == 0)
            {
                resultado = 1;
            }

            txttroncofinal.Text = resultado.ToString();
        }

        private void cbopiernas_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado1();
        }

        private void MostrarResultado1()
        {
            int resultado1 = ObtenerNumeroSeleccionado(cbopiernas);

            if (resultado1 == 0)
            {
                resultado1 = 1;
            }

            txtpiernasfinal.Text = resultado1.ToString();
        }
        private void cboactmuscular2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado2();
        }
        private void MostrarResultado2()
        {
            int resultado2 = ObtenerNumeroSeleccionado(cboactmuscular2);

            if (resultado2 == 0)
            {
                resultado2 = 1;
            }
            txtmuscular2.Text = resultado2.ToString();
        }
        private void cbocargafuerza2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado3();
        }
        private void MostrarResultado3()
        {
            int resultado3 = ObtenerNumeroSeleccionado(cbocargafuerza2);

            if (resultado3 == 0)
            {
                resultado3 = 1;
            }
            txtcargafuerza2.Text = resultado3.ToString();
        }

        private void btnpagsig_Click(object sender, EventArgs e)
        {
            RULARESULTADO oRULACARGA4 = new RULARESULTADO();
            oRULACARGA4.Show();
            Close();
        }

        private void btnpagant_Click(object sender, EventArgs e)
        {
            RULA2 oRULACARGA2 = new RULA2();
            oRULACARGA2.Show();
            Close();
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


    }
}
