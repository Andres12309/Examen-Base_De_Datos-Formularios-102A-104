using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_102A
{
    public partial class Usuario_104 : Form
    {
        public int? id = null;
        public Usuario_104()
        {
            InitializeComponent();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fr = new Form2(TxtRuc.Text,CmbPeriodo.Text);
            fr.FormClosed += (s, args) => this.Close();
            fr.Show();
        }
    }
}
