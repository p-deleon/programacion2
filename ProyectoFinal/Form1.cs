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
    public partial class Form1 : Form
    {
        public Form1()
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
           
                ChildForm f = new ChildForm();
                f.MdiParent = this;
                f.Text = "Form - " + this.MdiChildren.Length.ToString();
                f.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            toolStripStatusLabel1.Text = datetime.ToString();

        }
    }
}
