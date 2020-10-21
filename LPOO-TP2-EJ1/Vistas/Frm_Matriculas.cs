using Dominio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Frm_Matriculas : Form
    {
        public Frm_Matriculas()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Frm_Matriculas_Load(object sender, EventArgs e)
        {
            listarMatriculas();
            listarAlumnos();
            listarMaterias();
        }

        private void listarMatriculas()
        {
            MatriculaModel matriculaModel = new MatriculaModel();
            this.dgv_Matriculas.DataSource = matriculaModel.listarMatriculas();
        }

        private void listarAlumnos()
        {
            AlumnoModel alumnoModel = new AlumnoModel();
            this.dgv_BuscarAlumno.DataSource = alumnoModel.listarAlumnos();
            this.cmb_Alumno.DataSource = alumnoModel.listarAlumnos();
            this.cmb_Alumno.DisplayMember = "apellido";
            this.cmb_Alumno.ValueMember = "lu";
             
        }
        private void listarMaterias() 
        {
            MateriaModel materiaModel = new MateriaModel();
            this.dgv_BuscarMateria.DataSource = materiaModel.listarMaterias();
            this.cmb_Materia.DataSource = materiaModel.listarMaterias();
            this.cmb_Materia.DisplayMember = "nombre";
            this.cmb_Materia.ValueMember = "codigo";
        }

        private void cmb_Alumno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_BuscarMateria_TextChanged(object sender, EventArgs e)
        {
            MateriaModel materiaModel = new MateriaModel();
            try
            {
                if (this.chk_CodigoMateria.Checked == true && this.chk_NombreMateria.Checked == false)
                {
                    dgv_BuscarMateria.DataSource = materiaModel.filtrarMaterias("XCodigo", txt_BuscarMateria.Text);

                }
                if (this.chk_NombreMateria.Checked == true && this.chk_CodigoMateria.Checked == false)
                {
                    dgv_BuscarMateria.DataSource = materiaModel.filtrarMaterias("XNombre", txt_BuscarMateria.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cuando Filtras" + ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void chk_CodigoMateria_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_CodigoMateria.Checked == true)
            {
                this.chk_NombreMateria.Checked = false;                
            }
        }

        private void chk_NombreMateria_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_NombreMateria.Checked == true)
            {
                this.chk_CodigoMateria.Checked = false;
            }
        }

        private void txt_BuscarAlumno_TextChanged(object sender, EventArgs e)
        {
            AlumnoModel alumnoModel = new AlumnoModel();
            try
            {
                if (this.chk_LU.Checked == true && this.chk_AlumnoAlumno.Checked == false)
                {
                    dgv_BuscarAlumno.DataSource = alumnoModel.filtrarAlumnos("XLU", txt_BuscarAlumno.Text);

                }
                if (this.chk_AlumnoAlumno.Checked == true && this.chk_LU.Checked == false)
                {
                    dgv_BuscarAlumno.DataSource = alumnoModel.filtrarAlumnos("XNombre", txt_BuscarAlumno.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cuando Filtras" + ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void chk_AlumnoAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_AlumnoAlumno.Checked == true)
            {
                this.chk_LU.Checked = false;
            }
        }

        private void chk_LU_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_LU.Checked == true)
            {
                this.chk_AlumnoAlumno.Checked = false;
            }
        }

        private void txt_BuscarMatricula_TextChanged(object sender, EventArgs e)
        {
            MatriculaModel matriculaModel = new MatriculaModel();
            try
            {
                if (this.chk_AlumnoMatricula.Checked == true && this.chk_MateriaMatricula.Checked == false)
                {
                    dgv_Matriculas.DataSource = matriculaModel.filtrarMatriculas("XLU", txt_BuscarMatricula.Text);

                }
                if (this.chk_MateriaMatricula.Checked == true && this.chk_AlumnoMatricula.Checked == false)
                {
                    dgv_Matriculas.DataSource = matriculaModel.filtrarMatriculas("XNombre", txt_BuscarMatricula.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cuando Filtras" + ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void chk_AlumnoMatricula_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_AlumnoMatricula.Checked == true)
            {
                this.chk_MateriaMatricula.Checked = false;
            }
        }
        private void chk_MateriaMatricula_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_MateriaMatricula.Checked == true)
            {
                this.chk_AlumnoMatricula.Checked = false;
            }
        }

        private void pic_AgregarMatricula_Click(object sender, EventArgs e)
        {
            try
            {
                MatriculaModel matriculaModel = new MatriculaModel();
                var luAlu = cmb_Alumno.SelectedValue.ToString(); 
                var codMat = cmb_Materia.SelectedValue.ToString();
                var fecha = dtp_fecha.Value;
                MessageBox.Show("materia es: " + codMat + " Lu alumno es " + luAlu);
                
                matriculaModel.agregarMatricula(luAlu, codMat, fecha);
                listarMatriculas();
                limpiarCampos();
            }catch (Exception)
            {
                throw;
            }
        }
        private void limpiarCampos()
        {
            this.cmb_Alumno.Text = "";
            this.cmb_Materia.Text = "";
        }

        private void pic_ModificarMAtricula_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Matriculas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Matriculas != null)
            {
                this.cmb_Alumno.Text = dgv_Matriculas.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.cmb_Materia.Text = dgv_Matriculas.Rows[e.RowIndex].Cells[1].Value.ToString();
                
               
            }
            else
            {
                MessageBox.Show("No hay datos en la tabla", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
