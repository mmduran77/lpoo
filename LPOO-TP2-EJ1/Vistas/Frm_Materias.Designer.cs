namespace Vistas
{
    partial class Frm_Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Materias));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_Agregar = new System.Windows.Forms.PictureBox();
            this.pic_Editar = new System.Windows.Forms.PictureBox();
            this.pic_Eliminar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BuscarCarrera = new System.Windows.Forms.TextBox();
            this.dgv_Carreras = new System.Windows.Forms.DataGridView();
            this.tex_nombreMat = new System.Windows.Forms.TextBox();
            this.txt_codMat = new System.Windows.Forms.TextBox();
            this.txt_docenteACargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_carrera = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_Nombre = new System.Windows.Forms.CheckBox();
            this.pic_AgregarAlumno = new System.Windows.Forms.PictureBox();
            this.txt_BuscarAlumno = new System.Windows.Forms.TextBox();
            this.chk_Apellido = new System.Windows.Forms.CheckBox();
            this.dgv_Docentes = new System.Windows.Forms.DataGridView();
            this.chk_Legajo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_Carrera = new System.Windows.Forms.CheckBox();
            this.chk_Docente = new System.Windows.Forms.CheckBox();
            this.txt_BuscarMateria = new System.Windows.Forms.TextBox();
            this.chk_NombreMateria = new System.Windows.Forms.CheckBox();
            this.chk_CodigoMateria = new System.Windows.Forms.CheckBox();
            this.dgv_Materias = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Alumno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Eliminar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carreras)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AgregarAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Docentes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materias)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.pic_Agregar);
            this.splitContainer1.Panel2.Controls.Add(this.pic_Editar);
            this.splitContainer1.Panel2.Controls.Add(this.pic_Eliminar);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.tex_nombreMat);
            this.splitContainer1.Panel2.Controls.Add(this.txt_codMat);
            this.splitContainer1.Panel2.Controls.Add(this.txt_docenteACargo);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_carrera);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Alumno);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(811, 513);
            this.splitContainer1.SplitterDistance = 79;
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
            this.label1.Size = new System.Drawing.Size(185, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATERIAS";
            // 
            // pic_Agregar
            // 
            this.pic_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("pic_Agregar.Image")));
            this.pic_Agregar.Location = new System.Drawing.Point(433, 21);
            this.pic_Agregar.Name = "pic_Agregar";
            this.pic_Agregar.Size = new System.Drawing.Size(53, 50);
            this.pic_Agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Agregar.TabIndex = 19;
            this.pic_Agregar.TabStop = false;
            // 
            // pic_Editar
            // 
            this.pic_Editar.Image = ((System.Drawing.Image)(resources.GetObject("pic_Editar.Image")));
            this.pic_Editar.Location = new System.Drawing.Point(433, 77);
            this.pic_Editar.Name = "pic_Editar";
            this.pic_Editar.Size = new System.Drawing.Size(53, 50);
            this.pic_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Editar.TabIndex = 18;
            this.pic_Editar.TabStop = false;
            // 
            // pic_Eliminar
            // 
            this.pic_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("pic_Eliminar.Image")));
            this.pic_Eliminar.Location = new System.Drawing.Point(433, 133);
            this.pic_Eliminar.Name = "pic_Eliminar";
            this.pic_Eliminar.Size = new System.Drawing.Size(53, 50);
            this.pic_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Eliminar.TabIndex = 17;
            this.pic_Eliminar.TabStop = false;
            this.pic_Eliminar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_BuscarCarrera);
            this.groupBox1.Controls.Add(this.dgv_Carreras);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(504, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 163);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre";
            // 
            // txt_BuscarCarrera
            // 
            this.txt_BuscarCarrera.Location = new System.Drawing.Point(86, 17);
            this.txt_BuscarCarrera.Name = "txt_BuscarCarrera";
            this.txt_BuscarCarrera.Size = new System.Drawing.Size(197, 20);
            this.txt_BuscarCarrera.TabIndex = 6;
            // 
            // dgv_Carreras
            // 
            this.dgv_Carreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Carreras.Location = new System.Drawing.Point(6, 44);
            this.dgv_Carreras.Name = "dgv_Carreras";
            this.dgv_Carreras.Size = new System.Drawing.Size(277, 113);
            this.dgv_Carreras.TabIndex = 15;
            this.dgv_Carreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Carreras_CellContentClick);
            // 
            // tex_nombreMat
            // 
            this.tex_nombreMat.Location = new System.Drawing.Point(159, 62);
            this.tex_nombreMat.Name = "tex_nombreMat";
            this.tex_nombreMat.Size = new System.Drawing.Size(254, 20);
            this.tex_nombreMat.TabIndex = 15;
            // 
            // txt_codMat
            // 
            this.txt_codMat.Location = new System.Drawing.Point(13, 62);
            this.txt_codMat.Name = "txt_codMat";
            this.txt_codMat.Size = new System.Drawing.Size(138, 20);
            this.txt_codMat.TabIndex = 14;
            this.txt_codMat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_docenteACargo
            // 
            this.txt_docenteACargo.Location = new System.Drawing.Point(190, 131);
            this.txt_docenteACargo.Name = "txt_docenteACargo";
            this.txt_docenteACargo.Size = new System.Drawing.Size(223, 20);
            this.txt_docenteACargo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(186, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Docente a Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Carrera";
            // 
            // cmb_carrera
            // 
            this.cmb_carrera.FormattingEnabled = true;
            this.cmb_carrera.Location = new System.Drawing.Point(13, 130);
            this.cmb_carrera.Name = "cmb_carrera";
            this.cmb_carrera.Size = new System.Drawing.Size(171, 21);
            this.cmb_carrera.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_Nombre);
            this.groupBox3.Controls.Add(this.pic_AgregarAlumno);
            this.groupBox3.Controls.Add(this.txt_BuscarAlumno);
            this.groupBox3.Controls.Add(this.chk_Apellido);
            this.groupBox3.Controls.Add(this.dgv_Docentes);
            this.groupBox3.Controls.Add(this.chk_Legajo);
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(504, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 238);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Docente";
            // 
            // chk_Nombre
            // 
            this.chk_Nombre.AutoSize = true;
            this.chk_Nombre.Location = new System.Drawing.Point(139, 29);
            this.chk_Nombre.Name = "chk_Nombre";
            this.chk_Nombre.Size = new System.Drawing.Size(63, 17);
            this.chk_Nombre.TabIndex = 15;
            this.chk_Nombre.Text = "Nombre";
            this.chk_Nombre.UseVisualStyleBackColor = true;
            // 
            // pic_AgregarAlumno
            // 
            this.pic_AgregarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("pic_AgregarAlumno.Image")));
            this.pic_AgregarAlumno.Location = new System.Drawing.Point(230, 9);
            this.pic_AgregarAlumno.Name = "pic_AgregarAlumno";
            this.pic_AgregarAlumno.Size = new System.Drawing.Size(40, 43);
            this.pic_AgregarAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_AgregarAlumno.TabIndex = 14;
            this.pic_AgregarAlumno.TabStop = false;
            // 
            // txt_BuscarAlumno
            // 
            this.txt_BuscarAlumno.Location = new System.Drawing.Point(6, 52);
            this.txt_BuscarAlumno.Name = "txt_BuscarAlumno";
            this.txt_BuscarAlumno.Size = new System.Drawing.Size(277, 20);
            this.txt_BuscarAlumno.TabIndex = 2;
            this.txt_BuscarAlumno.TextChanged += new System.EventHandler(this.txt_BuscarAlumno_TextChanged);
            // 
            // chk_Apellido
            // 
            this.chk_Apellido.AutoSize = true;
            this.chk_Apellido.Location = new System.Drawing.Point(70, 29);
            this.chk_Apellido.Name = "chk_Apellido";
            this.chk_Apellido.Size = new System.Drawing.Size(63, 17);
            this.chk_Apellido.TabIndex = 1;
            this.chk_Apellido.Text = "Apellido";
            this.chk_Apellido.UseVisualStyleBackColor = true;
            this.chk_Apellido.CheckedChanged += new System.EventHandler(this.chk_AlumnoAlumno_CheckedChanged);
            // 
            // dgv_Docentes
            // 
            this.dgv_Docentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Docentes.Location = new System.Drawing.Point(6, 78);
            this.dgv_Docentes.Name = "dgv_Docentes";
            this.dgv_Docentes.Size = new System.Drawing.Size(277, 147);
            this.dgv_Docentes.TabIndex = 8;
            // 
            // chk_Legajo
            // 
            this.chk_Legajo.AutoSize = true;
            this.chk_Legajo.Location = new System.Drawing.Point(6, 29);
            this.chk_Legajo.Name = "chk_Legajo";
            this.chk_Legajo.Size = new System.Drawing.Size(58, 17);
            this.chk_Legajo.TabIndex = 0;
            this.chk_Legajo.Text = "Legajo";
            this.chk_Legajo.UseVisualStyleBackColor = true;
            this.chk_Legajo.CheckedChanged += new System.EventHandler(this.chk_LU_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_Carrera);
            this.groupBox2.Controls.Add(this.chk_Docente);
            this.groupBox2.Controls.Add(this.txt_BuscarMateria);
            this.groupBox2.Controls.Add(this.chk_NombreMateria);
            this.groupBox2.Controls.Add(this.chk_CodigoMateria);
            this.groupBox2.Controls.Add(this.dgv_Materias);
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(16, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 238);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Materia";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chk_Carrera
            // 
            this.chk_Carrera.AutoSize = true;
            this.chk_Carrera.Location = new System.Drawing.Point(226, 25);
            this.chk_Carrera.Name = "chk_Carrera";
            this.chk_Carrera.Size = new System.Drawing.Size(60, 17);
            this.chk_Carrera.TabIndex = 5;
            this.chk_Carrera.Text = "Carrera";
            this.chk_Carrera.UseVisualStyleBackColor = true;
            // 
            // chk_Docente
            // 
            this.chk_Docente.AutoSize = true;
            this.chk_Docente.Location = new System.Drawing.Point(153, 25);
            this.chk_Docente.Name = "chk_Docente";
            this.chk_Docente.Size = new System.Drawing.Size(67, 17);
            this.chk_Docente.TabIndex = 4;
            this.chk_Docente.Text = "Docente";
            this.chk_Docente.UseVisualStyleBackColor = true;
            // 
            // txt_BuscarMateria
            // 
            this.txt_BuscarMateria.Location = new System.Drawing.Point(292, 23);
            this.txt_BuscarMateria.Name = "txt_BuscarMateria";
            this.txt_BuscarMateria.Size = new System.Drawing.Size(164, 20);
            this.txt_BuscarMateria.TabIndex = 2;
            this.txt_BuscarMateria.TextChanged += new System.EventHandler(this.txt_BuscarMateria_TextChanged);
            // 
            // chk_NombreMateria
            // 
            this.chk_NombreMateria.AutoSize = true;
            this.chk_NombreMateria.Location = new System.Drawing.Point(84, 25);
            this.chk_NombreMateria.Name = "chk_NombreMateria";
            this.chk_NombreMateria.Size = new System.Drawing.Size(63, 17);
            this.chk_NombreMateria.TabIndex = 1;
            this.chk_NombreMateria.Text = "Nombre";
            this.chk_NombreMateria.UseVisualStyleBackColor = true;
            this.chk_NombreMateria.CheckedChanged += new System.EventHandler(this.chk_NombreMateria_CheckedChanged);
            // 
            // chk_CodigoMateria
            // 
            this.chk_CodigoMateria.AutoSize = true;
            this.chk_CodigoMateria.Location = new System.Drawing.Point(19, 25);
            this.chk_CodigoMateria.Name = "chk_CodigoMateria";
            this.chk_CodigoMateria.Size = new System.Drawing.Size(59, 17);
            this.chk_CodigoMateria.TabIndex = 0;
            this.chk_CodigoMateria.Text = "Codigo";
            this.chk_CodigoMateria.UseVisualStyleBackColor = true;
            this.chk_CodigoMateria.CheckedChanged += new System.EventHandler(this.chk_CodigoMateria_CheckedChanged);
            // 
            // dgv_Materias
            // 
            this.dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Materias.Location = new System.Drawing.Point(6, 49);
            this.dgv_Materias.Name = "dgv_Materias";
            this.dgv_Materias.Size = new System.Drawing.Size(464, 176);
            this.dgv_Materias.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(153, 37);
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
            this.Alumno.Location = new System.Drawing.Point(12, 37);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(75, 22);
            this.Alumno.TabIndex = 5;
            this.Alumno.Text = "Codigo";
            // 
            // Frm_Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 513);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_Materias";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Frm_Matriculas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Eliminar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carreras)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AgregarAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Docentes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Alumno;
        private System.Windows.Forms.DataGridView dgv_Docentes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_BuscarAlumno;
        private System.Windows.Forms.CheckBox chk_Apellido;
        private System.Windows.Forms.CheckBox chk_Legajo;
        private System.Windows.Forms.DataGridView dgv_Materias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_BuscarMateria;
        private System.Windows.Forms.CheckBox chk_NombreMateria;
        private System.Windows.Forms.CheckBox chk_CodigoMateria;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pic_AgregarAlumno;
        private System.Windows.Forms.CheckBox chk_Carrera;
        private System.Windows.Forms.CheckBox chk_Docente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_carrera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Carreras;
        private System.Windows.Forms.TextBox tex_nombreMat;
        private System.Windows.Forms.TextBox txt_codMat;
        private System.Windows.Forms.TextBox txt_docenteACargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BuscarCarrera;
        private System.Windows.Forms.PictureBox pic_Eliminar;
        private System.Windows.Forms.PictureBox pic_Agregar;
        private System.Windows.Forms.PictureBox pic_Editar;
        private System.Windows.Forms.CheckBox chk_Nombre;
    }
}