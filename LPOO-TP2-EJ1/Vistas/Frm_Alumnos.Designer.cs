namespace Vistas
{
    partial class Frm_Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Alumnos));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomAlu = new System.Windows.Forms.TextBox();
            this.txt_luAlu = new System.Windows.Forms.TextBox();
            this.txt_telAlu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_apellidoAlu = new System.Windows.Forms.CheckBox();
            this.txt_BuscarAlumno = new System.Windows.Forms.TextBox();
            this.chk_NombreAlu = new System.Windows.Forms.CheckBox();
            this.chk_LuAlu = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Alumno = new System.Windows.Forms.Label();
            this.txt_mailAlu = new System.Windows.Forms.TextBox();
            this.txt_direcAlu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_apeAlu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_Alumnos = new System.Windows.Forms.DataGridView();
            this.pic_Agregar = new System.Windows.Forms.PictureBox();
            this.pic_Editar = new System.Windows.Forms.PictureBox();
            this.pic_Eliminar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Eliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.White;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.pic_Eliminar);
            this.splitContainer1.Panel2.Controls.Add(this.pic_Editar);
            this.splitContainer1.Panel2.Controls.Add(this.pic_Agregar);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_Alumnos);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.pic_foto);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txt_apeAlu);
            this.splitContainer1.Panel2.Controls.Add(this.txt_direcAlu);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txt_mailAlu);
            this.splitContainer1.Panel2.Controls.Add(this.txt_nomAlu);
            this.splitContainer1.Panel2.Controls.Add(this.txt_luAlu);
            this.splitContainer1.Panel2.Controls.Add(this.txt_telAlu);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Alumno);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(695, 578);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALUMNOS";
            
            // 
            // txt_nomAlu
            // 
            this.txt_nomAlu.Location = new System.Drawing.Point(135, 47);
            this.txt_nomAlu.Name = "txt_nomAlu";
            this.txt_nomAlu.Size = new System.Drawing.Size(211, 20);
            this.txt_nomAlu.TabIndex = 15;
            // 
            // txt_luAlu
            // 
            this.txt_luAlu.Location = new System.Drawing.Point(25, 47);
            this.txt_luAlu.Name = "txt_luAlu";
            this.txt_luAlu.Size = new System.Drawing.Size(104, 20);
            this.txt_luAlu.TabIndex = 14;
            // 
            // txt_telAlu
            // 
            this.txt_telAlu.Location = new System.Drawing.Point(311, 110);
            this.txt_telAlu.Name = "txt_telAlu";
            this.txt_telAlu.Size = new System.Drawing.Size(183, 20);
            this.txt_telAlu.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(307, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nro Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(18, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Correo Electronico";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_apellidoAlu);
            this.groupBox2.Controls.Add(this.txt_BuscarAlumno);
            this.groupBox2.Controls.Add(this.chk_NombreAlu);
            this.groupBox2.Controls.Add(this.chk_LuAlu);
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(22, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Alumno";
            
            // 
            // chk_apellidoAlu
            // 
            this.chk_apellidoAlu.AutoSize = true;
            this.chk_apellidoAlu.Location = new System.Drawing.Point(153, 25);
            this.chk_apellidoAlu.Name = "chk_apellidoAlu";
            this.chk_apellidoAlu.Size = new System.Drawing.Size(63, 17);
            this.chk_apellidoAlu.TabIndex = 4;
            this.chk_apellidoAlu.Text = "Apellido";
            this.chk_apellidoAlu.UseVisualStyleBackColor = true;
            // 
            // txt_BuscarAlumno
            // 
            this.txt_BuscarAlumno.Location = new System.Drawing.Point(235, 23);
            this.txt_BuscarAlumno.Name = "txt_BuscarAlumno";
            this.txt_BuscarAlumno.Size = new System.Drawing.Size(237, 20);
            this.txt_BuscarAlumno.TabIndex = 2;
            this.txt_BuscarAlumno.TextChanged += new System.EventHandler(this.txt_BuscarMateria_TextChanged);
            // 
            // chk_NombreAlu
            // 
            this.chk_NombreAlu.AutoSize = true;
            this.chk_NombreAlu.Location = new System.Drawing.Point(84, 25);
            this.chk_NombreAlu.Name = "chk_NombreAlu";
            this.chk_NombreAlu.Size = new System.Drawing.Size(63, 17);
            this.chk_NombreAlu.TabIndex = 1;
            this.chk_NombreAlu.Text = "Nombre";
            this.chk_NombreAlu.UseVisualStyleBackColor = true;
            this.chk_NombreAlu.CheckedChanged += new System.EventHandler(this.chk_NombreMateria_CheckedChanged);
            // 
            // chk_LuAlu
            // 
            this.chk_LuAlu.AutoSize = true;
            this.chk_LuAlu.Location = new System.Drawing.Point(19, 25);
            this.chk_LuAlu.Name = "chk_LuAlu";
            this.chk_LuAlu.Size = new System.Drawing.Size(40, 17);
            this.chk_LuAlu.TabIndex = 0;
            this.chk_LuAlu.Text = "LU";
            this.chk_LuAlu.UseVisualStyleBackColor = true;
            this.chk_LuAlu.CheckedChanged += new System.EventHandler(this.chk_CodigoMateria_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(131, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // Alumno
            // 
            this.Alumno.AutoSize = true;
            this.Alumno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alumno.ForeColor = System.Drawing.Color.Gainsboro;
            this.Alumno.Location = new System.Drawing.Point(24, 20);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(109, 22);
            this.Alumno.TabIndex = 5;
            this.Alumno.Text = "LU Alumno";
            // 
            // txt_mailAlu
            // 
            this.txt_mailAlu.Location = new System.Drawing.Point(25, 110);
            this.txt_mailAlu.Name = "txt_mailAlu";
            this.txt_mailAlu.Size = new System.Drawing.Size(280, 20);
            this.txt_mailAlu.TabIndex = 16;
            
            // 
            // txt_direcAlu
            // 
            this.txt_direcAlu.Location = new System.Drawing.Point(25, 171);
            this.txt_direcAlu.Name = "txt_direcAlu";
            this.txt_direcAlu.Size = new System.Drawing.Size(469, 20);
            this.txt_direcAlu.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(18, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Direccion";
            // 
            // txt_apeAlu
            // 
            this.txt_apeAlu.Location = new System.Drawing.Point(352, 47);
            this.txt_apeAlu.Name = "txt_apeAlu";
            this.txt_apeAlu.Size = new System.Drawing.Size(142, 20);
            this.txt_apeAlu.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(348, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Apellido";
            // 
            // pic_foto
            // 
            this.pic_foto.Location = new System.Drawing.Point(530, 58);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(140, 140);
            this.pic_foto.TabIndex = 23;
            this.pic_foto.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(530, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "Foto";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Alumnos
            // 
            this.dgv_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alumnos.Location = new System.Drawing.Point(12, 281);
            this.dgv_Alumnos.Name = "dgv_Alumnos";
            this.dgv_Alumnos.Size = new System.Drawing.Size(671, 192);
            this.dgv_Alumnos.TabIndex = 25;
            // 
            // pic_Agregar
            // 
            this.pic_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("pic_Agregar.Image")));
            this.pic_Agregar.Location = new System.Drawing.Point(516, 215);
            this.pic_Agregar.Name = "pic_Agregar";
            this.pic_Agregar.Size = new System.Drawing.Size(50, 50);
            this.pic_Agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Agregar.TabIndex = 26;
            this.pic_Agregar.TabStop = false;
            // 
            // pic_Editar
            // 
            this.pic_Editar.Image = ((System.Drawing.Image)(resources.GetObject("pic_Editar.Image")));
            this.pic_Editar.Location = new System.Drawing.Point(574, 215);
            this.pic_Editar.Name = "pic_Editar";
            this.pic_Editar.Size = new System.Drawing.Size(50, 50);
            this.pic_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Editar.TabIndex = 27;
            this.pic_Editar.TabStop = false;
            // 
            // pic_Eliminar
            // 
            this.pic_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("pic_Eliminar.Image")));
            this.pic_Eliminar.Location = new System.Drawing.Point(632, 215);
            this.pic_Eliminar.Name = "pic_Eliminar";
            this.pic_Eliminar.Size = new System.Drawing.Size(50, 50);
            this.pic_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Eliminar.TabIndex = 28;
            this.pic_Eliminar.TabStop = false;
            // 
            // Frm_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 578);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_Alumnos";
            this.Text = "Formulario Alumnos";
            this.Load += new System.EventHandler(this.Frm_Matriculas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Eliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Alumno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_BuscarAlumno;
        private System.Windows.Forms.CheckBox chk_NombreAlu;
        private System.Windows.Forms.CheckBox chk_LuAlu;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox chk_apellidoAlu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nomAlu;
        private System.Windows.Forms.TextBox txt_luAlu;
        private System.Windows.Forms.TextBox txt_telAlu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic_Eliminar;
        private System.Windows.Forms.PictureBox pic_Editar;
        private System.Windows.Forms.PictureBox pic_Agregar;
        private System.Windows.Forms.DataGridView dgv_Alumnos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pic_foto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_apeAlu;
        private System.Windows.Forms.TextBox txt_direcAlu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mailAlu;
    }
}