namespace SAJA
{
    partial class PanelGrados
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.ComboGrado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.ComboEstado = new System.Windows.Forms.ComboBox();
            this.ComboGradoBase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TablaGrado = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaGrado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(398, 363);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnInsertar);
            this.tabPage1.Controls.Add(this.ComboGrado);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(390, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(160, 212);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(148, 47);
            this.BtnInsertar.TabIndex = 2;
            this.BtnInsertar.Text = "INSERTAR";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // ComboGrado
            // 
            this.ComboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboGrado.FormattingEnabled = true;
            this.ComboGrado.Items.AddRange(new object[] {
            "PREESCOLAR",
            "PRIMERO",
            "SEGUNDO",
            "TERCERO",
            "CUARTO",
            "QUINTO",
            "SEXTO",
            "SEPTIMO",
            "OCTAVO",
            "NOVENO",
            "DECIMO",
            "UNDECIMO"});
            this.ComboGrado.Location = new System.Drawing.Point(160, 92);
            this.ComboGrado.Name = "ComboGrado";
            this.ComboGrado.Size = new System.Drawing.Size(148, 21);
            this.ComboGrado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grado";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnActualizar);
            this.tabPage2.Controls.Add(this.ComboEstado);
            this.tabPage2.Controls.Add(this.ComboGradoBase);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(390, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(169, 263);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(148, 34);
            this.BtnActualizar.TabIndex = 4;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click_1);
            // 
            // ComboEstado
            // 
            this.ComboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEstado.FormattingEnabled = true;
            this.ComboEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.ComboEstado.Location = new System.Drawing.Point(169, 181);
            this.ComboEstado.Name = "ComboEstado";
            this.ComboEstado.Size = new System.Drawing.Size(148, 21);
            this.ComboEstado.TabIndex = 3;
            // 
            // ComboGradoBase
            // 
            this.ComboGradoBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboGradoBase.FormattingEnabled = true;
            this.ComboGradoBase.Location = new System.Drawing.Point(169, 79);
            this.ComboGradoBase.Name = "ComboGradoBase";
            this.ComboGradoBase.Size = new System.Drawing.Size(148, 21);
            this.ComboGradoBase.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grado";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TablaGrado);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(390, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mostrar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TablaGrado
            // 
            this.TablaGrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaGrado.Location = new System.Drawing.Point(3, 0);
            this.TablaGrado.Name = "TablaGrado";
            this.TablaGrado.ReadOnly = true;
            this.TablaGrado.RowHeadersVisible = false;
            this.TablaGrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaGrado.Size = new System.Drawing.Size(387, 337);
            this.TablaGrado.TabIndex = 0;
            this.TablaGrado.SelectionChanged += new System.EventHandler(this.TablaGrado_SelectionChanged);
            // 
            // PanelGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "PanelGrados";
            this.Text = "GRADO";
            this.Load += new System.EventHandler(this.PanelGrados_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaGrado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.ComboBox ComboGrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.ComboBox ComboEstado;
        private System.Windows.Forms.ComboBox ComboGradoBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TablaGrado;
    }
}