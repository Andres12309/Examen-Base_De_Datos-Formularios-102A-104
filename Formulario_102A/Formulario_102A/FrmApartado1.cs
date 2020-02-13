using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formulario_102A;

namespace Formulario_102A
{
    public partial class FrmApartado1 : Form
    {
        formulario_102A nRegistro = null;
        public int? id = null;
        public FrmApartado1()
        {
            InitializeComponent();
            if (id != null)
            {
                cargarDatos(id);
                //Refrescar();
            }
        }

        public void cargarDatos(int? id)
        {
            using (Formulario_102AEntities db = new Formulario_102AEntities())
            {
                nRegistro = db.formulario_102A.Find(id);
                TxtNoEmpleados.Text = Convert.ToString(nRegistro.NoEmpleados);
                Txt481.Text = Convert.ToString(nRegistro.i481);
                Txt491.Text = Convert.ToString(nRegistro.g491);
                Txt718.Text = Convert.ToString(nRegistro.i718);
                Txt729.Text = Convert.ToString(nRegistro.i729);
                Txt739.Text = Convert.ToString(nRegistro.g739);
                Txt741.Text = Convert.ToString(nRegistro.i741);
                Txt749.Text = Convert.ToString(nRegistro.r749);
                Txt751.Text = Convert.ToString(nRegistro.g751);
                Txt759.Text = Convert.ToString(nRegistro.r759);
                Txt769.Text = Convert.ToString(nRegistro.r769);
            }
        }

        private void BtnAceptar1_Click(object sender, EventArgs e)
        {
            using (Formulario_102AEntities db = new Formulario_102AEntities())
            {
                if (id == null)
                {
                    nRegistro = new formulario_102A();
                }

                nRegistro.i481 = Convert.ToInt32(Txt481.Text);
                nRegistro.g491 = Convert.ToInt32(Txt491.Text);
                nRegistro.i718 = Convert.ToInt32(Txt718.Text);
                nRegistro.i729 = Convert.ToInt32(Txt729.Text);
                nRegistro.g739 = Convert.ToInt32(Txt739.Text);
                nRegistro.i741 = Convert.ToInt32(Txt741.Text);
                nRegistro.r749 = Convert.ToInt32(Txt749.Text);
                nRegistro.g751 = Convert.ToInt32(Txt751.Text);
                nRegistro.r759 = Convert.ToInt32(Txt759.Text);
                nRegistro.r769 = Convert.ToInt32(Txt769.Text);
                if (id == null)
                {
                    db.formulario_102A.Add(nRegistro);

                }

                //db.Entry(nRegistro).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();

            }
        }

        private void Txt481_TextChanged(object sender, EventArgs e)
        {
            int txt729 = Convert.ToInt32(Txt481.Text) + Convert.ToInt32(Txt718.Text);
            Txt729.Text = txt729.ToString();
            int txt749 = Convert.ToInt32(Txt729.Text) + Convert.ToInt32(Txt739.Text);
            Txt749.Text = txt749.ToString();
            int txt769 = Convert.ToInt32(Txt749.Text) + Convert.ToInt32(Txt759.Text);
            Txt769.Text = txt769.ToString();
        }

        private void Txt718_TextChanged(object sender, EventArgs e)
        {
            int txt718 = Convert.ToInt32(Txt481.Text) + Convert.ToInt32(Txt718.Text);
            Txt729.Text = txt718.ToString();
            int txt749 = Convert.ToInt32(Txt729.Text) + Convert.ToInt32(Txt739.Text);
            Txt749.Text = txt749.ToString();
            int txt769 = Convert.ToInt32(Txt749.Text) + Convert.ToInt32(Txt759.Text);
            Txt769.Text = txt769.ToString();
        }

        private void Txt491_TextChanged(object sender, EventArgs e)
        {
            int txt491 = Convert.ToInt32(Txt491.Text);
            Txt739.Text = txt491.ToString();
            int txt749 = Convert.ToInt32(Txt729.Text) + Convert.ToInt32(Txt739.Text);
            Txt749.Text = txt749.ToString();
            int txt769 = Convert.ToInt32(Txt749.Text) + Convert.ToInt32(Txt759.Text);
            Txt769.Text = txt769.ToString();
        }

        private void Txt741_TextChanged(object sender, EventArgs e)
        {
            int txt741 = Convert.ToInt32(Txt741.Text) + Convert.ToInt32(Txt751.Text);
            Txt759.Text = txt741.ToString();
            int txt749 = Convert.ToInt32(Txt729.Text) + Convert.ToInt32(Txt739.Text);
            Txt749.Text = txt749.ToString();
            int txt769 = Convert.ToInt32(Txt749.Text) + Convert.ToInt32(Txt759.Text);
            Txt769.Text = txt769.ToString();
        }

        private void Txt751_TextChanged(object sender, EventArgs e)
        {
            int txt751 = Convert.ToInt32(Txt741.Text) + Convert.ToInt32(Txt751.Text);
            Txt759.Text = txt751.ToString();
            int txt749 = Convert.ToInt32(Txt729.Text) + Convert.ToInt32(Txt739.Text);
            Txt749.Text = txt749.ToString();
            int txt769 = Convert.ToInt32(Txt749.Text) + Convert.ToInt32(Txt759.Text);
            Txt769.Text = txt769.ToString();
        }

        private void Txt749_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt759_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
