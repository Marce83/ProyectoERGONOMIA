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
using TF.WIN;

namespace TF.WIN
{
    public partial class RULA2 : Form
    {
        private RULARESULTADO formResultado;
        // readonly MaterialSkin.MaterialSkinManager materialSkinManager;



        public RULA2()
        {
            InitializeComponent();
            formResultado = new RULARESULTADO();
            //materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Amber400, MaterialSkin.Accent.Amber200, MaterialSkin.TextShade.BLACK);




        }

         public void RULACARGA2_Load(object sender, EventArgs e)
        {
 
            // Puntuacion tipo actividad manual ( grupo A)
            cboactmanuala.Items.Add(new ComboBoxOption("Actividad Dinámica", 1));
            cboactmanuala.Items.Add(new ComboBoxOption("Actividad Estática", 2));

            // Puntuacion Carga/Fuerza
            cbocargafuerza.Items.Add(new ComboBoxOption("< 2 kg Intermitente", 1));
            cbocargafuerza.Items.Add(new ComboBoxOption("2kg y 10kg intermitente", 2));
            cbocargafuerza.Items.Add(new ComboBoxOption("2kg y 10kg estática", 1));
            cbocargafuerza.Items.Add(new ComboBoxOption("> 10kg ambas", 2));

            // Puntuacion del Cuello
            cuellopuntuacion.Items.Add(new ComboBoxOption("0° a 10°", 1));
            cuellopuntuacion.Items.Add(new ComboBoxOption("10° a 20°", 2));
            cuellopuntuacion.Items.Add(new ComboBoxOption(">20°", 2));
            cuelloposicion.Items.Add(new ComboBoxOption("Rotado", 0));
            cuelloposicion.Items.Add(new ComboBoxOption("Lateral", 1));
        }

        private void cboactmanuala_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado2();
        }
        private void MostrarResultado2()
        {
            int resultado2 = ObtenerNumeroSeleccionado(cboactmanuala);

            if (resultado2 == 0)
            {
                resultado2 = 1;
            }

            actividadgrupoAfinal.Text = resultado2.ToString();
        }

        private void cbocargafuerza_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado3();
        }

        private void MostrarResultado3()
        {
            int resultado3 = ObtenerNumeroSeleccionado(cbocargafuerza);

            if (resultado3 == 0)
            {
                resultado3 = 1;
            }

            txtcargafuerzafinal.Text = resultado3.ToString();
        }


        private void cuellopuntuacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado();
        }

        private void cuelloposicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado();
        }

        private void MostrarResultado()
        {
            int resultado = ObtenerNumeroSeleccionado(cuellopuntuacion) + ObtenerNumeroSeleccionado(cuelloposicion);

            if (resultado == 0)
            {
                resultado = 1;
            }

            txtcuellofinal.Text = resultado.ToString();
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

        private void btnpagsig_Click(object sender, EventArgs e)
        {
            RULA3 oRULACARGA3 = new RULA3();
            oRULACARGA3.Show();
            Close();
        }

        private void btnpagant_Click(object sender, EventArgs e)
        {
            RULA1 oRULA1 = new RULA1();
            oRULA1.Show();
            Close();
        }
    }
}
