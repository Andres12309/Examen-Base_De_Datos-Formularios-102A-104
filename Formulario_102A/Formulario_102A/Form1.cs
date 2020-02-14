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
    public partial class Form1 : Form
    {
        formulario_102A nRegistro = null;
        public int? id = null;
        public Form1(string ruc, string periodo, int id_user)
        {
            InitializeComponent();
            BtnAceptar1.Visible = false;
            BtnAceptar2.Visible = false;
            BtnAceptar3.Visible = false;
            TxtNoEmpleados.Visible = false;

            if (id != null)
            {
                cargarDatos(id);
            }
            LblId_user.Text = id_user.ToString();
            LblAño.Text = periodo;

        }

        private void cargarDatos(int? id)
        {
            using (Formulario_102AEntities db = new Formulario_102AEntities())
            {
                if (id != null)
                {
                    nRegistro = new formulario_102A();
                }
                var list = from d in db.formulario_102A
                           where d.id_Usuario == Convert.ToInt32(LblId_user.Text) && d.periodo == LblAño.Text
                           select d;
                if (list.Count() > 0)
                {
                    LblAño.Text = nRegistro.periodo;
                    LblNoEmpleados.Text = Convert.ToString(nRegistro.NoEmpleados);
                    Lbl481.Text = Convert.ToString(nRegistro.i481);
                    Lbl491.Text = Convert.ToString(nRegistro.g491);
                    Lbl718.Text = Convert.ToString(nRegistro.i718);
                    Lbl729.Text = Convert.ToString(nRegistro.i729);
                    Lbl739.Text = Convert.ToString(nRegistro.g739);
                    Lbl741.Text = Convert.ToString(nRegistro.i741);
                    Lbl749.Text = Convert.ToString(nRegistro.r749);
                    Lbl751.Text = Convert.ToString(nRegistro.g751);
                    Lbl759.Text = Convert.ToString(nRegistro.r759);
                    Lbl768.Text = Convert.ToString(nRegistro.p768);
                    Lbl769.Text = Convert.ToString(nRegistro.r769);
                    Lbl771.Text = Convert.ToString(nRegistro.p771);
                    Lbl772.Text = Convert.ToString(nRegistro.p772);
                    Lbl773.Text = Convert.ToString(nRegistro.p773);
                    Lbl774.Text = Convert.ToString(nRegistro.p774);
                    Lbl775.Text = Convert.ToString(nRegistro.p775);
                    Lbl779.Text = Convert.ToString(nRegistro.p779);
                    Lbl780.Text = Convert.ToString(nRegistro.p780);
                    CmbTipoBeneficiario.Text = nRegistro.b740;
                    Lbl832.Text = Convert.ToString(nRegistro.c832);
                    Lbl839.Text = Convert.ToString(nRegistro.c839);
                    Lbl840.Text = Convert.ToString(nRegistro.c840);
                    Lbl845.Text = Convert.ToString(nRegistro.c845);
                    Lbl846.Text = Convert.ToString(nRegistro.c846);
                    Lbl855.Text = Convert.ToString(nRegistro.c855);
                    Lbl856.Text = Convert.ToString(nRegistro.c856);
                    Lbl859.Text = Convert.ToString(nRegistro.c859);
                    Lbl869.Text = Convert.ToString(nRegistro.c869);
                }
                else
                {
                    MessageBox.Show("Actualizar formulario");
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LblAño_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditarInfo1_Click(object sender, EventArgs e)
        {
            TxtNoEmpleados.Visible = true;
            BtnAceptar1.Visible = true;
            Txt481.Visible = true;
            Txt718.Visible = true;
            Txt729.Visible = true;
            Txt741.Visible = true;
            Txt491.Visible = true;
            Txt739.Visible = true;
            Txt751.Visible = true;
            Txt749.Visible = true;
            Txt759.Visible = true;
            Txt769.Visible = true;
            BtnEditarInfo1.Visible = false;
        }

        private void Txt481_TextChanged(object sender, EventArgs e)
        {
            int txt729 = Convert.ToInt32(Txt481.Text) + Convert.ToInt32(Txt718.Text);
            Txt729.Text = txt729.ToString();
            int txt749 = Convert.ToInt32(Txt729.Text) - Convert.ToInt32(Txt739.Text);
            Txt749.Text = txt749.ToString();
            int txt769 = Convert.ToInt32(Txt749.Text) + Convert.ToInt32(Txt759.Text);
            Txt769.Text = txt769.ToString();
        }

        private void Txt718_TextChanged(object sender, EventArgs e)
        {
            int txt718 = Convert.ToInt32(Txt481.Text) + Convert.ToInt32(Txt718.Text);
            Txt729.Text = txt718.ToString();
            int txt749 = Convert.ToInt32(Txt729.Text) - Convert.ToInt32(Txt739.Text);
            Txt749.Text = txt749.ToString();
            int txt769 = Convert.ToInt32(Txt749.Text) + Convert.ToInt32(Txt759.Text);
            Txt769.Text = txt769.ToString();
        }

        private void Txt491_TextChanged(object sender, EventArgs e)
        {
            int txt491 = Convert.ToInt32(Txt491.Text);
            Txt739.Text = txt491.ToString();
            int txt749 = Convert.ToInt32(Txt729.Text) - Convert.ToInt32(Txt739.Text);
            Txt749.Text = txt749.ToString();
            int txt769 = Convert.ToInt32(Txt749.Text) + Convert.ToInt32(Txt759.Text);
            Txt769.Text = txt769.ToString();
        }

        private void Txt741_TextChanged(object sender, EventArgs e)
        {
            int txt741 = Convert.ToInt32(Txt741.Text) + Convert.ToInt32(Txt751.Text);
            Txt759.Text = txt741.ToString();
            int txt749 = Convert.ToInt32(Txt729.Text) - Convert.ToInt32(Txt739.Text);
            Txt749.Text = txt749.ToString();
            int txt769 = Convert.ToInt32(Txt749.Text) + Convert.ToInt32(Txt759.Text);
            Txt769.Text = txt769.ToString();
        }

        private void Txt751_TextChanged(object sender, EventArgs e)
        {
            int txt751 = Convert.ToInt32(Txt741.Text) + Convert.ToInt32(Txt751.Text);
            Txt759.Text = txt751.ToString();
            int txt749 = Convert.ToInt32(Txt729.Text) - Convert.ToInt32(Txt739.Text);
            Txt749.Text = txt749.ToString();
            int txt769 = Convert.ToInt32(Txt749.Text) + Convert.ToInt32(Txt759.Text);
            Txt769.Text = txt769.ToString();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            using (Formulario_102AEntities db = new Formulario_102AEntities())
            {
                if (id == null)
                {
                    nRegistro = new formulario_102A();
                }
                
                nRegistro.periodo = LblAño.Text;
                nRegistro.NoEmpleados = Convert.ToInt32(LblNoEmpleados.Text);
                nRegistro.i481 = Convert.ToInt32(Lbl481.Text);
                nRegistro.g491 = Convert.ToInt32(Lbl491.Text);
                nRegistro.i718 = Convert.ToInt32(Lbl718.Text);
                nRegistro.i729 = Convert.ToInt32(Lbl729.Text);
                nRegistro.g739 = Convert.ToInt32(Lbl739.Text);
                nRegistro.i741 = Convert.ToInt32(Lbl741.Text);
                nRegistro.r749 = Convert.ToInt32(Lbl749.Text);
                nRegistro.g751 = Convert.ToInt32(Lbl751.Text);
                nRegistro.r759 = Convert.ToInt32(Lbl759.Text);
                nRegistro.r769 = Convert.ToInt32(Lbl769.Text);

                nRegistro.p768 = Convert.ToInt32(Lbl768.Text);
                nRegistro.p771 = Convert.ToInt32(Lbl771.Text);
                nRegistro.p772 = Convert.ToInt32(Lbl772.Text);
                nRegistro.p773 = Convert.ToInt32(Lbl773.Text);
                nRegistro.p774 = Convert.ToInt32(Lbl774.Text);
                nRegistro.p775 = Convert.ToInt32(Lbl775.Text);
                nRegistro.p779 = Convert.ToInt32(Lbl779.Text);
                nRegistro.p780 = Convert.ToInt32(Lbl780.Text);
                nRegistro.b740 = CmbTipoBeneficiario.Text;

                nRegistro.c832 = Convert.ToInt32(Lbl481.Text);
                nRegistro.c839 = Convert.ToDouble(Lbl839.Text);
                nRegistro.c840 = Convert.ToInt32(Lbl840.Text);
                nRegistro.c845 = Convert.ToInt32(Lbl845.Text);
                nRegistro.c846 = Convert.ToInt32(Lbl846.Text);
                nRegistro.c855 = Convert.ToDouble(Lbl855.Text);
                nRegistro.c856 = Convert.ToDouble(Lbl856.Text);
                nRegistro.c859 = Convert.ToDouble(Lbl859.Text);
                nRegistro.c869 = Convert.ToDouble(Lbl869.Text);

                if (id == null)
                {
                    db.formulario_102A.Add(nRegistro);

                }

                //db.Entry(nRegistro).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
                MessageBox.Show("Su formulario se registro exitosamente");
            }
        }
        private void BtnEditarInfo2_Click(object sender, EventArgs e)
        {
            BtnAceptar2.Visible = true;
            Txt768.Visible = true;
            Txt771.Visible = true;
            Txt772.Visible = true;
            Txt773.Visible = true;
            Txt774.Visible = true;
            Txt775.Visible = true;
            Txt779.Visible = true;
            Txt780.Visible = true;
            BtnEditarInfo2.Visible = false;
        }
        private void BtnAceptar1_Click_1(object sender, EventArgs e)
        {
            BtnAceptar1.Visible = false;
            BtnEditarInfo1.Visible = true;
            LblNoEmpleados.Text = TxtNoEmpleados.Text;
            Lbl481.Text = Txt481.Text;
            Lbl491.Text = Txt491.Text;
            Lbl718.Text = Txt718.Text;
            Lbl729.Text = Txt729.Text;
            Lbl739.Text = Txt739.Text;
            Lbl741.Text = Txt741.Text;
            Lbl749.Text = Txt749.Text;
            Lbl751.Text = Txt751.Text;
            Lbl759.Text = Txt759.Text;
            Lbl769.Text = Txt769.Text;

            TxtNoEmpleados.Visible = false;
            Txt481.Visible = false;
            Txt718.Visible = false;
            Txt729.Visible = false;
            Txt741.Visible = false;
            Txt491.Visible = false;
            Txt739.Visible = false;
            Txt751.Visible = false;
            Txt749.Visible = false;
            Txt759.Visible = false;
            Txt769.Visible = false;
        }

        private void BtnAceptar2_Click(object sender, EventArgs e)
        {
            BtnEditarInfo2.Visible = true;
            Lbl768.Text = Txt768.Text;
            Lbl771.Text = Txt771.Text;
            Lbl772.Text = Txt772.Text;
            Lbl773.Text = Txt773.Text;
            Lbl774.Text = Txt774.Text;
            Lbl775.Text = Txt775.Text;
            Lbl779.Text = Txt779.Text;
            Lbl780.Text = Txt780.Text;

            BtnAceptar2.Visible = false;

            Txt768.Visible = false;
            Txt771.Visible = false;
            Txt772.Visible = false;
            Txt773.Visible = false;
            Txt774.Visible = false;
            Txt775.Visible = false;
            Txt779.Visible = false;
            Txt780.Visible = false;

            int txt832 = Convert.ToInt32(Txt769.Text) - Convert.ToInt32(Txt779.Text);
            Txt832.Text = txt832.ToString();
            double impuesto = 0;
            if (txt832 >= 0 && txt832 < 11310)
            {
                impuesto = (txt832 - 0) * 0;
            }
            else if (txt832 >= 11310 && txt832 < 14410)
            {
                impuesto = (txt832 - 11310) * 0.05 + 0;
            }
            else if (txt832 >= 14410 && txt832 < 18010)
            {
                impuesto = (txt832 - 14410) * 0.10 + 155;
            }
            else if (txt832 >= 18010 && txt832 < 21630)
            {
                impuesto = (txt832 - 18010) * 0.12 + 515;
            }
            else if (txt832 >= 21630 && txt832 < 43250)
            {
                impuesto = (txt832 - 21630) * 0.15 + 949;
            }
            else if (txt832 >= 43250 && txt832 < 64860)
            {
                impuesto = (txt832 - 43250) * 0.20 + 4193;
            }
            else if (txt832 >= 64860 && txt832 < 86480)
            {
                impuesto = (txt832 - 64860) * 0.25 + 8513;
            }
            else if (txt832 >= 86480 && txt832 < 115290)
            {
                impuesto = (txt832 - 86480) * 0.30 + 13920;
            }
            else if (txt832 >= 115290)
            {
                impuesto = (txt832 - 115290) * 0.35 + 22563;
            }

            Txt839.Text = impuesto.ToString();
        }

        private void BtnEditarInfo3_Click(object sender, EventArgs e)
        {
            BtnAceptar3.Visible = true;
            Txt832.Visible = true;
            Txt839.Visible = true;
            Txt840.Visible = true;
            Txt845.Visible = true;
            Txt846.Visible = true;
            Txt855.Visible = true;
            Txt856.Visible = true;
            Txt859.Visible = true;
            Txt869.Visible = true;
            BtnEditarInfo3.Visible = false;
        }

        private void BtnAceptar3_Click(object sender, EventArgs e)
        {
            BtnEditarInfo3.Visible = true;
            Lbl832.Text = Txt832.Text;
            Lbl839.Text = Txt839.Text;
            Lbl840.Text = Txt840.Text;
            Lbl845.Text = Txt845.Text;
            Lbl846.Text = Txt846.Text;
            Lbl855.Text = Txt855.Text;
            Lbl856.Text = Txt856.Text;
            Lbl859.Text = Txt859.Text;
            Lbl869.Text = Txt869.Text;
            BtnAceptar3.Visible = false;

            Txt832.Visible = false;
            Txt839.Visible = false;
            Txt840.Visible = false;
            Txt845.Visible = false;
            Txt846.Visible = false;
            Txt855.Visible = false;
            Txt856.Visible = false;
            Txt859.Visible = false;
            Txt869.Visible = false;
        }

        private void Txt768_TextChanged(object sender, EventArgs e)
        {
            int txt768 = Convert.ToInt32(Txt768.Text) + Convert.ToInt32(Txt771.Text) + Convert.ToInt32(Txt772.Text) + Convert.ToInt32(Txt773.Text) + Convert.ToInt32(Txt774.Text) + Convert.ToInt32(Txt775.Text);
            Txt780.Text = txt768.ToString();
            int txt779 = Convert.ToInt32(Txt780.Text);
            Txt779.Text = txt779.ToString();
        }

        private void Txt771_TextChanged(object sender, EventArgs e)
        {
            int txt771 = Convert.ToInt32(Txt768.Text) + Convert.ToInt32(Txt771.Text) + Convert.ToInt32(Txt772.Text) + Convert.ToInt32(Txt773.Text) + Convert.ToInt32(Txt774.Text) + Convert.ToInt32(Txt775.Text);
            Txt780.Text = txt771.ToString();
            int txt779 = Convert.ToInt32(Txt780.Text);
            Txt779.Text = txt779.ToString();
        }

        private void Txt772_TextChanged(object sender, EventArgs e)
        {
            int txt772 = Convert.ToInt32(Txt768.Text) + Convert.ToInt32(Txt771.Text) + Convert.ToInt32(Txt772.Text) + Convert.ToInt32(Txt773.Text) + Convert.ToInt32(Txt774.Text) + Convert.ToInt32(Txt775.Text);
            Txt780.Text = txt772.ToString();
            int txt779 = Convert.ToInt32(Txt780.Text);
            Txt779.Text = txt779.ToString();
        }

        private void Txt773_TextChanged(object sender, EventArgs e)
        {
            int txt773 = Convert.ToInt32(Txt768.Text) + Convert.ToInt32(Txt771.Text) + Convert.ToInt32(Txt772.Text) + Convert.ToInt32(Txt773.Text) + Convert.ToInt32(Txt774.Text) + Convert.ToInt32(Txt775.Text);
            Txt780.Text = txt773.ToString();
            int txt779 = Convert.ToInt32(Txt780.Text);
            Txt779.Text = txt779.ToString();
        }

        private void Txt774_TextChanged(object sender, EventArgs e)
        {
            int txt774 = Convert.ToInt32(Txt768.Text) + Convert.ToInt32(Txt771.Text) + Convert.ToInt32(Txt772.Text) + Convert.ToInt32(Txt773.Text) + Convert.ToInt32(Txt774.Text) + Convert.ToInt32(Txt775.Text);
            Txt780.Text = txt774.ToString();
            int txt779 = Convert.ToInt32(Txt780.Text);
            Txt779.Text = txt779.ToString();
        }

        private void Txt775_TextChanged(object sender, EventArgs e)
        {
            int txt775 = Convert.ToInt32(Txt768.Text) + Convert.ToInt32(Txt771.Text) + Convert.ToInt32(Txt772.Text) + Convert.ToInt32(Txt773.Text) + Convert.ToInt32(Txt774.Text) + Convert.ToInt32(Txt775.Text);
            Txt780.Text = txt775.ToString();
            int txt779 = Convert.ToInt32(Txt780.Text);
            Txt779.Text = txt779.ToString();
        }

        private void Txt845_TextChanged(object sender, EventArgs e)
        {
            double txt845 = Convert.ToDouble(Txt839.Text) - Convert.ToInt32(Txt840.Text) - Convert.ToInt32(Txt845.Text) - Convert.ToInt32(Txt846.Text);
            if (txt845 > 0)
            {
                Txt855.Text = txt845.ToString();
                Txt859.Text = Txt855.Text;
            }
            else
            {
                Txt855.Text = 0.ToString();
                Txt856.Text = txt845.ToString();
                Txt869.Text = Txt856.Text;
            }
        }

        private void Txt840_TextChanged(object sender, EventArgs e)
        {
            double txt840 = Convert.ToDouble(Txt839.Text) - Convert.ToInt32(Txt840.Text) - Convert.ToInt32(Txt845.Text) - Convert.ToInt32(Txt846.Text);
            if (txt840 > 0)
            {
                Txt855.Text = txt840.ToString();
                Txt859.Text = Txt855.Text;
            }
            else
            {
                Txt855.Text = 0.ToString();
                Txt856.Text = txt840.ToString();
                Txt869.Text = Txt856.Text;
            }
            
        }

        private void Txt846_TextChanged(object sender, EventArgs e)
        {
            double txt846 = Convert.ToDouble(Txt839.Text) - Convert.ToInt32(Txt840.Text) - Convert.ToInt32(Txt845.Text) - Convert.ToInt32(Txt846.Text);
            if (txt846 > 0)
            {
                Txt855.Text = txt846.ToString();
                Txt859.Text = Txt855.Text;
            }
            else
            {
                Txt855.Text = 0.ToString();
                Txt856.Text = txt846.ToString();
                Txt869.Text = Txt856.Text;
            }
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
