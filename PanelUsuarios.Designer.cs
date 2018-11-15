namespace SAJA
{
    partial class PanelUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelUsuarios));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ItemInsertar = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.ComboCargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CajaContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CajaUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CajaApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CajaNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CajaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemActualizar = new System.Windows.Forms.TabPage();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimpiar1 = new System.Windows.Forms.Button();
            this.ComboEstado1 = new System.Windows.Forms.ComboBox();
            this.CajaIdAntiguo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.ComboCargo1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CajaApellidos1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CajaNombres1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CajaId1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ItemMostrar = new System.Windows.Forms.TabPage();
            this.comboOrdenar = new System.Windows.Forms.ComboBox();
            this.TablaUsuarios = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.ItemInsertar.SuspendLayout();
            this.ItemActualizar.SuspendLayout();
            this.ItemMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ItemInsertar);
            this.tabControl1.Controls.Add(this.ItemActualizar);
            this.tabControl1.Controls.Add(this.ItemMostrar);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 542);
            this.tabControl1.TabIndex = 0;
            // 
            // ItemInsertar
            // 
            this.ItemInsertar.Controls.Add(this.btnLimpiar);
            this.ItemInsertar.Controls.Add(this.btnInsertar);
            this.ItemInsertar.Controls.Add(this.ComboCargo);
            this.ItemInsertar.Controls.Add(this.label6);
            this.ItemInsertar.Controls.Add(this.CajaContraseña);
            this.ItemInsertar.Controls.Add(this.label5);
            this.ItemInsertar.Controls.Add(this.CajaUsuario);
            this.ItemInsertar.Controls.Add(this.label4);
            this.ItemInsertar.Controls.Add(this.CajaApellidos);
            this.ItemInsertar.Controls.Add(this.label3);
            this.ItemInsertar.Controls.Add(this.CajaNombres);
            this.ItemInsertar.Controls.Add(this.label2);
            this.ItemInsertar.Controls.Add(this.CajaId);
            this.ItemInsertar.Controls.Add(this.label1);
            this.ItemInsertar.Location = new System.Drawing.Point(4, 22);
            this.ItemInsertar.Name = "ItemInsertar";
            this.ItemInsertar.Padding = new System.Windows.Forms.Padding(3);
            this.ItemInsertar.Size = new System.Drawing.Size(483, 516);
            this.ItemInsertar.TabIndex = 0;
            this.ItemInsertar.Text = "Insertar";
            this.ItemInsertar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(18, 470);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(149, 37);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "LIMPIAR CAJAS";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(351, 470);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(123, 37);
            this.btnInsertar.TabIndex = 12;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // ComboCargo
            // 
            this.ComboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCargo.FormattingEnabled = true;
            this.ComboCargo.Location = new System.Drawing.Point(249, 103);
            this.ComboCargo.Name = "ComboCargo";
            this.ComboCargo.Size = new System.Drawing.Size(177, 28);
            this.ComboCargo.TabIndex = 11;
            this.ComboCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboCargo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cargo";
            // 
            // CajaContraseña
            // 
            this.CajaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaContraseña.Location = new System.Drawing.Point(249, 339);
            this.CajaContraseña.Name = "CajaContraseña";
            this.CajaContraseña.Size = new System.Drawing.Size(177, 26);
            this.CajaContraseña.TabIndex = 9;
            this.CajaContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaContraseña_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña";
            // 
            // CajaUsuario
            // 
            this.CajaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaUsuario.Location = new System.Drawing.Point(249, 282);
            this.CajaUsuario.Name = "CajaUsuario";
            this.CajaUsuario.Size = new System.Drawing.Size(177, 26);
            this.CajaUsuario.TabIndex = 7;
            this.CajaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaUsuario_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre de usuario";
            // 
            // CajaApellidos
            // 
            this.CajaApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaApellidos.Location = new System.Drawing.Point(249, 220);
            this.CajaApellidos.Name = "CajaApellidos";
            this.CajaApellidos.Size = new System.Drawing.Size(177, 26);
            this.CajaApellidos.TabIndex = 5;
            this.CajaApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaApellidos_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // CajaNombres
            // 
            this.CajaNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaNombres.Location = new System.Drawing.Point(249, 161);
            this.CajaNombres.Name = "CajaNombres";
            this.CajaNombres.Size = new System.Drawing.Size(177, 26);
            this.CajaNombres.TabIndex = 3;
            this.CajaNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaNombres_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // CajaId
            // 
            this.CajaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaId.Location = new System.Drawing.Point(249, 47);
            this.CajaId.Name = "CajaId";
            this.CajaId.Size = new System.Drawing.Size(177, 26);
            this.CajaId.TabIndex = 1;
            this.CajaId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No.Identificación";
            // 
            // ItemActualizar
            // 
            this.ItemActualizar.Controls.Add(this.btnCambiar);
            this.ItemActualizar.Controls.Add(this.label8);
            this.ItemActualizar.Controls.Add(this.btnLimpiar1);
            this.ItemActualizar.Controls.Add(this.ComboEstado1);
            this.ItemActualizar.Controls.Add(this.CajaIdAntiguo);
            this.ItemActualizar.Controls.Add(this.label14);
            this.ItemActualizar.Controls.Add(this.label13);
            this.ItemActualizar.Controls.Add(this.btnActualizar);
            this.ItemActualizar.Controls.Add(this.ComboCargo1);
            this.ItemActualizar.Controls.Add(this.label7);
            this.ItemActualizar.Controls.Add(this.label9);
            this.ItemActualizar.Controls.Add(this.CajaApellidos1);
            this.ItemActualizar.Controls.Add(this.label10);
            this.ItemActualizar.Controls.Add(this.CajaNombres1);
            this.ItemActualizar.Controls.Add(this.label11);
            this.ItemActualizar.Controls.Add(this.CajaId1);
            this.ItemActualizar.Controls.Add(this.label12);
            this.ItemActualizar.Location = new System.Drawing.Point(4, 22);
            this.ItemActualizar.Name = "ItemActualizar";
            this.ItemActualizar.Padding = new System.Windows.Forms.Padding(3);
            this.ItemActualizar.Size = new System.Drawing.Size(483, 516);
            this.ItemActualizar.TabIndex = 1;
            this.ItemActualizar.Text = "Actualizar";
            this.ItemActualizar.UseVisualStyleBackColor = true;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.Location = new System.Drawing.Point(26, 470);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(296, 37);
            this.btnCambiar.TabIndex = 32;
            this.btnCambiar.Text = "CAMBIAR USUARIO / CONTRASEÑA";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(454, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------";
            // 
            // btnLimpiar1
            // 
            this.btnLimpiar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar1.Location = new System.Drawing.Point(23, 412);
            this.btnLimpiar1.Name = "btnLimpiar1";
            this.btnLimpiar1.Size = new System.Drawing.Size(162, 37);
            this.btnLimpiar1.TabIndex = 30;
            this.btnLimpiar1.Text = "LIMPIAR CAJAS";
            this.btnLimpiar1.UseVisualStyleBackColor = true;
            this.btnLimpiar1.Click += new System.EventHandler(this.btnLimpiar1_Click);
            // 
            // ComboEstado1
            // 
            this.ComboEstado1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEstado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboEstado1.FormattingEnabled = true;
            this.ComboEstado1.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.ComboEstado1.Location = new System.Drawing.Point(253, 350);
            this.ComboEstado1.Name = "ComboEstado1";
            this.ComboEstado1.Size = new System.Drawing.Size(177, 28);
            this.ComboEstado1.TabIndex = 29;
            this.ComboEstado1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboEstado1_KeyPress);
            // 
            // CajaIdAntiguo
            // 
            this.CajaIdAntiguo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaIdAntiguo.Location = new System.Drawing.Point(253, 62);
            this.CajaIdAntiguo.Name = "CajaIdAntiguo";
            this.CajaIdAntiguo.Size = new System.Drawing.Size(177, 26);
            this.CajaIdAntiguo.TabIndex = 28;
            this.CajaIdAntiguo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaIdAntiguo_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(44, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "No.Identificación Antiguo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(44, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Datos:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(351, 412);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(123, 37);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ComboCargo1
            // 
            this.ComboCargo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCargo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCargo1.FormattingEnabled = true;
            this.ComboCargo1.Location = new System.Drawing.Point(253, 173);
            this.ComboCargo1.Name = "ComboCargo1";
            this.ComboCargo1.Size = new System.Drawing.Size(177, 28);
            this.ComboCargo1.TabIndex = 24;
            this.ComboCargo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboCargo1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cargo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Estado";
            // 
            // CajaApellidos1
            // 
            this.CajaApellidos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaApellidos1.Location = new System.Drawing.Point(253, 290);
            this.CajaApellidos1.Name = "CajaApellidos1";
            this.CajaApellidos1.Size = new System.Drawing.Size(177, 26);
            this.CajaApellidos1.TabIndex = 18;
            this.CajaApellidos1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaApellidos1_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Apellidos";
            // 
            // CajaNombres1
            // 
            this.CajaNombres1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaNombres1.Location = new System.Drawing.Point(253, 231);
            this.CajaNombres1.Name = "CajaNombres1";
            this.CajaNombres1.Size = new System.Drawing.Size(177, 26);
            this.CajaNombres1.TabIndex = 16;
            this.CajaNombres1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaNombres1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Nombres";
            // 
            // CajaId1
            // 
            this.CajaId1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaId1.Location = new System.Drawing.Point(253, 117);
            this.CajaId1.Name = "CajaId1";
            this.CajaId1.Size = new System.Drawing.Size(177, 26);
            this.CajaId1.TabIndex = 14;
            this.CajaId1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaId1_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "No.Identificación";
            // 
            // ItemMostrar
            // 
            this.ItemMostrar.Controls.Add(this.comboOrdenar);
            this.ItemMostrar.Controls.Add(this.TablaUsuarios);
            this.ItemMostrar.Location = new System.Drawing.Point(4, 22);
            this.ItemMostrar.Name = "ItemMostrar";
            this.ItemMostrar.Padding = new System.Windows.Forms.Padding(3);
            this.ItemMostrar.Size = new System.Drawing.Size(483, 516);
            this.ItemMostrar.TabIndex = 2;
            this.ItemMostrar.Text = "Mostrar";
            this.ItemMostrar.UseVisualStyleBackColor = true;
            // 
            // comboOrdenar
            // 
            this.comboOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOrdenar.FormattingEnabled = true;
            this.comboOrdenar.Items.AddRange(new object[] {
            "NO. IDENTIFICACIÓN",
            "NOMBRES",
            "APELLIDOS"});
            this.comboOrdenar.Location = new System.Drawing.Point(18, 451);
            this.comboOrdenar.Name = "comboOrdenar";
            this.comboOrdenar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboOrdenar.Size = new System.Drawing.Size(182, 28);
            this.comboOrdenar.TabIndex = 1;
            this.comboOrdenar.Text = "ORDENAR POR...";
            this.comboOrdenar.SelectedIndexChanged += new System.EventHandler(this.comboOrdenar_SelectedIndexChanged);
            // 
            // TablaUsuarios
            // 
            this.TablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaUsuarios.Location = new System.Drawing.Point(6, 6);
            this.TablaUsuarios.Name = "TablaUsuarios";
            this.TablaUsuarios.ReadOnly = true;
            this.TablaUsuarios.RowHeadersVisible = false;
            this.TablaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaUsuarios.Size = new System.Drawing.Size(460, 393);
            this.TablaUsuarios.TabIndex = 0;
            this.TablaUsuarios.SelectionChanged += new System.EventHandler(this.TablaUsuarios_SelectionChanged);
            // 
            // PanelUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 544);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelUsuarios";
            this.Text = "USUARIOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.ItemInsertar.ResumeLayout(false);
            this.ItemInsertar.PerformLayout();
            this.ItemActualizar.ResumeLayout(false);
            this.ItemActualizar.PerformLayout();
            this.ItemMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ItemInsertar;
        private System.Windows.Forms.TabPage ItemActualizar;
        private System.Windows.Forms.TabPage ItemMostrar;
        private System.Windows.Forms.ComboBox comboOrdenar;
        private System.Windows.Forms.DataGridView TablaUsuarios;
        private System.Windows.Forms.ComboBox ComboCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CajaContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CajaUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CajaApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CajaNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CajaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLimpiar1;
        private System.Windows.Forms.ComboBox ComboEstado1;
        private System.Windows.Forms.TextBox CajaIdAntiguo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox ComboCargo1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CajaApellidos1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CajaNombres1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CajaId1;
        private System.Windows.Forms.Label label12;
    }
}