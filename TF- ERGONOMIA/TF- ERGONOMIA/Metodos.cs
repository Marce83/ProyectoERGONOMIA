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
    public partial class Metodos : Form
    {
        public Metodos()
        {
            InitializeComponent();
        }

        private void btnRula_Click(object sender, EventArgs e)
        {

            RULA1 oRULA1 = new RULA1();
            oRULA1.Show();
        }
    }
}
