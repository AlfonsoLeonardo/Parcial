using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Parcial_Alfonso
{
    public partial class Principal : Form
    {
        private List<Mago> listaMagoLocal;
        private List<HechizoMago> listahechizoMagosLocal;

        public Principal()
        {
            InitializeComponent();
        }
        private void cargarGrilla()
        {

            MagoNegocio magoNegocio = new MagoNegocio();
            HechizoMagoNegocio hechizoMagoNegocio = new HechizoMagoNegocio();
            Mago mago = new Mago();
         
            try
            {

                listaMagoLocal = magoNegocio.ListarMago();
                dgvMagos.DataSource = listaMagoLocal;
                mago=(Mago) dgvMagos.CurrentRow.DataBoundItem;
                dgvMagos.Columns[0].Visible = false;
               // listahechizoMagosLocal = hechizoMagoNegocio.ListarHechizoMago(mago.Id);
               // dgvhechizos.DataSource = listahechizoMagosLocal;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargahechizos(int id)
        {
            MagoNegocio magoNegocio = new MagoNegocio();
            HechizoMagoNegocio hechizoMagoNegocio = new HechizoMagoNegocio();

            listahechizoMagosLocal = hechizoMagoNegocio.ListarHechizoMago(id);
            dgvhechizos.DataSource = listahechizoMagosLocal;
            dgvhechizos.Columns[0].Visible = false;
            dgvhechizos.Columns[1].Visible = false;

        }
        private void dgvMagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mago mago = new Mago();
            mago=(Mago)dgvMagos.CurrentRow.DataBoundItem;
            cargahechizos(mago.Id);


        }

        private void AgregarHechizoMago_Click(object sender, EventArgs e)
        {
            Mago mago = new Mago();
            mago=(Mago)dgvMagos.CurrentRow.DataBoundItem;
            Agregar_Hechizo agregar_Hechizo = new Agregar_Hechizo(mago);
            agregar_Hechizo.ShowDialog();
        }

        private void txtbuscarmago_TextChanged(object sender, EventArgs e)
        {
            
                if (txtbuscarmago.Text == "")
                {
                    dgvMagos.DataSource = listaMagoLocal;
                }
                else
                {
                    if (txtbuscarmago.Text.Length >= 1)
                    {
                        List<Mago> lista;
                        lista = listaMagoLocal.FindAll(X => X.Nombre.Contains(txtbuscarmago.Text));
                        dgvMagos.DataSource = lista;

                    }
                }
            int xx = dgvMagos.RowCount;
            if (xx>1)
            {
                Mago mago = new Mago();
                mago = (Mago)dgvMagos.CurrentRow.DataBoundItem;
                cargahechizos(mago.Id);
            }
        }
    }
}
