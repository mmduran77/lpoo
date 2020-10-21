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
    public partial class Frm_Materias : Form
    {
        public Frm_Materias()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Frm_Matriculas_Load(object sender, EventArgs e)
        {
            
            listarCarreras();
            listarMaterias();
            listarDocentes();
        }

        private void listarCarreras()
        {
            CarreraModel carreraModel = new CarreraModel();
            this.cmb_carrera.DataSource = carreraModel.listarCarreras();
            this.cmb_carrera.DisplayMember = "carrera";
            this.cmb_carrera.ValueMember = "idCarrera";
        }
        
        private void listarMaterias()
        {
            MateriaModel materiaModel = new MateriaModel();
            this.dgv_Materias.DataSource = materiaModel.listarMaterias();            
        }

        private void listarDocentes()
        {
            DocenteModel docenteModel = new DocenteModel();
            this.dgv_Docentes.DataSource = docenteModel.listarDocentes();
        }
        

        private void txt_BuscarMateria_TextChanged(object sender, EventArgs e)
        {
            MateriaModel materiaModel = new MateriaModel();
            try
            {
                if (this.chk_CodigoMateria.Checked == true && this.chk_NombreMateria.Checked == false)
                {
                    dgv_Materias.DataSource = materiaModel.filtrarMaterias("XCodigo", txt_BuscarMateria.Text);

                }
                if (this.chk_NombreMateria.Checked == true && this.chk_CodigoMateria.Checked == false)
                {
                    dgv_Materias.DataSource = materiaModel.filtrarMaterias("XNombre", txt_BuscarMateria.Text);
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
                this.chk_Docente.Checked = false;
                this.chk_Carrera.Checked = false;
            }
        }

        private void chk_NombreMateria_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_NombreMateria.Checked == true)
            {
                this.chk_CodigoMateria.Checked = false;
                this.chk_Docente.Checked = false;
                this.chk_Carrera.Checked = false;
            }
        }


        private void txt_BuscarAlumno_TextChanged(object sender, EventArgs e)
        {
            AlumnoModel alumnoModel = new AlumnoModel();
            try
            {
                if (this.chk_Legajo.Checked == true && this.chk_Apellido.Checked == false)
                {
                    dgv_Docentes.DataSource = alumnoModel.filtrarAlumnos("XLU", txt_BuscarAlumno.Text);

                }
                if (this.chk_Apellido.Checked == true && this.chk_Legajo.Checked == false)
                {
                    dgv_Docentes.DataSource = alumnoModel.filtrarAlumnos("XNombre", txt_BuscarAlumno.Text);
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
            if (this.chk_Apellido.Checked == true)
            {
                this.chk_Legajo.Checked = false;
            }
        }

        private void chk_LU_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_Legajo.Checked == true)
            {
                this.chk_Apellido.Checked = false;
            }
        }

            

        private void pic_AgregarMatricula_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Carreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
