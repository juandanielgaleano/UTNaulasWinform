using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesAula;

namespace UIAulas
{
    public partial class frmAlumno : Form
    {
        private Alumno _miAlumno;
        private Alumno miAlumno
        {
            get { return this._miAlumno; }

        }
        public frmAlumno()
        {
            InitializeComponent();
            
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            this.cmbSexo.Items.Add(eSexo.femenino);
            this.cmbSexo.Items.Add(eSexo.masculino);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._miAlumno = new Alumno(txtNombre.Text,int.Parse(txtLegajo.Text),(eSexo)cmbSexo.SelectedItem);
        }
    }
}
