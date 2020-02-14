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
    public partial class FrmFormularios : Form
    {
        public FrmFormularios()
        {
            InitializeComponent();
        }

        private void Img102A_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario_102A fr = new Usuario_102A();
            fr.FormClosed += (s, args) => this.Close();
            fr.Show();
        }

        private void Img104_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario_104 fr = new Usuario_104();
            fr.FormClosed += (s, args) => this.Close();
            fr.Show();
        }
    }
}
