using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class CEUsuario
    {
        private string c_nombre;
        private string c_codUsiario;
        public CEUsuario()
        {/**/
        }

        public CEUsuario(string c_nombre, string c_codusuario)
        {
            this.c_nombre = c_nombre;
            this.c_codUsiario = c_codusuario;
        }

        public string Nombre
        {
            get
            {
                return this.c_nombre;
            }
            set
            {
                this.c_nombre = value;
            }
        }

        public string CodUsuario
        {
            get
            {
                return this.c_codUsiario;
            }
            set
            {
                this.c_codUsiario = value;
            }
        }
    }
}
