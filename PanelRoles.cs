using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAJA
{
    public partial class PanelRoles : Form
    {
        public PanelRoles()
        {
            InitializeComponent();
        }

        public BD Conectar = new BD();
        private MySqlCommand comandosql = new MySqlCommand();
        private MySqlDataReader LeerFilas;

        public DataTable MostrarRoles()
        {
            try
            {
                DataTable Tabla = new DataTable();
                comandosql.Connection = Conectar.AbrirConexion();
                comandosql.CommandText = "select * from roles";
                comandosql.CommandType = CommandType.Text;
                LeerFilas = comandosql.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conectar.CerrarConexion();
                return Tabla;
            }
            catch(Exception e)
            {
                MessageBox.Show("Error en la conexión a la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }

        }

        private void Roles_Load(object sender, EventArgs e)
        {
            tablaRoles.DataSource = MostrarRoles();
            tablaRoles.Columns[0].HeaderText = "Cargo";
            tablaRoles.Columns[1].HeaderText = "Estado";
        }

        //insertar
        private void Agregar()
        {
            try
            {
                BD con = new BD();
                MySqlCommand comando = new MySqlCommand(string.Format("AÑADIR_ROL"), con.AbrirConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("IdNomRol", CajaCargo.Text.ToUpper().Trim());
                comando.ExecuteNonQuery();
                MessageBox.Show("Cargo ingresado a la base de datos correctamente", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.CerrarConexion();
                tablaRoles.DataSource = MostrarRoles();
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Error en la base de datos");
            }
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CajaCargo.Text))
            {
                MessageBox.Show("Hace falta ingresar el cargo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int d = ValidarId("select * from roles where IdNombreRol = '" + CajaCargo.Text.ToUpper().Trim() + "'");
                if (d == 0)
                {
                    Agregar();
                    CajaCargo.Text = "";
                }
                else
                {
                    MessageBox.Show("El cargo ingresado ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void Actualizar()
        {
            try
            {
                BD con = new BD();
                MySqlCommand comando = new MySqlCommand(string.Format("ACTUALIZAR_ROL"), con.AbrirConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("IdRolAntiguo", CajaCargoAntiguo.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("IdRol", CajaCargoNuevo.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("Est", comboEstado.SelectedItem);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cargo actualizado correctamente", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.CerrarConexion();
                tablaRoles.DataSource = MostrarRoles();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error en la base de datos");
            }
        }

    
        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string z = "Hace falta ingresar:   \n";
            
            if (string.IsNullOrEmpty(CajaCargoAntiguo.Text))
            {
                z = z + "Cargo a actualizar.   \n";
            }
            if (string.IsNullOrEmpty(CajaCargoNuevo.Text))
            {
                z = z + "Nuevo cargo.   \n";
            }
            if (string.IsNullOrEmpty(comboEstado.Text))
            {
                z = z + "Estado.  ";
            } 
            if(string.IsNullOrEmpty(CajaCargoAntiguo.Text) | string.IsNullOrEmpty(CajaCargoNuevo.Text) | string.IsNullOrEmpty(comboEstado.Text)){
                MessageBox.Show(z, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int d = ValidarId("select * from roles where IdNombreRol = '" + CajaCargoAntiguo.Text.ToUpper().Trim() + "'");
                if (d == 1)
                {
                    if (CajaCargoAntiguo.Text.ToUpper().Trim() != CajaCargoNuevo.Text.ToUpper().Trim())
                    {
                        int f = ValidarId("select * from roles where IdNombreRol = '" + CajaCargoNuevo.Text.ToUpper().Trim() + "'");
                        if (f == 0)
                        {
                            Actualizar();
                            LimpiarCajas();
                        }
                        else
                        {
                            MessageBox.Show("El nuevo cargo ingresado ya se encuentra en uso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                    }
                    else
                    {
                        Actualizar();
                        LimpiarCajas();
                    }
                }
                else
                {
                    MessageBox.Show("El cargo a actualizar no se encuentra en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void CajaCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SinSimbolos(e);
                SinEspacio(e);
                CajaCargo.MaxLength = 15;
            if(e.KeyChar == (char)13)
            {
                btnInsertar.PerformClick();
                e.Handled = true;
            }
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

        private void CajaCargoAntiguo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SinSimbolos(e);
                SinEspacio(e);
                CajaCargoAntiguo.MaxLength = 15;
            if (e.KeyChar == (char)13)
            {
                CajaCargoNuevo.Focus();
                e.Handled = true;
            }
        }

        private void CajaCargoNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SinSimbolos(e);
                SinEspacio(e);
            CajaCargoNuevo.MaxLength = 15;
            if (e.KeyChar == (char)13)
            {
                comboEstado.Focus();
                e.Handled = true;
            }
        }

        private void comboEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnActualizar.PerformClick();
                e.Handled = true;
            }
        }

        private void tablaRoles_SelectionChanged(object sender, EventArgs e)
        {
            if (tablaRoles.SelectedRows.Count == 0)
            {
                return;
            }
            CajaCargoAntiguo.Text = tablaRoles[0, tablaRoles.SelectedRows[0].Index].Value.ToString();
            CajaCargoNuevo.Text = tablaRoles[0, tablaRoles.SelectedRows[0].Index].Value.ToString();
            comboEstado.Text = tablaRoles[1, tablaRoles.SelectedRows[0].Index].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void LimpiarCajas()
        {
            CajaCargoAntiguo.Text = "";
            CajaCargoNuevo.Text = "";
            comboEstado.SelectedItem = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        public int ValidarId(string comando)
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

        private void PanelRoles_FormClosing(object sender, FormClosingEventArgs e)
        {
            Padre.SegRoles = 0;
        }
    }
    }

