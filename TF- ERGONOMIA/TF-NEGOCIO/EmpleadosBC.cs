using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF.DAC;
using TF.ENTITIES;

namespace TF.BC
{
    public class EmpleadosBC
    {
        public DataTable EmpleadosBC_GetAll()
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            DataTable dt = oEmpleadosDAC.Empleados_GetAll();
            return dt;
        }

        public int InsertEmpleadosBC(Empleados oempl)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            return oEmpleadosDAC.InsertEmpleados(oempl);
        }

        public DataTable Consultareempleadosdni(Empleados oempl)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            DataTable dt = oEmpleadosDAC.Consultarempleadospordni(oempl);
            return dt;
        }

        public int ObtenerSoloIdEmpresa(long CUIT)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            return oEmpleadosDAC.ObtenerSoloIdEmpresa(CUIT);
        }


        public int EmpleadosUpdate(Empleados oempl)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            return oEmpleadosDAC.ModificarEmpleados(oempl);
        }
    }
}
