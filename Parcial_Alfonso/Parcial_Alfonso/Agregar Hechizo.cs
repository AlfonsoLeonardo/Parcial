using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Parcial_Alfonso
{
    public partial class Agregar_Hechizo : Form
    {
        private Mago MagoL;
        public Agregar_Hechizo(Mago mago)
        {
            MagoL = mago;
            InitializeComponent();
        }

        private void Agregar_Hechizo_Load(object sender, EventArgs e)
        {
            HechizoNegocio hechizoNegocio = new HechizoNegocio();
            Hechizo hechizo = new Hechizo();
            txtNombreMago.Text = MagoL.Nombre.ToString();
            cboHechizos.DataSource = hechizoNegocio.ListarHechizo();
            cboHechizos.DisplayMember = "Nombre"; //Nombre de la varible a mostrar en pantalla
            cboHechizos.ValueMember = "Id";// nobre de la variable del id a mostar
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HechizoNegocio hechizoNegocio = new HechizoNegocio();
            HechizoMago hechizo = new HechizoMago();



            hechizo.hechizo = (Hechizo)cboHechizos.SelectedItem;
            hechizo.mago = MagoL;
            hechizoNegocio.agregarHechizo(hechizo);
            this.Close();


        }
    }
}
