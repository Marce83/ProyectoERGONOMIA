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
using TF.BC;
using TF.ENTITIES;
using TF.WIN;

namespace TF.WIN
{
    public partial class Nuevousuario : Form
    {
        UsuariosBC oUsuarioBC = new UsuariosBC();
        Usuarios oBe = new Usuarios();
        frmMenuPrincipal frmMenu = new frmMenuPrincipal();
        public static string UsrNom;
        frmLogin oLogin = new frmLogin();

        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;


        public Nuevousuario()
        {
            InitializeComponent();


            //materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Amber400, MaterialSkin.Accent.Amber200, MaterialSkin.TextShade.BLACK);
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }
        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            if (ValidarClave(txtClave.Text))
            {
                CargarUsuario.Enabled = true;
            }
            else
            {
                CargarUsuario.Enabled = false;
            }
        }
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }
        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }
        private void CargarUsuario_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Usuarios oBe = new Usuarios();
            oBe.Usuario = txtusuario.Text;
            oBe.Clave = txtClave.Text;
            oBe.Nombre = txtnombre.Text;
            oBe.Apellido = txtapellido.Text;
            UsuariosBC oUsuariosBC = new UsuariosBC();

            if (txtusuario.Text != string.Empty)
            {
                if (txtClave.Text != string.Empty)
                {
                    if (txtnombre.Text != string.Empty)
                    {
                        if (txtapellido.Text != string.Empty)
                        {
                            if(txtConfClave.Text != string.Empty)
                            {
                                if(txtConfClave.Text == txtClave.Text)
                                {
                                    try
                                    {
                                        oUsuarioBC.BuscarUsr(oBe);
                                        var res = oUsuariosBC.Insertusuario(oBe);
                                        MessageBox.Show("Usuario Ingresado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                        oLogin.Show();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                        Limpiar();
                                    }
                                }
                                else MessageBox.Show("No coincide con la Contraseña ingresada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("Debe repetir la Contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Debe ingresar el apellido del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Debe ingresar el nombre del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Debe ingresar una Contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Debe ingresar un nombre de Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show("¿Está seguro que desea salir? Se perderan los datos que no se guardaron", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mess == DialogResult.Yes)
            {
                //this.Hide();
                //frmMenu.Show();
                oLogin.Show();
                this.Close();
            }
        }

        private void Limpiar()
        {
            txtusuario.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtapellido.Text = string.Empty;
            txtusuario.Focus();
        }

        private bool ValidarClave (string clave)
        {
            bool May = false, Min = false, Num = false, CarEsp = false;
            for(int i = 0; i < clave.Length; i++) 
            {
                if (char.IsUpper(clave,i))
                    May = true;
                else if (char.IsLower(clave, i))
                    Min = true;
                else if (char.IsDigit(clave, i))
                    Num = true;
                else
                    CarEsp = true;
            }
            if (May && Min && Num && CarEsp && clave.Length >= 8)
                return true; 
            else return false;
        }

        private void chbVisualizarClave_CheckedChanged(object sender, EventArgs e)
        {
            if(chbVisualizarClave.Checked) 
            {
                txtClave.PasswordChar = '\0';
                txtConfClave.PasswordChar = '\0';
            }
            else
            {
                txtClave.PasswordChar = '*';
                txtConfClave.PasswordChar = '*';
            }
        }
    }
}
