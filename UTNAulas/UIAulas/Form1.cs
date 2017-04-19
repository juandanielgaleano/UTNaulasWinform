using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIAulas
{
    public partial class frmPrincipal : Form
    {
        private EntidadesAula.Aula _miAula;
        public frmPrincipal()
        {
            InitializeComponent();
            this._miAula = new EntidadesAula.Aula();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno frm = new frmAlumno();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                
            }
        }
    }
}
