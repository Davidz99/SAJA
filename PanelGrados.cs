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
    public partial class PanelGrados : Form
    {
        public PanelGrados()
        {
            InitializeComponent();
        }
        public BD Conectar = new BD();
        private MySqlCommand comandosql = new MySqlCommand();
        private MySqlDataReader LeerFilas;

        public DataTable MostrarGrados()
        {
            try
            {
                DataTable Tabla = new DataTable();
                comandosql.Connection = Conectar.AbrirConexion();
                comandosql.CommandText = "select * from grados";
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

        private void PanelGrados_Load(object sender, EventArgs e)
        {
            TablaGrado.DataSource = MostrarGrados();
            TablaGrado.Columns[0].HeaderText = "Grado";
            TablaGrado.Columns[1].HeaderText = "Estado";

            ComboGradoBase.DataSource = MostrarGrados();
            ComboGradoBase.DisplayMember = ("IdNombreGrado0");
            ComboGradoBase.ValueMember = "IdNombreGrado";

        }

        public DataTable MostrarGrados1()
        {
            try
            {
                DataTable Tabla = new DataTable();
                comandosql.Connection = Conectar.AbrirConexion();
                comandosql.CommandText = "select IdNombreGrado from grados";
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


        private void Agregar()
        {
            try
            {

                BD con = new BD();
                MySqlCommand comando = new MySqlCommand(string.Format("AÑADIR_GRADO"), con.AbrirConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("NomGr", ComboGrado.Text.ToUpper().Trim());
                comando.ExecuteNonQuery();
                MessageBox.Show("Grado ingresado a la base de datos correctamente", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.CerrarConexion();
                TablaGrado.DataSource = MostrarGrados();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error en la base de datos");
            }
        }
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            string z = "Hace falta ingresar:   \n";

            if (string.IsNullOrEmpty(ComboGrado.Text))
            {
                z = z + "Grado.\n";
                MessageBox.Show(z);
            }
            else
            {
                int d = ValidarId("select * from grados where IdNombreGrado = '" + ComboGrado.Text.Trim() + "'");
                if (d == 0)
                {
                    Agregar();
                    LimpiarInsertar();
                    
                }
                else
                {
                    MessageBox.Show("El grado ingresado ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void Actualizar()
        {
            try
            {
                BD con = new BD();
                MySqlCommand comando = new MySqlCommand(string.Format("ACTUALIZAR_GRADO"), con.AbrirConexion());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("IdGrad", ComboGradoBase.Text.ToUpper());
                comando.Parameters.AddWithValue("Est", ComboEstado.Text.ToUpper());
                comando.ExecuteNonQuery();
                MessageBox.Show("Grado actualizado correctamente", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.CerrarConexion();
                TablaGrado.DataSource = MostrarGrados();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error en la base de datos");
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

        public void LimpiarInsertar()
        {
            
            ComboGrado.Text = "";
           
        }

        private void TablaGrado_SelectionChanged(object sender, EventArgs e)
        {
            if (TablaGrado.SelectedRows.Count == 0)
            {
                return;
            }
            ComboGradoBase.Text = TablaGrado[0, TablaGrado.SelectedRows[0].Index].Value.ToString();
            ComboEstado.Text = TablaGrado[1, TablaGrado.SelectedRows[0].Index].Value.ToString();
        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            if (ComboGradoBase.SelectedItem == null | ComboEstado.SelectedItem == null)
            {
                MessageBox.Show("Hace falta ingresar un valor");
            }
            else
            {
                BD con = new BD();
                MySqlCommand comando = new MySqlCommand(string.Format("ACTUALIZAR_GRADO"), con.AbrirConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("IdGrad", ComboGradoBase.SelectedItem);
                comando.Parameters.AddWithValue("Est", ComboEstado.SelectedItem);
                comando.ExecuteNonQuery();
                Actualizar();
            }
        }
    }
}



