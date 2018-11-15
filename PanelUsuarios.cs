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
    public partial class PanelUsuarios : Form
    {
        public PanelUsuarios()
        {
            InitializeComponent();
        }

        public BD Conectar = new BD();
        private MySqlCommand comandosql = new MySqlCommand();
        private MySqlDataReader LeerFilas;

        public DataTable Mostrar(string comando)
        {
            try
            {
                DataTable Tabla = new DataTable();
                comandosql.Connection = Conectar.AbrirConexion();
                comandosql.CommandText = comando;
                comandosql.CommandType = CommandType.Text;
                LeerFilas = comandosql.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conectar.CerrarConexion();
                return Tabla;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la conexión a la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            TablaUsuarios.DataSource = Mostrar("select IdUsuario, IdNombreRol, NomUsuario, ApeUsuario, FechaIngreso, Estado from usuarios");
            TablaUsuarios.Columns[0].HeaderText = "No.Identificación";
            TablaUsuarios.Columns[1].HeaderText = "Cargo";
            TablaUsuarios.Columns[2].HeaderText = "Nombres";
            TablaUsuarios.Columns[3].HeaderText = "Apellidos";
            TablaUsuarios.Columns[4].HeaderText = "Último ingreso";
            TablaUsuarios.Columns[5].HeaderText = "Estado";

            ComboCargo.DataSource = Mostrar("select IdNombreRol from roles where Estado = 'ACTIVO'");
            ComboCargo.DisplayMember = ("IdNombreRol");
            ComboCargo.ValueMember = "IdNombreRol";

            ComboCargo1.DataSource = Mostrar("select IdNombreRol from roles where Estado = 'ACTIVO'");
            ComboCargo1.DisplayMember = ("IdNombreRol");
            ComboCargo1.ValueMember = "IdNombreRol";
        }

        private void comboOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
            if (comboOrdenar.Text == "NO. IDENTIFICACIÓN")
            {
                TablaUsuarios.DataSource = Mostrar("select IdUsuario, IdNombreRol, NomUsuario, ApeUsuario, FechaIngreso, Estado from usuarios order by IdUsuario");
            }
            if(comboOrdenar.Text == "NOMBRES")
            {
                TablaUsuarios.DataSource = Mostrar("select IdUsuario, IdNombreRol, NomUsuario, ApeUsuario, FechaIngreso, Estado from usuarios order by NomUsuario");
            }
            if(comboOrdenar.Text == "APELLIDOS")
            {
                TablaUsuarios.DataSource = Mostrar("select IdUsuario, IdNombreRol, NomUsuario, ApeUsuario, FechaIngreso, Estado from usuarios order by ApeUsuario");
            }
        }


        private void Agregar()
        {
            try
            {
                BD con = new BD();
                MySqlCommand comando = new MySqlCommand(string.Format("AGREGAR_USUARIO"), con.AbrirConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("IdUser", CajaId.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("IdNomRol1", ComboCargo.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("Nick", CajaUsuario.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("Contra", CajaContraseña.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("NomUser", CajaNombres.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("ApeUser", CajaApellidos.Text.ToUpper().Trim());
                
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario ingresado a la base de datos correctamente", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.CerrarConexion();
                TablaUsuarios.DataSource = Mostrar("select IdUsuario, IdNombreRol, NomUsuario, ApeUsuario, FechaIngreso, Estado from usuarios");
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error en la base de datos");
            }
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string z = "Hace falta ingresar:   \n";

            if (string.IsNullOrEmpty(CajaId.Text))
            {
                z = z + "No.Identificación.   \n";
            }
            if (string.IsNullOrEmpty(ComboCargo.Text))
            {
                z = z + "Cargo.   \n";
            }
            if (string.IsNullOrEmpty(CajaNombres.Text))
            {
                z = z + "Nombres.  \n";
            }
            if (string.IsNullOrEmpty(CajaApellidos.Text))
            {
                z = z + "Apellidos.  \n";
            }
            if (string.IsNullOrEmpty(CajaUsuario.Text))
            {
                z = z + "Nombre de usuario.  \n";
            }
            if (string.IsNullOrEmpty(CajaContraseña.Text))
            {
                z = z + "Contraseña.  ";
            }
            if (string.IsNullOrEmpty(CajaId.Text) | string.IsNullOrEmpty(ComboCargo.Text) | string.IsNullOrEmpty(CajaNombres.Text) | string.IsNullOrEmpty(CajaApellidos.Text) |
                string.IsNullOrEmpty(CajaUsuario.Text) | string.IsNullOrEmpty(CajaContraseña.Text))
            {
                MessageBox.Show(z, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int d = ValidarId("select * from usuarios where IdUsuario = '" + CajaId.Text.ToUpper().Trim() + "'");
                if (d == 0)
                {
                    Agregar();
                    LimpiarInsertar();
                }
                else
                {
                    MessageBox.Show("El usuario ingresado ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
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

        private void CajaId_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
            SinSimbolos(e);
            SinEspacio(e);
            CajaId.MaxLength = 15;
            if (e.KeyChar == (char)13)
            {
                ComboCargo.Focus();
                e.Handled = true;
            }
        }

        private void ComboCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CajaNombres.Focus();
                e.Handled = true;
            }
        }

        private void CajaNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
            SinSimbolos(e);
            if (string.IsNullOrEmpty(CajaNombres.Text))
            {
                SinEspacio(e);
            }
            CajaNombres.MaxLength = 20;
            if (e.KeyChar == (char)13)
            {
                CajaApellidos.Focus();
                e.Handled = true;
            }
        }

        private void CajaApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
            SinSimbolos(e);
            if (string.IsNullOrEmpty(CajaApellidos.Text))
            {
                SinEspacio(e);
            }
            CajaApellidos.MaxLength = 20;
            if (e.KeyChar == (char)13)
            {
                CajaUsuario.Focus();
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
                btnInsertar.PerformClick();
                e.Handled = true;
            }
        }

        public void LimpiarInsertar()
        {
            CajaId.Text = "";
            ComboCargo.Text = "";
            CajaNombres.Text = "";
            CajaApellidos.Text = "";
            CajaUsuario.Text = "";
            CajaContraseña.Text = "";
        }

        public void LimpiarActualizar()
        {
            CajaIdAntiguo.Text = "";
            CajaId1.Text = "";
            ComboCargo1.SelectedItem = null;
            CajaNombres1.Text = "";
            CajaApellidos1.Text = "";
            ComboEstado1.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarInsertar();
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            LimpiarActualizar();
        }

        private void CajaIdAntiguo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
            SinSimbolos(e);
            SinEspacio(e);
            CajaIdAntiguo.MaxLength = 15;
            if (e.KeyChar == (char)13)
            {
                CajaId1.Focus();
                e.Handled = true;
            }
        }

        private void CajaId1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
            SinSimbolos(e);
            SinEspacio(e);
            CajaId1.MaxLength = 15;
            if (e.KeyChar == (char)13)
            {
                ComboCargo1.Focus();
                e.Handled = true;
            }
        }

        private void ComboCargo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CajaNombres1.Focus();
                e.Handled = true;
            }
        }

        private void CajaNombres1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
            SinSimbolos(e);
            if (string.IsNullOrEmpty(CajaNombres1.Text))
            {
                SinEspacio(e);
            }
            CajaNombres1.MaxLength = 20;
            if (e.KeyChar == (char)13)
            {
                CajaApellidos1.Focus();
                e.Handled = true;
            }
        }

        private void CajaApellidos1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
            SinSimbolos(e);
            if (string.IsNullOrEmpty(CajaApellidos1.Text))
            {
                SinEspacio(e);
            }
            CajaApellidos1.MaxLength = 20;
            if (e.KeyChar == (char)13)
            {
                ComboEstado1.Focus();
                e.Handled = true;
            }
        }

        private void ComboEstado1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnActualizar.PerformClick();
                e.Handled = true;
            }
        }


        private void Actualizar()
        {
            try
            {
                BD con = new BD();
                MySqlCommand comando = new MySqlCommand(string.Format("ACTUALIZAR_USUARIO"), con.AbrirConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("IdUserAntiguo", CajaIdAntiguo.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("IdUser", CajaId1.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("IdCargo", ComboCargo1.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("Nombres", CajaNombres1.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("Apellidos", CajaApellidos1.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("Est", ComboEstado1.Text.ToUpper().Trim());
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado correctamente", "ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.CerrarConexion();
                TablaUsuarios.DataSource = Mostrar("select IdUsuario, IdNombreRol, NomUsuario, ApeUsuario, FechaIngreso, Estado from usuarios");
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error en la base de datos");
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string z = "Hace falta ingresar:   \n";

            if (string.IsNullOrEmpty(CajaIdAntiguo.Text))
            {
                z = z + "No.Identificación antiguo.   \n";
            }
            if (string.IsNullOrEmpty(CajaId1.Text))
            {
                z = z + "No.Identificación.   \n";
            }
            if (string.IsNullOrEmpty(ComboCargo1.Text))
            {
                z = z + "Cargo.   \n";
            }
            if (string.IsNullOrEmpty(CajaNombres1.Text))
            {
                z = z + "Nombres.  \n";
            }
            if (string.IsNullOrEmpty(CajaApellidos1.Text))
            {
                z = z + "Apellidos.  \n";
            }
            if (string.IsNullOrEmpty(ComboEstado1.Text))
            {
                z = z + "Estado.  \n";
            }

            if (string.IsNullOrEmpty(CajaIdAntiguo.Text) | string.IsNullOrEmpty(CajaId1.Text) | string.IsNullOrEmpty(ComboCargo1.Text) | string.IsNullOrEmpty(CajaNombres1.Text) | string.IsNullOrEmpty(CajaApellidos1.Text) |
                string.IsNullOrEmpty(ComboEstado1.Text))
            {
                MessageBox.Show(z, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int d = ValidarId("select * from usuarios where IdUsuario = '" + CajaIdAntiguo.Text.ToUpper().Trim() + "'");
                if (d == 1)
                {
                    if(CajaIdAntiguo.Text.ToUpper().Trim() != CajaId1.Text.ToUpper().Trim())
                    {
                        int c = ValidarId("select * from usuarios where IdUsuario = '" + CajaId1.Text.ToUpper().Trim() + "'");
                        if (c == 0)
                        {
                            Actualizar();
                            LimpiarActualizar();
                        }
                        else
                        {
                            MessageBox.Show("El nuevo número de identificación del usuario ya se encuentra en uso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        Actualizar();
                        LimpiarActualizar();
                    }
                }
                else
                {
                    MessageBox.Show("El número de identificación del usuario a actualizar no se encuentra en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
        }

        PanelUsuarios u;
        public static int Seg = 0;
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (Seg==0)
            {
                CambiarUsuarioContraseña u = new CambiarUsuarioContraseña();
                u.MdiParent = this.MdiParent;
                u.Show();
                Seg = 1;
            }
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

        private void TablaUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (TablaUsuarios.SelectedRows.Count == 0)
            {
                return;
            }
            CajaIdAntiguo.Text = TablaUsuarios[0, TablaUsuarios.SelectedRows[0].Index].Value.ToString();
            CajaId1.Text = TablaUsuarios[0, TablaUsuarios.SelectedRows[0].Index].Value.ToString();
            ComboCargo1.Text = TablaUsuarios[1, TablaUsuarios.SelectedRows[0].Index].Value.ToString();
            CajaNombres1.Text = TablaUsuarios[2, TablaUsuarios.SelectedRows[0].Index].Value.ToString();
            CajaApellidos1.Text = TablaUsuarios[3, TablaUsuarios.SelectedRows[0].Index].Value.ToString();
            ComboEstado1.Text = TablaUsuarios[4, TablaUsuarios.SelectedRows[0].Index].Value.ToString();
        }

        private void PanelUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Padre.SegUsuarios = 0;
        }
    }
    }

