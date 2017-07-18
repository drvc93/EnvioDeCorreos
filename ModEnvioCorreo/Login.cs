using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaData;
using DevExpress.XtraEditors;

namespace ModEnvioCorreo
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //txtUsuario
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string sValidar = "", sLogin = "";
            sValidar = ValidarUsuario(txtUser.Text);
            if (sValidar != "OK")
            {
                XtraMessageBox.Show("Error : " + sValidar, "Aviso", MessageBoxButtons.OK);
                return;
            }

            else 
            {
                sLogin = LoginUser();
                if (sLogin != "OK")
                {
                    XtraMessageBox.Show("Error : " + sLogin, "Aviso", MessageBoxButtons.OK);
                    return;
                }

                else 
                {
                    Form1 f = new Form1();
                    f.barStaticUser.Caption = txtUser.Text;
                    f.NombreUsuario(txtUser.Text);
                    f.Accesos(txtUser.Text);
                    this.Hide();
                    f.Show();         
                }
            
            }


        }

        public string ValidarUsuario(string usuario )
        {
            CDUsuario us = new CDUsuario();
            string res = us.ValidarUsuario(txtUser.Text);
            return res;
        
        }

        public string LoginUser() {
            CDUsuario us = new CDUsuario();
            string res = us.AutenticarUsuairo(txtUser.Text , txtContra.Text);
            return res;
        }
    }
}
