using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEAcceso
    {
        private string niveles;
        private string acceso;
        private string nuevo;
        private string modificar;
        private string eliminar;
        private string otros;

        public CEAcceso() { }

        public CEAcceso(string Niveles, string Acceso, string Nuevo, string Modificar, string Eliminar, string Otros)
        {
            this.niveles = Niveles;
            this.acceso = Acceso;
            this.nuevo = Nuevo;
            this.modificar = Modificar;
            this.eliminar = Eliminar;
            this.otros = Otros;
        }

        public string Otros
        {
            get
            {
                return this.otros;
            }
            set
            {
                this.otros = value;
            }
        }

        public string Eliminar
        {
            get
            {
                return this.eliminar;
            }
            set
            {
                this.eliminar = value;
            }
        }

        public string Modificar
        {
            get
            {
                return this.modificar;
            }
            set
            {
                this.modificar = value;
            }
        }

        public string Nuevo
        {
            get
            {
                return this.nuevo;
            }
            set
            {
                this.nuevo = value;
            }
        }

        public string Acceso
        {
            get
            {
                return this.acceso;
            }
            set
            {
                this.acceso = value;
            }
        }

        public string Niveles
        {
            get
            {
                return this.niveles;
            }
            set
            {
                this.niveles = value;
            }
        }
    }
}
