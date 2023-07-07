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
using TF.COMMON.Cache;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void Empleadoss_Load(object sender, EventArgs e)
        {
            RolesCargo();
            Listar();
        }

        private void btnBuscarCUIT_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            oFrm.ShowDialog();

            if (oFrm.EmpresaSeleccionada != null)
            {
                txtCUITEncontrado.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();
            }
        }

        private void RolesCargo()
        {
            if (UserLoginCache.Cargo == Cargos.Recepcionista)
            {
                btnCargar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Profesional)
            {
                btnEliminar.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Contador)
            {
                btnEliminar.Enabled = false;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            Empleados oBe = new Empleados();
            DialogResult resp = MessageBox.Show("¿Está seguro que desea cargar el siguiente Empleado?", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                if (txtDNI.Text != string.Empty)
                {
                    try
                    {
                        oBe.DNI = txtDNI.Text;
                        oBe.Apellido = txtApellido.Text;
                        oBe.Nombre = txtNombre.Text;
                        oBe.FechaNacimiento = Convert.ToDateTime(dtpNacimiento.Text);
                        oBe.Genero = cboGenero.Text;
                        oBe.Peso = float.Parse(txtPeso.Text);
                        oBe.Altura = float.Parse(txtAltura.Text);
                        oBe.PuestoDeTrabajo = txtPuestoDeTrabajo.Text;
                        long CUIL = Convert.ToInt64(txtCUITEncontrado.Text);
                        var BuscarId = oEmpleadosBC.ObtenerSoloIdEmpresa(CUIL);
                        oBe.IdEmpresa = Convert.ToInt32(BuscarId);

                        var res = oEmpleadosBC.InsertEmpleadosBC(oBe);
                        MessageBox.Show("Empleado cargado exitosamente");
                        //Esto es una prueba para Git
                        Listar();
                        Limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("Debe ingresar el DNI");
            }
            Listar();
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Empleados oempl = new Empleados();
            oempl.DNI = txtcuitconsulta.Text;

            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            DataTable dt = oEmpleadosBC.Consultareempleadosdni(oempl);

            dgvempleados.DataSource = null;
            dgvempleados.DataSource = dt;
            //dgvempleados.Columns[0].Visible = false;
            Listar();
        }

        private void Listar()
        {
            try
            {
                EmpleadosBC oEmpleadosBC = new EmpleadosBC();
                DataTable dt = oEmpleadosBC.EmpleadosBC_GetAll();
                dgvempleados.DataSource = null;
                dgvempleados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            txtDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            dtpNacimiento.Text = string.Empty;
            cboGenero.SelectedIndex = 0;
            txtPuestoDeTrabajo.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtAltura.Text = string.Empty;
            txtCUITEncontrado.Text = string.Empty;
            txtDNI.Focus();

        }
        private void dgvempleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvempleados.CurrentRow.Cells[0].Value.ToString();
            txtApellido.Text = dgvempleados.CurrentRow.Cells[1].Value.ToString();
            txtDNI.Text = dgvempleados.CurrentRow.Cells[2].Value.ToString();
            cboGenero.Text = dgvempleados.CurrentRow.Cells[3].Value.ToString();
            txtPeso.Text = dgvempleados.CurrentRow.Cells[4].Value.ToString();
            txtPuestoDeTrabajo.Text = dgvempleados.CurrentRow.Cells[5].Value.ToString();
            txtAltura.Text = dgvempleados.CurrentRow.Cells[6].Value.ToString();
            dtpNacimiento.Text = dgvempleados.CurrentRow.Cells[7].Value.ToString();
            //txtCUITEncontrado.Text = dgvempleados.CurrentRow.Cells[8].Value.ToString();
            //dgvempleados.CurrentRow.Cells[9].Value.ToString();
           // dgvempleados.CurrentRow.Cells[10].Value.ToString();


        }

        private void btnBuscartodo_Click_1(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            Empleados oBe = new Empleados();
            DialogResult resp = MessageBox.Show("¿Está seguro que desea modificar este Empleado?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                if (txtDNI.Text != string.Empty)
                {
                    try
                    {
                        oBe.Nombre = txtNombre.Text;
                        oBe.Apellido = txtApellido.Text;
                        oBe.DNI = txtDNI.Text;
                        oBe.Genero = cboGenero.Text;
                        oBe.PuestoDeTrabajo = txtPuestoDeTrabajo.Text;
                        oBe.Peso = float.Parse(txtPeso.Text);
                        oBe.Altura = float.Parse(txtAltura.Text);
                        oBe.FechaNacimiento = Convert.ToDateTime(dtpNacimiento.Text);

                        var res = oEmpleadosBC.EmpleadosUpdate(oBe);
                        MessageBox.Show("Empleado modificado exitosamente");
                        Listar();
                        Limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("Verifique los Datos a modificar");
            }
            Listar();
            Limpiar();
        }
    }
}
