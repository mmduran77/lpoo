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
    public partial class Frm_Alumnos : Form
    {
        public Frm_Alumnos()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Frm_Matriculas_Load(object sender, EventArgs e)
        {
            listarAlumnos();            
        }

        
        private void listarAlumnos()
        {
            AlumnoModel alumnoModel = new AlumnoModel();
            this.dgv_Alumnos.DataSource = alumnoModel.listarAlumnos();                        
        }
        
        private void txt_BuscarMateria_TextChanged(object sender, EventArgs e)
        {
            MateriaModel materiaModel = new MateriaModel();
            try
            {
                if (this.chk_LuAlu.Checked == true && this.chk_NombreAlu.Checked == false)
                {
                    dgv_Alumnos.DataSource = materiaModel.filtrarMaterias("XCodigo", txt_BuscarAlumno.Text);

                }
                if (this.chk_NombreAlu.Checked == true && this.chk_LuAlu.Checked == false)
                {
                    dgv_Alumnos.DataSource = materiaModel.filtrarMaterias("XNombre", txt_BuscarAlumno.Text);
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
            if (this.chk_LuAlu.Checked == true)
            {
                this.chk_NombreAlu.Checked = false;                
            }
        }

        private void chk_NombreMateria_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_NombreAlu.Checked == true)
            {
                this.chk_LuAlu.Checked = false;
            }
        }

        private void txt_BuscarAlumno_TextChanged(object sender, EventArgs e)
        {
            AlumnoModel alumnoModel = new AlumnoModel();
            try
            {
                if (this.chk_LuAlu.Checked == true && this.chk_NombreAlu.Checked == false)
                {
                    dgv_Alumnos.DataSource = alumnoModel.filtrarAlumnos("XLU", txt_BuscarAlumno.Text);

                }
                if (this.chk_NombreAlu.Checked == true && this.chk_LuAlu.Checked == false)
                {
                    dgv_Alumnos.DataSource = alumnoModel.filtrarAlumnos("XNombre", txt_BuscarAlumno.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cuando Filtras" + ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        
    }
}
