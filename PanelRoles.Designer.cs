namespace SAJA
{
    partial class PanelRoles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelRoles));
            this.RolesInterno = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.CajaCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CajaCargoNuevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.CajaCargoAntiguo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tablaRoles = new System.Windows.Forms.DataGridView();
            this.RolesInterno.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // RolesInterno
            // 
            this.RolesInterno.Controls.Add(this.tabPage1);
            this.RolesInterno.Controls.Add(this.tabPage2);
            this.RolesInterno.Controls.Add(this.tabPage3);
            this.RolesInterno.Location = new System.Drawing.Point(1, 2);
            this.RolesInterno.Name = "RolesInterno";
            this.RolesInterno.SelectedIndex = 0;
            this.RolesInterno.Size = new System.Drawing.Size(510, 360);
            this.RolesInterno.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnInsertar);
            this.tabPage1.Controls.Add(this.CajaCargo);
            this.tabPage1.Controls.Add(this.lblCargo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(351, 278);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(137, 41);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CajaCargo
            // 
            this.CajaCargo.AccessibleDescription = "";
            this.CajaCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaCargo.Location = new System.Drawing.Point(254, 125);
            this.CajaCargo.Multiline = true;
            this.CajaCargo.Name = "CajaCargo";
            this.CajaCargo.Size = new System.Drawing.Size(160, 28);
            this.CajaCargo.TabIndex = 1;
            this.CajaCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaCargo_KeyPress);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(81, 128);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(56, 20);
            this.lblCargo.TabIndex = 0;
            this.lblCargo.Text = "Cargo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLimpiar);
            this.tabPage2.Controls.Add(this.comboEstado);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.CajaCargoNuevo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnActualizar);
            this.tabPage2.Controls.Add(this.CajaCargoAntiguo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(19, 287);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(162, 41);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "LIMPIAR CAJAS";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.comboEstado.Location = new System.Drawing.Point(258, 198);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(160, 28);
            this.comboEstado.TabIndex = 9;
            this.comboEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstado_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado:";
            // 
            // CajaCargoNuevo
            // 
            this.CajaCargoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaCargoNuevo.Location = new System.Drawing.Point(258, 126);
            this.CajaCargoNuevo.Multiline = true;
            this.CajaCargoNuevo.Name = "CajaCargoNuevo";
            this.CajaCargoNuevo.Size = new System.Drawing.Size(160, 28);
            this.CajaCargoNuevo.TabIndex = 7;
            this.CajaCargoNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaCargoNuevo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cargo:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(359, 287);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(137, 41);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // CajaCargoAntiguo
            // 
            this.CajaCargoAntiguo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaCargoAntiguo.Location = new System.Drawing.Point(258, 56);
            this.CajaCargoAntiguo.Multiline = true;
            this.CajaCargoAntiguo.Name = "CajaCargoAntiguo";
            this.CajaCargoAntiguo.Size = new System.Drawing.Size(160, 28);
            this.CajaCargoAntiguo.TabIndex = 4;
            this.CajaCargoAntiguo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaCargoAntiguo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cargo a actualizar:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tablaRoles);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(502, 334);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mostrar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tablaRoles
            // 
            this.tablaRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRoles.EnableHeadersVisualStyles = false;
            this.tablaRoles.Location = new System.Drawing.Point(7, 6);
            this.tablaRoles.Name = "tablaRoles";
            this.tablaRoles.ReadOnly = true;
            this.tablaRoles.RowHeadersVisible = false;
            this.tablaRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tablaRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaRoles.Size = new System.Drawing.Size(489, 322);
            this.tablaRoles.TabIndex = 0;
            this.tablaRoles.SelectionChanged += new System.EventHandler(this.tablaRoles_SelectionChanged);
            // 
            // PanelRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 355);
            this.Controls.Add(this.RolesInterno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelRoles";
            this.Text = "CARGOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelRoles_FormClosing);
            this.Load += new System.EventHandler(this.Roles_Load);
            this.RolesInterno.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl RolesInterno;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView tablaRoles;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox CajaCargo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox CajaCargoAntiguo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CajaCargoNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Button btnLimpiar;
    }
}