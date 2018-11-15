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

namespace SAJA
{
    public partial class CambiarUsuarioContraseña : Form
    {
        public CambiarUsuarioContraseña()
        {
            InitializeComponent();
        }

        private void CambiarUsuarioContraseña_Load(object sender, EventArgs e)
        {
            CajaNuevoUsuario.Enabled = false;
            CajaNuevaContraseña.Enabled = false;
            btnActualizar.Enabled = false;
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

        public void SoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Ingrese solo letras");
                e.Handled = true;
            }
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Ingrese solo números");
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
                btnComprobar.PerformClick();
                e.Handled = true;
            }
        }

        private void CajaNuevoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            SinSimbolos(e);
            SinEspacio(e);
            CajaNuevoUsuario.MaxLength = 15;
            if (e.KeyChar == (char)13)
            {
                CajaNuevaContraseña.Focus();
                e.Handled = true;
            }
        }

        private void CajaNuevaContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            SinEspacio(e);
            CajaNuevaContraseña.MaxLength = 15;
            if (e.KeyChar == (char)13)
            {
                btnActualizar.PerformClick();
                e.Handled = true;
            }
        }
        public BD Conectar = new BD();
        private MySqlCommand comandosql = new MySqlCommand();
        private MySqlDataReader LeerFilas;


        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CajaUsuario.Text) | string.IsNullOrEmpty(CajaContraseña.Text))
            {
                MessageBox.Show("Hace falta ingresar usuario y/o contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (Mostrar2("select NickName, Contraseña from usuarios where NickName = '" + CajaUsuario.Text.ToUpper().Trim() + "' and Contraseña = '" + CajaContraseña.Text.Trim() + "'") == 1)
                {
                    CajaNuevoUsuario.Enabled = true;
                    CajaNuevaContraseña.Enabled = true;
                    btnActualizar.Enabled = true;
                    CajaNuevoUsuario.Focus();
                }
            }
        }


        public int Mostrar2(string comando)
        {
            try
            {
                int c= 0;
                comandosql.Connection = Conectar.AbrirConexion();
                comandosql.CommandText = comando;
                comandosql.CommandType = CommandType.Text;
                LeerFilas = comandosql.ExecuteReader();
                if (LeerFilas.HasRows)
                {
                    c = 1;
                }else
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

        private void Actualizar()
        {
            try
            {
                BD con = new BD();
                MySqlCommand comando = new MySqlCommand(string.Format("ACTUALIZAR_USUARIO_CONTRASEÑA"), con.AbrirConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("Nick1", CajaUsuario.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("NickNuevo", CajaNuevoUsuario.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("ContraNueva", CajaNuevaContraseña.Text.Trim());
                comando.ExecuteNonQuery();
                MessageBox.Show("Nombre de usuario y/o contraseña actualizados correctamente", "ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.CerrarConexion();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CajaNuevoUsuario.Text) | string.IsNullOrEmpty(CajaNuevaContraseña.Text))
            {
                MessageBox.Show("Hace falta ingresar usuario y/o contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Actualizar();
                CajaUsuario.Focus();
                CajaNuevoUsuario.Enabled = false;
                CajaNuevaContraseña.Enabled = false;
                btnActualizar.Enabled = false;
                CajaNuevoUsuario.Text = "";
                CajaNuevaContraseña.Text = "";
                CajaUsuario.Text = "";
                CajaContraseña.Text = "";
            }
        }
    }
}
