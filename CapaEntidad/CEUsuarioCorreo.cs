using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEUsuarioCorreo
    {
        private string c_usario;
        private string c_correo;


        public CEUsuarioCorreo(){
        }

        public CEUsuarioCorreo(string c_usu , string c_correo)
        {
            this.c_correo = c_correo;
            this.c_usario = c_usu;
        }

        public string CCorreo
        {
            get
            {
                return this.c_correo;
            }
            set
            {
                this.c_correo = value;
            }
        }

        public string CUsario
        {
            get
            {
                return this.c_usario;
            }
            set
            {
                this.c_usario = value;
            }
        }
    }
}
