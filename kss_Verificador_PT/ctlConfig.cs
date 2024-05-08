using System;
using System.IO;
using System.Windows.Forms;

namespace kss_Verificador_PT
{
    public partial class ctlConfig : UserControl
    {
        public ctlConfig()
        {
            InitializeComponent();
        }


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        string dirlocal = "c:\\kss\\data";
        private void button2_Click(object sender, EventArgs e)
        {
            //Guardar datos
            Program.DatosConfiguracion.DirDatosServer = txtDirDatos.Text;
            Program.DatosConfiguracion.DirDatosLocal = string.IsNullOrEmpty(lblDirLocal.Text) ? dirlocal : lblDirLocal.Text;
            Program.DatosConfiguracion.IsOnline = rdOnline.Value;
            Program.DatosConfiguracion.EsPorCodigo = rdCodigo.Value;
            Program.DatosConfiguracion.EsPorCodigobarra = rdcodBarra.Value;
            Program.DatosConfiguracion.EsPorDescripcion = rdDescripcion.Value;
            Program.DatosConfiguracion.saveConfig();

            this.Visible = false;
        }

        private void ctlConfig_Load(object sender, EventArgs e)
        {
            ctlConfig_VisibleChanged(sender, e);
        }

        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            //Sincronizar datos Locales
            //Copiar datos de servidor a maquina local
            if (!Directory.Exists(Program.DatosConfiguracion.DirDatosLocal))
                Directory.CreateDirectory(Program.DatosConfiguracion.DirDatosLocal);
            if (File.Exists(Program.DatosConfiguracion.DirDatosServer + "\\invenc.dbf"))
                File.Copy(Program.DatosConfiguracion.DirDatosServer + "\\invenc.dbf", Program.DatosConfiguracion.DirDatosLocal + "\\invenc.dbf", true);

            if (File.Exists(Program.DatosConfiguracion.DirDatosServer + "\\tax.dbf"))
                File.Copy(Program.DatosConfiguracion.DirDatosServer + "\\tax.dbf", Program.DatosConfiguracion.DirDatosLocal + "\\tax.dbf", true);
            Program.DatosConfiguracion.saveConfig();
            lblCnn.Text = Program.DatosConfiguracion.CnnString;
        }

        private void rdcodBarra_Click(object sender, EventArgs e)

        {
            //Checked
            OpcionCodigo opcionCodigo = (OpcionCodigo)Convert.ToInt16(((Bunifu.Framework.UI.BunifuiOSSwitch)sender).Tag);
            Program.DatosConfiguracion.EsPorCodigobarra = rdcodBarra.Value = false;
            Program.DatosConfiguracion.EsPorCodigo = rdCodigo.Value = false;
            Program.DatosConfiguracion.EsPorDescripcion = rdDescripcion.Value = false;
            switch (opcionCodigo)
            {
                case OpcionCodigo.barra:
                    Program.DatosConfiguracion.EsPorCodigobarra = true;
                    break;
                case OpcionCodigo.codigo:
                    Program.DatosConfiguracion.EsPorCodigo = true;
                    break;
                case OpcionCodigo.descripcion:
                    Program.DatosConfiguracion.EsPorDescripcion = true;
                    break;
            }
            ((Bunifu.Framework.UI.BunifuiOSSwitch)sender).Value = true;
        }

        private void rdOnline_Click(object sender, EventArgs e)
        {
            int opcionCodigo = Convert.ToInt16(((Bunifu.Framework.UI.BunifuiOSSwitch)sender).Tag);
            rdOnline.Value = false;
            rdOffline.Value = false;
            Program.DatosConfiguracion.IsOnline = opcionCodigo == 0 ? true : false;
            ((Bunifu.Framework.UI.BunifuiOSSwitch)sender).Value = true;
        }

        private void lblDirLocal_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void ctlConfig_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Program.DatosConfiguracion.readConfig();
                txtDirDatos.Text = Program.DatosConfiguracion.DirDatosServer;
                lblDirLocal.Text = Program.DatosConfiguracion.DirDatosLocal;
                rdcodBarra.Value = Program.DatosConfiguracion.EsPorCodigobarra;
                rdCodigo.Value = Program.DatosConfiguracion.EsPorCodigo;
                rdDescripcion.Value = Program.DatosConfiguracion.EsPorDescripcion;
                rdOnline.Value = Program.DatosConfiguracion.IsOnline;
                rdOffline.Value = !Program.DatosConfiguracion.IsOnline;
                lblCnn.Text = Program.DatosConfiguracion.CnnString;
            }
        }

        private void rdOffline_OnValueChange(object sender, EventArgs e)
        {
            btnSincronizar.Visible = rdOffline.Value;
        }
    }
    enum OpcionCodigo : int
    {
        barra,
        codigo,
        descripcion
    }

}
