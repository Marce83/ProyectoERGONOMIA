﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.ENTITIES
{
    public class Empresas
    {
        public int IdEmpresa { get; set; }
        public string CUIT { get; set; }
        public string Nombre { get; set; }
        public string Condicion_Fiscal { get; set; }
        public string Actividad_Empresarial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Web { get; set; }
    }
}
