using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TF.ENTITIES;
using TF.DAC;
using TF.COMMON.Cache;

namespace TF.BC
{
    public class UsuariosBC
    {
        public DataTable Login(Usuarios oBe)
        {
            UsuariosDAC oUsuariosDAC = new UsuariosDAC();
            DataTable dt = oUsuariosDAC.Login(oBe);
            return dt;
        }

        public int Insertusuario(Usuarios oBe)
        {
            UsuariosDAC oUsuariosDAC = new UsuariosDAC();
            return oUsuariosDAC.Insertusuario(oBe);
        }

        public void BuscarUsr(Usuarios oBe)
        {
            UsuariosDAC oUsuariosDAC = new UsuariosDAC();
            if(oUsuariosDAC.ExisteUsr(oBe.Usuario)) 
            {
                throw new Exception("El usuario ya existe, por favor ingrese otro.");
            }
        }
        public bool UserLogin(string Usuario, string Clave)
        {
            UsuariosDAC oUsuariosDAC = new UsuariosDAC();
            return oUsuariosDAC.UserLogin(Usuario, Clave);
        }
        public void PermisosRoles()
        {
            if (UserLoginCache.Cargo == Cargos.Administrador)
            { }
            if (UserLoginCache.Cargo == Cargos.Recepcionista)
            { }
            if (UserLoginCache.Cargo == Cargos.Profesional)
            { }
            if (UserLoginCache.Cargo == Cargos.Contador)
            { }
        }
    }
}
