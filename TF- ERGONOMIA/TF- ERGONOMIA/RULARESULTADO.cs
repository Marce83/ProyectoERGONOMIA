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
using TF.WIN;

namespace TF.WIN
{
    public partial class RULARESULTADO : Form
    {

        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public RULARESULTADO()
        {
            InitializeComponent();

            //materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Amber400, MaterialSkin.Accent.Amber200, MaterialSkin.TextShade.BLACK);




        }

        private void button4_Click(object sender, EventArgs e)
        {
            RULA3 oRULACARGA3 = new RULA3();
            oRULACARGA3.Show();
            Close();
        }

        private void RULACARGA4_Load(object sender, EventArgs e)
        {
            RULA1 ORULA1 = new RULA1();
            RULA2 ORULA2 = new RULA2();
            RULA3 ORULA3 = new RULA3();

            //txtantebrazo.Text = TextBoxValue;
            //txtmuneca.Text = ORULA1.txtmunecafinal;
            //txtmusculaturaA.Text = ORULA2.actividadgrupoAfinal;
            //txtcargafuerzaA.Text = ORULA2.txtcargafuerzafinal;
            //txtcuelloB.Text = ORULA2.txtcuellofinal;
            //txttroncoB.Text = ORULA3.txttroncofinal;
            //txtpiernaB.Text = ORULA3.txtpiernasfinal;
            //txtmusculaturaB.Text = ORULA3.txtmuscular2;
            //txtcargafuerzaB.Text = ORULA3.txtcargafuerza2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
