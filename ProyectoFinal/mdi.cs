using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class mdi : Form
    {
        public mdi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Pongan su matricula para ver que pudieron entrar
            //2019-8874 Euris Aquino
            timer1.Start();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This method creates a new ChildForm instance
            // and attaches it to the MDI parent form.
           
                grupoEntidades f = new grupoEntidades();
                f.MdiParent = this;
                f.Text = "GrupoEntidades - " + this.MdiChildren.Length.ToString();
                f.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            toolStripStatusLabel1.Text = datetime.ToString();

        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tipoEntidades f = new tipoEntidades();
            f.MdiParent = this;
            f.Text = "TipoEntidades - " + this.MdiChildren.Length.ToString();
            f.Show();
        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            entidades f = new entidades();
            f.MdiParent = this;
            f.Text = "Entidades - " + this.MdiChildren.Length.ToString();
            f.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AcercaDe f = new AcercaDe();
            f.MdiParent = this;
            f.Text = "AcercaDe - " + this.MdiChildren.Length.ToString();
            f.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            login f = new login();
            f.MdiParent = this;
            f.Text = "Login - " + this.MdiChildren.Length.ToString();
            f.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir de la Aplicacion", "SALIR DEL PROGRAMA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcion == DialogResult.OK)
            {
                Close();
            }

        }
    }
}
