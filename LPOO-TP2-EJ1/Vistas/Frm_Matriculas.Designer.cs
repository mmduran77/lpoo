namespace Vistas
{
    partial class Frm_Matriculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Matriculas));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_EliminarMatricula = new System.Windows.Forms.PictureBox();
            this.pic_ModificarMAtricula = new System.Windows.Forms.PictureBox();
            this.pic_AgregarMatricula = new System.Windows.Forms.PictureBox();
            this.dgv_BuscarAlumno = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pic_AgregarAlumno = new System.Windows.Forms.PictureBox();
            this.txt_BuscarAlumno = new System.Windows.Forms.TextBox();
            this.chk_AlumnoAlumno = new System.Windows.Forms.CheckBox();
            this.chk_LU = new System.Windows.Forms.CheckBox();
            this.dgv_BuscarMateria = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pic_AgregarMateria = new System.Windows.Forms.PictureBox();
            this.txt_BuscarMateria = new System.Windows.Forms.TextBox();
            this.chk_NombreMateria = new System.Windows.Forms.CheckBox();
            this.chk_CodigoMateria = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Alumno = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_Materia = new System.Windows.Forms.ComboBox();
            this.cmb_Alumno = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_BuscarMatricula = new System.Windows.Forms.TextBox();
            this.chk_MateriaMatricula = new System.Windows.Forms.CheckBox();
            this.chk_AlumnoMatricula = new System.Windows.Forms.CheckBox();
            this.dgv_Matriculas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EliminarMatricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ModificarMAtricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AgregarMatricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BuscarAlumno)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AgregarAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BuscarMateria)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AgregarMateria)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Matriculas)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.pic_EliminarMatricula);
            this.splitContainer1.Panel2.Controls.Add(this.pic_ModificarMAtricula);
            this.splitContainer1.Panel2.Controls.Add(this.pic_AgregarMatricula);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_BuscarAlumno);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_BuscarMateria);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Alumno);
            this.splitContainer1.Panel2.Controls.Add(this.dtp_fecha);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_Materia);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_Alumno);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_Matriculas);
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
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATRICULAS";
            // 
            // pic_EliminarMatricula
            // 
            this.pic_EliminarMatricula.Image = ((System.Drawing.Image)(resources.GetObject("pic_EliminarMatricula.Image")));
            this.pic_EliminarMatricula.Location = new System.Drawing.Point(404, 359);
            this.pic_EliminarMatricula.Name = "pic_EliminarMatricula";
            this.pic_EliminarMatricula.Size = new System.Drawing.Size(69, 59);
            this.pic_EliminarMatricula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_EliminarMatricula.TabIndex = 12;
            this.pic_EliminarMatricula.TabStop = false;
            // 
            // pic_ModificarMAtricula
            // 
            this.pic_ModificarMAtricula.Image = ((System.Drawing.Image)(resources.GetObject("pic_ModificarMAtricula.Image")));
            this.pic_ModificarMAtricula.Location = new System.Drawing.Point(325, 359);
            this.pic_ModificarMAtricula.Name = "pic_ModificarMAtricula";
            this.pic_ModificarMAtricula.Size = new System.Drawing.Size(73, 59);
            this.pic_ModificarMAtricula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ModificarMAtricula.TabIndex = 11;
            this.pic_ModificarMAtricula.TabStop = false;
            this.pic_ModificarMAtricula.Click += new System.EventHandler(this.pic_ModificarMAtricula_Click);
            // 
            // pic_AgregarMatricula
            // 
            this.pic_AgregarMatricula.Image = ((System.Drawing.Image)(resources.GetObject("pic_AgregarMatricula.Image")));
            this.pic_AgregarMatricula.Location = new System.Drawing.Point(240, 359);
            this.pic_AgregarMatricula.Name = "pic_AgregarMatricula";
            this.pic_AgregarMatricula.Size = new System.Drawing.Size(79, 59);
            this.pic_AgregarMatricula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_AgregarMatricula.TabIndex = 10;
            this.pic_AgregarMatricula.TabStop = false;
            this.pic_AgregarMatricula.Click += new System.EventHandler(this.pic_AgregarMatricula_Click);
            // 
            // dgv_BuscarAlumno
            // 
            this.dgv_BuscarAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BuscarAlumno.Location = new System.Drawing.Point(516, 302);
            this.dgv_BuscarAlumno.Name = "dgv_BuscarAlumno";
            this.dgv_BuscarAlumno.Size = new System.Drawing.Size(277, 110);
            this.dgv_BuscarAlumno.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pic_AgregarAlumno);
            this.groupBox3.Controls.Add(this.txt_BuscarAlumno);
            this.groupBox3.Controls.Add(this.chk_AlumnoAlumno);
            this.groupBox3.Controls.Add(this.chk_LU);
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(510, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 194);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Alumno";
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
            // chk_AlumnoAlumno
            // 
            this.chk_AlumnoAlumno.AutoSize = true;
            this.chk_AlumnoAlumno.Location = new System.Drawing.Point(80, 28);
            this.chk_AlumnoAlumno.Name = "chk_AlumnoAlumno";
            this.chk_AlumnoAlumno.Size = new System.Drawing.Size(101, 17);
            this.chk_AlumnoAlumno.TabIndex = 1;
            this.chk_AlumnoAlumno.Text = "Nombre Alumno";
            this.chk_AlumnoAlumno.UseVisualStyleBackColor = true;
            this.chk_AlumnoAlumno.CheckedChanged += new System.EventHandler(this.chk_AlumnoAlumno_CheckedChanged);
            // 
            // chk_LU
            // 
            this.chk_LU.AutoSize = true;
            this.chk_LU.Location = new System.Drawing.Point(6, 29);
            this.chk_LU.Name = "chk_LU";
            this.chk_LU.Size = new System.Drawing.Size(40, 17);
            this.chk_LU.TabIndex = 0;
            this.chk_LU.Text = "LU";
            this.chk_LU.UseVisualStyleBackColor = true;
            this.chk_LU.CheckedChanged += new System.EventHandler(this.chk_LU_CheckedChanged);
            // 
            // dgv_BuscarMateria
            // 
            this.dgv_BuscarMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BuscarMateria.Location = new System.Drawing.Point(516, 91);
            this.dgv_BuscarMateria.Name = "dgv_BuscarMateria";
            this.dgv_BuscarMateria.Size = new System.Drawing.Size(277, 110);
            this.dgv_BuscarMateria.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pic_AgregarMateria);
            this.groupBox2.Controls.Add(this.txt_BuscarMateria);
            this.groupBox2.Controls.Add(this.chk_NombreMateria);
            this.groupBox2.Controls.Add(this.chk_CodigoMateria);
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(510, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 194);
            this.groupBox2.TabIndex = 3;
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
            this.txt_BuscarMateria.TextChanged += new System.EventHandler(this.txt_BuscarMateria_TextChanged);
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
            this.chk_NombreMateria.CheckedChanged += new System.EventHandler(this.chk_NombreMateria_CheckedChanged);
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
            this.chk_CodigoMateria.CheckedChanged += new System.EventHandler(this.chk_CodigoMateria_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(269, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(136, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Materia";
            // 
            // Alumno
            // 
            this.Alumno.AutoSize = true;
            this.Alumno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alumno.ForeColor = System.Drawing.Color.Gainsboro;
            this.Alumno.Location = new System.Drawing.Point(12, 13);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(79, 22);
            this.Alumno.TabIndex = 5;
            this.Alumno.Text = "Alumno";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(273, 38);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 4;
            // 
            // cmb_Materia
            // 
            this.cmb_Materia.FormattingEnabled = true;
            this.cmb_Materia.Location = new System.Drawing.Point(140, 38);
            this.cmb_Materia.Name = "cmb_Materia";
            this.cmb_Materia.Size = new System.Drawing.Size(121, 21);
            this.cmb_Materia.TabIndex = 3;
            // 
            // cmb_Alumno
            // 
            this.cmb_Alumno.FormattingEnabled = true;
            this.cmb_Alumno.Location = new System.Drawing.Point(13, 38);
            this.cmb_Alumno.Name = "cmb_Alumno";
            this.cmb_Alumno.Size = new System.Drawing.Size(121, 21);
            this.cmb_Alumno.TabIndex = 2;
            this.cmb_Alumno.SelectedIndexChanged += new System.EventHandler(this.cmb_Alumno_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_BuscarMatricula);
            this.groupBox1.Controls.Add(this.chk_MateriaMatricula);
            this.groupBox1.Controls.Add(this.chk_AlumnoMatricula);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Matricula";
            // 
            // txt_BuscarMatricula
            // 
            this.txt_BuscarMatricula.Location = new System.Drawing.Point(228, 29);
            this.txt_BuscarMatricula.Name = "txt_BuscarMatricula";
            this.txt_BuscarMatricula.Size = new System.Drawing.Size(233, 20);
            this.txt_BuscarMatricula.TabIndex = 2;
            this.txt_BuscarMatricula.TextChanged += new System.EventHandler(this.txt_BuscarMatricula_TextChanged);
            // 
            // chk_MateriaMatricula
            // 
            this.chk_MateriaMatricula.AutoSize = true;
            this.chk_MateriaMatricula.Location = new System.Drawing.Point(127, 29);
            this.chk_MateriaMatricula.Name = "chk_MateriaMatricula";
            this.chk_MateriaMatricula.Size = new System.Drawing.Size(61, 17);
            this.chk_MateriaMatricula.TabIndex = 1;
            this.chk_MateriaMatricula.Text = "Materia";
            this.chk_MateriaMatricula.UseVisualStyleBackColor = true;
            this.chk_MateriaMatricula.CheckedChanged += new System.EventHandler(this.chk_MateriaMatricula_CheckedChanged);
            // 
            // chk_AlumnoMatricula
            // 
            this.chk_AlumnoMatricula.AutoSize = true;
            this.chk_AlumnoMatricula.Location = new System.Drawing.Point(17, 29);
            this.chk_AlumnoMatricula.Name = "chk_AlumnoMatricula";
            this.chk_AlumnoMatricula.Size = new System.Drawing.Size(101, 17);
            this.chk_AlumnoMatricula.TabIndex = 0;
            this.chk_AlumnoMatricula.Text = "Nombre Alumno";
            this.chk_AlumnoMatricula.UseVisualStyleBackColor = true;
            this.chk_AlumnoMatricula.CheckedChanged += new System.EventHandler(this.chk_AlumnoMatricula_CheckedChanged);
            // 
            // dgv_Matriculas
            // 
            this.dgv_Matriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Matriculas.Location = new System.Drawing.Point(12, 140);
            this.dgv_Matriculas.Name = "dgv_Matriculas";
            this.dgv_Matriculas.Size = new System.Drawing.Size(481, 213);
            this.dgv_Matriculas.TabIndex = 0;
            this.dgv_Matriculas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Matriculas_CellContentDoubleClick);
            // 
            // Frm_Matriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 513);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_Matriculas";
            this.Text = "Formulario Matriculas";
            this.Load += new System.EventHandler(this.Frm_Matriculas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EliminarMatricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ModificarMAtricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AgregarMatricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BuscarAlumno)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AgregarAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BuscarMateria)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AgregarMateria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Matriculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Matriculas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Alumno;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox cmb_Materia;
        private System.Windows.Forms.ComboBox cmb_Alumno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_BuscarMatricula;
        private System.Windows.Forms.CheckBox chk_MateriaMatricula;
        private System.Windows.Forms.CheckBox chk_AlumnoMatricula;
        private System.Windows.Forms.DataGridView dgv_BuscarAlumno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_BuscarAlumno;
        private System.Windows.Forms.CheckBox chk_AlumnoAlumno;
        private System.Windows.Forms.CheckBox chk_LU;
        private System.Windows.Forms.DataGridView dgv_BuscarMateria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_BuscarMateria;
        private System.Windows.Forms.CheckBox chk_NombreMateria;
        private System.Windows.Forms.CheckBox chk_CodigoMateria;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pic_EliminarMatricula;
        private System.Windows.Forms.PictureBox pic_ModificarMAtricula;
        private System.Windows.Forms.PictureBox pic_AgregarMatricula;
        private System.Windows.Forms.PictureBox pic_AgregarAlumno;
        private System.Windows.Forms.PictureBox pic_AgregarMateria;
    }
}