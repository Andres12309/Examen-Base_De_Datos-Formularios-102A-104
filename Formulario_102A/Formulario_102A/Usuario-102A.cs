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
    public partial class Usuario_102A : Form
    {
        Usuarios usuario = null;
        public int? id = null;
        public Usuario_102A()
        {
            InitializeComponent();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            using (Formulario_102AEntities db = new Formulario_102AEntities())
            {
                if (id == null)
                {
                    usuario = new Usuarios();
                }

                var list = from d in db.Usuarios
                           where d.Ruc_Usuario == TxtRuc.Text
                           select d;
                if (list.Count()>0)
                {
                    this.Hide();
                    Form1 fr = new Form1(TxtRuc.Text, CmbPeriodo.Text, usuario.id_Usuario);
                    fr.FormClosed += (s, args) => this.Close();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Ruc incorrecto");
                }
            }
        }
    }
}
