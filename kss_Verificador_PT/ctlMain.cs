using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace kss_Verificador_PT
{
    public partial class ctlMain : UserControl
    {
        public ctlMain()
        {
            InitializeComponent();
        }
        string LabelBuscar = "Indique {0}:";
        public event EventHandler message;
        protected virtual void onMessage(Object button, EventArgs e) => message?.Invoke(button, e);
        private void ctlMain_Load(object sender, EventArgs e)
        {
            LimpiarDatos();
            txtCodigoBuscar.Focus();
        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        internal void MostrarDatos()
        {
            Program.DatosConfiguracion.readConfig();
            dsPpalTableAdapters.taxTableAdapter taxTableAdapter = new dsPpalTableAdapters.taxTableAdapter();
            OleDbConnection cnn = new OleDbConnection(Program.DatosConfiguracion.CnnString);
            invencTableAdapter.Connection = cnn;
            taxTableAdapter.Connection = cnn;
            try
            {
                //Buscar Iva en tax
                double tasa = 0;
                DataRow row = null;
                if (Program.DatosConfiguracion.EsPorCodigobarra)
                    row = invencTableAdapter.GetDataByBarra(txtCodigoBuscar.Text).Rows.Count > 0 ? invencTableAdapter.GetDataByBarra(txtCodigoBuscar.Text).Rows[0] : null;
                else if (Program.DatosConfiguracion.EsPorCodigo)
                {
                    string buscar = "%" + txtCodigoBuscar.Text.ToUpper();
                    row = invencTableAdapter.GetDataByCodigo(buscar).Rows.Count > 0 ? invencTableAdapter.GetDataByCodigo(buscar).Rows[0] : null;
                }
                else if (Program.DatosConfiguracion.EsPorDescripcion)
                {
                    string buscar = "%" + txtCodigoBuscar.Text.ToUpper() + "%";
                    row = invencTableAdapter.GetDataByDescr(buscar).Rows.Count > 0 ? invencTableAdapter.GetDataByDescr(buscar).Rows[0] : null;
                }

                if (row != null)
                {
                    double precioTotal = string.IsNullOrEmpty(row["precio"].ToString()) ? 0 : Convert.ToDouble(row["precio"]);
                    int tipoIva = string.IsNullOrEmpty(row["tiva"].ToString()) ? 0 : Convert.ToInt16(row["tiva"]);

                    DataTable table = taxTableAdapter.GetDataBy(tipoIva);
                    if (table.Rows.Count >= 1)
                        tasa = Convert.ToDouble(table.Rows[0]["valor"]);

                    //Asignar datos
                    clsDatosProducto datosProducto = new clsDatosProducto(row["descr"].ToString(), precioTotal, tasa);
                    lblPrecioBase.Text = datosProducto.PrecioBase.ToString("0.00");
                    lblDescrProducto.Text = datosProducto.Descripcion;
                    lblLabelPrecioIVA.Text = string.Format("Precio IVA {0:0.00}", tasa);
                    lblPrecioIVA.Text = !datosProducto.EsExcento ? datosProducto.PrecioIva.ToString("0.00") : "* PRODUCTO EXCENTO *";
                    lblPrecioTotal.Text = datosProducto.PrecioTotal.ToString("0.00");
                }
                else
                {
                    //Buscar producto
                    new ctlMessage("Producto no Encontrado", ctlMessage.enuTipoMsj.Error).Show(this.ParentForm, this);
                    LimpiarDatos();
                }
            }
            catch (Exception ex)
            {
                new ctlMessage(ex.Message, ctlMessage.enuTipoMsj.Error).Show(this.ParentForm, this);
            }
            finally
            {
                txtCodigoBuscar.Focus();
                txtCodigoBuscar.Text = "";
            }


        }
        private void LimpiarDatos()
        {
            lblPrecioBase.Text = "0,00";
            lblDescrProducto.Text = "";
            lblLabelPrecioIVA.Text = "Precio IVA:";
            lblPrecioIVA.Text = "0,00";
            lblPrecioTotal.Text = "0,00";
            txtCodigoBuscar.Text = "";
            txtCodigoBuscar.Focus();
            if (Program.DatosConfiguracion.EsPorDescripcion)
                lblLabelBuscar.Text = string.Format(LabelBuscar, "Descr.");
            if (Program.DatosConfiguracion.EsPorCodigo)
                lblLabelBuscar.Text = string.Format(LabelBuscar, "Código");
            if (Program.DatosConfiguracion.EsPorCodigobarra)
                lblLabelBuscar.Text = string.Format(LabelBuscar, "Barra");

        }
        private void ctlMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    MostrarDatos();
                    break;
            }
        }

        private void ctlMain_VisibleChanged(object sender, EventArgs e)
        {
            LimpiarDatos();
            if (Visible)
                txtCodigoBuscar.Focus();
        }

        private void txtCodigoBuscar_Leave(object sender, EventArgs e)
        {
            txtCodigoBuscar.BackColor = Color.White;
        }

        private void txtCodigoBuscar_Enter(object sender, EventArgs e)
        {
            txtCodigoBuscar.BackColor = Color.LightYellow;
        }
    }
}
