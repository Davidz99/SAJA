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
    public partial class Padre : Form
    {

        PanelRoles r;
        public static int SegRoles = 0;

        public Padre()
        {
            InitializeComponent();
        }

        private void ItemRoles_Click(object sender, EventArgs e)
        {
            
            if(SegRoles == 0)
            {
                PanelRoles r = new PanelRoles();
                r.MdiParent = this;
                r.Show();
                SegRoles = 1;
            }     
        }

        PanelUsuarios u;
        public static int SegUsuarios = 0;

        private void ItemUsuarios_Click(object sender, EventArgs e)
        {
            if (SegUsuarios == 0)
            {
                PanelUsuarios u = new PanelUsuarios();
                u.MdiParent = this;
                u.Show();
                SegUsuarios = 1;
            }
        }

        private void Padre_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?", "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }

        }

        private void ItemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
