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
    public partial class Form2 : Form
    {
        formulario_104 nRegistro = null;
        public int? id = null;
        public Form2(string ruc, string periodo)
        {
            InitializeComponent();
            if (id != null)
            {
                cargarDatos(id);
            }
            LblAño.Text = periodo;
            TxtRuc.Text = ruc;
        }
        private void cargarDatos(int? id)
        {
            using (Entities db = new Entities())
            {
                if (id != null)
                {
                    nRegistro = new formulario_104();
                }
                var list = from d in db.formulario_104
                           where d.Ruc_Usuario == TxtRuc.Text && d.periodo == LblAño.Text
                           select d;
                if (list.Count() > 0)
                {
                    LblAño.Text = nRegistro.periodo;
                    TxtRuc.Text = nRegistro.Ruc_Usuario;
                    Lbl401.Text = Convert.ToString(nRegistro.c401);
                    Lbl409.Text = Convert.ToString(nRegistro.c409);
                    Lbl411.Text = Convert.ToString(nRegistro.c411);
                    Lbl419.Text = Convert.ToString(nRegistro.c419);
                    Lbl421.Text = Convert.ToString(nRegistro.c421);
                    Lbl429.Text = Convert.ToString(nRegistro.c429);
                    Lbl499.Text = Convert.ToString(nRegistro.c499);

                    Lbl601.Text = Convert.ToString(nRegistro.r601);
                    Lbl605.Text = Convert.ToString(nRegistro.r605);
                    Lbl608.Text = Convert.ToString(nRegistro.r608);
                    Lbl609.Text = Convert.ToString(nRegistro.r609);
                    Lbl615.Text = Convert.ToString(nRegistro.r615);
                    Lbl620.Text = Convert.ToString(nRegistro.r620);
                    Lbl699.Text = Convert.ToString(nRegistro.r699);

                }
                else
                {
                    MessageBox.Show("Actualizar formulario");
                }

            }
        }
        private void BtnEditarInfo1_Click(object sender, EventArgs e)
        {
            BtnAceptar1.Visible = true;
            Txt401.Visible = true;
            Txt409.Visible = true;
            Txt411.Visible = true;
            Txt419.Visible = true;
            Txt421.Visible = true;
            Txt429.Visible = true;
            Txt499.Visible = true;
            BtnEditarInfo1.Visible = false;
        }

        private void BtnAceptar1_Click(object sender, EventArgs e)
        {
            BtnAceptar1.Visible = false;
            BtnEditarInfo1.Visible = true;
            Lbl401.Text = Txt401.Text;
            Lbl409.Text = Txt409.Text;
            Lbl411.Text = Txt411.Text;
            Lbl419.Text = Txt419.Text;
            Lbl421.Text = Txt421.Text;
            Lbl429.Text = Txt429.Text;
            Lbl499.Text = Txt499.Text;


            Txt401.Visible = false;
            Txt409.Visible = false;
            Txt411.Visible = false;
            Txt419.Visible = false;
            Txt421.Visible = false;
            Txt429.Visible = false;
            Txt499.Visible = false;

            double txt601 = Convert.ToDouble(Txt499.Text);
            Txt601.Text = txt601.ToString();

            double txt620 = Convert.ToDouble(Txt601.Text) - Convert.ToDouble(Txt605.Text) - Convert.ToDouble(Txt608.Text) - Convert.ToDouble(Txt609.Text);
            Txt620.Text = txt620.ToString();

            Txt699.Text = Txt620.Text;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                if (id == null)
                {
                    nRegistro = new formulario_104();
                }

                nRegistro.periodo = LblAño.Text;
                nRegistro.Ruc_Usuario = TxtRuc.Text;
                nRegistro.c401 = Convert.ToDouble(Lbl401.Text);
                nRegistro.c409 = Convert.ToDouble(Lbl409.Text);
                nRegistro.c411 = Convert.ToDouble(Lbl411.Text);
                nRegistro.c419 = Convert.ToDouble(Lbl419.Text);
                nRegistro.c421 = Convert.ToDouble(Lbl421.Text);
                nRegistro.c429 = Convert.ToDouble(Lbl429.Text);
                nRegistro.c499 = Convert.ToDouble(Lbl499.Text);

                nRegistro.r601 = Convert.ToDouble(Lbl601.Text);
                nRegistro.r605 = Convert.ToDouble(Lbl605.Text);
                nRegistro.r608 = Convert.ToDouble(Lbl608.Text);
                nRegistro.r609 = Convert.ToDouble(Lbl609.Text);
                nRegistro.r615 = Convert.ToDouble(Lbl615.Text);
                nRegistro.r620 = Convert.ToDouble(Lbl620.Text);
                nRegistro.r699 = Convert.ToDouble(Lbl699.Text);

                if (id == null)
                {
                    db.formulario_104.Add(nRegistro);

                }

                //db.Entry(nRegistro).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
                MessageBox.Show("Su formulario se registro exitosamente");
            }


        }

        private void BtnEditarInfo3_Click(object sender, EventArgs e)
        {
            BtnAceptar3.Visible = true;
            Txt601.Visible = true;
            Txt605.Visible = true;
            Txt608.Visible = true;
            Txt609.Visible = true;
            Txt615.Visible = true;
            Txt620.Visible = true;
            Txt699.Visible = true;

            BtnEditarInfo3.Visible = false;
        }

        private void BtnAceptar3_Click(object sender, EventArgs e)
        {
            BtnEditarInfo3.Visible = true;
            Lbl601.Text = Txt601.Text;
            Lbl605.Text = Txt605.Text;
            Lbl608.Text = Txt608.Text;
            Lbl609.Text = Txt609.Text;
            Lbl615.Text = Txt615.Text;
            Lbl620.Text = Txt620.Text;
            Lbl699.Text = Txt699.Text;
            BtnAceptar3.Visible = false;

            Txt601.Visible = false;
            Txt605.Visible = false;
            Txt608.Visible = false;
            Txt609.Visible = false;
            Txt615.Visible = false;
            Txt620.Visible = false;
            Txt699.Visible = false;
        }

        private void Txt401_TextChanged(object sender, EventArgs e)
        {
            double txt401 = Convert.ToDouble(Txt401.Text);
            Txt409.Text = txt401.ToString();
        }

        private void Txt411_TextChanged(object sender, EventArgs e)
        {
            double txt411 = Convert.ToDouble(Txt411.Text);
            Txt419.Text = txt411.ToString();

            double txt421 = txt411*0.12;
            Txt421.Text = txt421.ToString();

            Txt429.Text = txt421.ToString();

            Txt499.Text = Txt429.Text;
        }

        private void Txt605_TextChanged(object sender, EventArgs e)
        {
            double txt615 = Convert.ToDouble(Txt601.Text) - Convert.ToDouble(Txt605.Text);
            Txt615.Text = txt615.ToString();

            double txt620 = Convert.ToDouble(Txt601.Text) - Convert.ToDouble(Txt605.Text) - Convert.ToDouble(Txt608.Text) - Convert.ToDouble(Txt609.Text);
            Txt620.Text = txt620.ToString();

            Txt699.Text = Txt620.Text;
        }

        private void Txt608_TextChanged(object sender, EventArgs e)
        {
            double txt620 = Convert.ToDouble(Txt601.Text) - Convert.ToDouble(Txt605.Text) - Convert.ToDouble(Txt608.Text) - Convert.ToDouble(Txt609.Text);
            Txt620.Text = txt620.ToString();

            Txt699.Text = Txt620.Text;
        }

        private void Txt609_TextChanged(object sender, EventArgs e)
        {
            double txt620 = Convert.ToDouble(Txt601.Text) - Convert.ToDouble(Txt605.Text) - Convert.ToDouble(Txt608.Text) - Convert.ToDouble(Txt609.Text);
            Txt620.Text = txt620.ToString();
            Txt699.Text = Txt620.Text;
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmFormularios fr = new FrmFormularios();
            fr.FormClosed += (s, args) => this.Close();
            fr.Show();
        }
    }
}
