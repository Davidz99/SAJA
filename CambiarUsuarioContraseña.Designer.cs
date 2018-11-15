namespace SAJA
{
    partial class CambiarUsuarioContraseña
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
            this.label1 = new System.Windows.Forms.Label();
            this.CajaUsuario = new System.Windows.Forms.TextBox();
            this.CajaContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.CajaNuevaContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CajaNuevoUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // CajaUsuario
            // 
            this.CajaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaUsuario.Location = new System.Drawing.Point(327, 72);
            this.CajaUsuario.Name = "CajaUsuario";
            this.CajaUsuario.Size = new System.Drawing.Size(123, 26);
            this.CajaUsuario.TabIndex = 1;
            this.CajaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaUsuario_KeyPress);
            // 
            // CajaContraseña
            // 
            this.CajaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaContraseña.Location = new System.Drawing.Point(327, 124);
            this.CajaContraseña.Name = "CajaContraseña";
            this.CajaContraseña.PasswordChar = '*';
            this.CajaContraseña.Size = new System.Drawing.Size(123, 26);
            this.CajaContraseña.TabIndex = 3;
            this.CajaContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaContraseña_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // btnComprobar
            // 
            this.btnComprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobar.Location = new System.Drawing.Point(327, 184);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(123, 34);
            this.btnComprobar.TabIndex = 4;
            this.btnComprobar.Text = "COMPROBAR";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // CajaNuevaContraseña
            // 
            this.CajaNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaNuevaContraseña.Location = new System.Drawing.Point(262, 302);
            this.CajaNuevaContraseña.Name = "CajaNuevaContraseña";
            this.CajaNuevaContraseña.PasswordChar = '*';
            this.CajaNuevaContraseña.Size = new System.Drawing.Size(188, 26);
            this.CajaNuevaContraseña.TabIndex = 8;
            this.CajaNuevaContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaNuevaContraseña_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nueva contraseña";
            // 
            // CajaNuevoUsuario
            // 
            this.CajaNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaNuevoUsuario.Location = new System.Drawing.Point(262, 249);
            this.CajaNuevoUsuario.Name = "CajaNuevoUsuario";
            this.CajaNuevoUsuario.Size = new System.Drawing.Size(188, 26);
            this.CajaNuevoUsuario.TabIndex = 6;
            this.CajaNuevoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaNuevoUsuario_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nuevo nombre de usuario";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Image = global::SAJA.Properties.Resources.Icono_cambiar_usuario;
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 146);
            this.label5.TabIndex = 9;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(327, 361);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(123, 34);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // CambiarUsuarioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(462, 407);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CajaNuevaContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CajaNuevoUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.CajaContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CajaUsuario);
            this.Controls.Add(this.label1);
            this.Name = "CambiarUsuarioContraseña";
            this.Text = "CAMBIAR USUARIO / CONTRASEÑA";
            this.Load += new System.EventHandler(this.CambiarUsuarioContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CajaUsuario;
        private System.Windows.Forms.TextBox CajaContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.TextBox CajaNuevaContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CajaNuevoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualizar;
    }
}