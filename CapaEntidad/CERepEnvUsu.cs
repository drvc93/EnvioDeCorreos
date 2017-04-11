using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CERepEnvUsu
    {
        private string c_compania;
        private string c_reporteenvio;
        private string c_dia;
        private DateTime d_hora;
        private string c_usuarioenvio;
        private string c_estado;
        private string c_ultimousuario;
        private DateTime d_ultimafechamodificacion;

        public CERepEnvUsu()
        {

        }

        public CERepEnvUsu( string c_comp, string c_reporteenvio,string c_dia , DateTime d_hora,string c_usuarioenv , string c_estado ,
                            string c_ultusuario , DateTime d_ultimaFecha)
        {

            this.c_compania = c_comp;
            this.c_reporteenvio = c_reporteenvio;
            this.c_dia = c_dia;
            this.d_hora = d_hora;
            this.c_usuarioenvio = c_usuarioenv;
            this.c_estado = c_estado;
            this.c_ultimousuario = c_ultusuario;
            this.d_ultimafechamodificacion = d_ultimaFecha;
        }

        public DateTime DUltimafechamodificacion
        {
            get
            {
                return this.d_ultimafechamodificacion;
            }
            set
            {
                this.d_ultimafechamodificacion = value;
            }
        }

        public string CUltimousuario
        {
            get
            {
                return this.c_ultimousuario;
            }
            set
            {
                this.c_ultimousuario = value;
            }
        }

        public string CEstado
        {
            get
            {
                return this.c_estado;
            }
            set
            {
                this.c_estado = value;
            }
        }

        public string CUsuarioenvio
        {
            get
            {
                return this.c_usuarioenvio;
            }
            set
            {
                this.c_usuarioenvio = value;
            }
        }

        public DateTime DHora
        {
            get
            {
                return this.d_hora;
            }
            set
            {
                this.d_hora = value;
            }
        }

        public string CDia
        {
            get
            {
                return this.c_dia;
            }
            set
            {
                this.c_dia = value;
            }
        }

        public string CReporteenvio
        {
            get
            {
                return this.c_reporteenvio;
            }
            set
            {
                this.c_reporteenvio = value;
            }
        }

        public string CCompania
        {
            get
            {
                return this.c_compania;
            }
            set
            {
                this.c_compania = value;
            }
        }
    }
}
