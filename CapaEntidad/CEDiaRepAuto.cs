using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEDiaRepAuto
    {
        private string codDia;
        private string dia;

        public CEDiaRepAuto() { }

        public CEDiaRepAuto(string codDia, string dia)
        {
            this.codDia = codDia;
            this.dia = dia;

        }

        public string Dia
        {
            get
            {
                return this.dia;
            }
            set
            {
                this.dia = value;
            }
        }

        public string CodDia
        {
            get
            {
                return this.codDia;
            }
            set
            {
                this.codDia = value;
            }
        }
    }
}
