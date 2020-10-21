namespace Vistas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_BuscarMateria = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pic_AgregarMateria = new System.Windows.Forms.PictureBox();
            this.txt_BuscarMateria = new System.Windows.Forms.TextBox();
            this.chk_NombreMateria = new System.Windows.Forms.CheckBox();
            this.chk_CodigoMateria = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BuscarMateria)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AgregarMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_BuscarMateria
            // 
            this.dgv_BuscarMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BuscarMateria.Location = new System.Drawing.Point(185, 164);
            this.dgv_BuscarMateria.Name = "dgv_BuscarMateria";
            this.dgv_BuscarMateria.Size = new System.Drawing.Size(277, 110);
            this.dgv_BuscarMateria.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pic_AgregarMateria);
            this.groupBox2.Controls.Add(this.txt_BuscarMateria);
            this.groupBox2.Controls.Add(this.chk_NombreMateria);
            this.groupBox2.Controls.Add(this.chk_CodigoMateria);
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(179, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 194);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Materia";
            // 
            // pic_AgregarMateria
            // 
            this.pic_AgregarMateria.Image = ((System.Drawing.Image)(resources.GetObject("pic_AgregarMateria.Image")));
            this.pic_AgregarMateria.Location = new System.Drawing.Point(239, 10);
            this.pic_AgregarMateria.Name = "pic_AgregarMateria";
            this.pic_AgregarMateria.Size = new System.Drawing.Size(31, 36);
            this.pic_AgregarMateria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_AgregarMateria.TabIndex = 13;
            this.pic_AgregarMateria.TabStop = false;
            // 
            // txt_BuscarMateria
            // 
            this.txt_BuscarMateria.Location = new System.Drawing.Point(6, 52);
            this.txt_BuscarMateria.Name = "txt_BuscarMateria";
            this.txt_BuscarMateria.Size = new System.Drawing.Size(277, 20);
            this.txt_BuscarMateria.TabIndex = 2;
            // 
            // chk_NombreMateria
            // 
            this.chk_NombreMateria.AutoSize = true;
            this.chk_NombreMateria.Location = new System.Drawing.Point(80, 28);
            this.chk_NombreMateria.Name = "chk_NombreMateria";
            this.chk_NombreMateria.Size = new System.Drawing.Size(101, 17);
            this.chk_NombreMateria.TabIndex = 1;
            this.chk_NombreMateria.Text = "Nombre Materia";
            this.chk_NombreMateria.UseVisualStyleBackColor = true;
            // 
            // chk_CodigoMateria
            // 
            this.chk_CodigoMateria.AutoSize = true;
            this.chk_CodigoMateria.Location = new System.Drawing.Point(6, 29);
            this.chk_CodigoMateria.Name = "chk_CodigoMateria";
            this.chk_CodigoMateria.Size = new System.Drawing.Size(59, 17);
            this.chk_CodigoMateria.TabIndex = 0;
            this.chk_CodigoMateria.Text = "Codigo";
            this.chk_CodigoMateria.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 366);
            this.Controls.Add(this.dgv_BuscarMateria);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BuscarMateria)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AgregarMateria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BuscarMateria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pic_AgregarMateria;
        private System.Windows.Forms.TextBox txt_BuscarMateria;
        private System.Windows.Forms.CheckBox chk_NombreMateria;
        private System.Windows.Forms.CheckBox chk_CodigoMateria;
    }
}

