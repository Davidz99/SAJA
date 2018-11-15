using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SAJA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        public void SinEspacio(KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                MessageBox.Show("No se admiten espacios");
                e.Handled = true;
            }
        }

        public void SinSimbolos(KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) | Char.IsWhiteSpace(e.KeyChar) | Char.IsControl(e.KeyChar))
            { }
            else
            {
                MessageBox.Show("No se admiten simbolos");
                e.Handled = true;
            }
        }


        private void CajaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            SinSimbolos(e);
            SinEspacio(e);
            CajaUsuario.MaxLength = 15;
            if (e.KeyChar == (char)13)
            {
                CajaContraseña.Focus();
                e.Handled = true;
            }
        }

        private void CajaContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            SinEspacio(e);
            CajaContraseña.MaxLength = 15;
            if (e.KeyChar == (char)13)
            {
                btnIngresar.PerformClick();
                e.Handled = true;
            }
        }

        public BD Conectar = new BD();
        private MySqlCommand comandosql = new MySqlCommand();
        private MySqlCommand comandosql2 = new MySqlCommand();
        private MySqlDataReader LeerFilas;

        public int Mostrar2(string comando)
        {
            try
            {
                int c = 0;
                comandosql.Connection = Conectar.AbrirConexion();
                comandosql.CommandText = comando;
                comandosql.CommandType = CommandType.Text;
                LeerFilas = comandosql.ExecuteReader();
                if (LeerFilas.HasRows)
                {
                    c = 1;
                    comandosql2.CommandText = "update usuarios set FechaIngreso = now() where NickName = '" + CajaUsuario.Text.ToUpper().Trim() + "' and Contraseña = '" + CajaContraseña.Text.Trim() + "'" ;
                    comandosql2.CommandType = CommandType.Text;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                LeerFilas.Close();
                Conectar.CerrarConexion();
                return c;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la conexión a la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 123;
            }

        }
        Thread th;
        public static int SegPadre = 0;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CajaUsuario.Text) | string.IsNullOrEmpty(CajaContraseña.Text))
            {
                MessageBox.Show("Hace falta ingresar usuario y/o contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (Mostrar2("select NickName, Contraseña from usuarios where NickName = '" + CajaUsuario.Text.ToUpper().Trim() + "' and Contraseña = '" + CajaContraseña.Text.Trim() + "'") == 1)
                {
                    if (SegPadre == 0)
                    {
                        this.Close();
                        th = new Thread(opennewform);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                }
            }
        }

        private void opennewform(object obj)
        {
            Application.Run(new Padre());
        }
    }
}
