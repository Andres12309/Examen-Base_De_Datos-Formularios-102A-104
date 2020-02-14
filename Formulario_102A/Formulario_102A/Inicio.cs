using Npgsql;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        //NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5048; User Id=postgres;Password=1234;Database = Usuarios");

        public void login()
        {

        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            bool blnfound = false;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=1234; Database=Login");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from usuarios where cedula='" + TxtCi.Text + "' and contra='" + TxtContra.Text + "'", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                blnfound = true;
                this.Hide();
                FrmFormularios fr = new FrmFormularios();
                fr.FormClosed += (s, args) => this.Close();
                fr.Show();
            }
            if (blnfound == false)
                MessageBox.Show("EL NOMBRE O LA CONTRASEÑA SON INCORRECTOS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            dr.Close();
            conn.Close();
        }
    }
}
