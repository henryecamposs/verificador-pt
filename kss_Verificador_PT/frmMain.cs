using System;
using System.Drawing;
using System.Windows.Forms;

namespace kss_Verificador_PT
{
    public partial class frmMain : Form
    {
        ctlConfig ctlConfig;
        ctlMain ctlMain;
        bool isConfigOK;
        public frmMain()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Salir de Aplicación?", "Exit Aplication", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
                Application.Exit();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Show Oprions
            MostrarConfig(true);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ctlConfig = new ctlConfig();
            ctlMain = new ctlMain() { Dock = DockStyle.Fill };

            ctlConfig.VisibleChanged += CtlConfig_VisibleChanged;
            ctlMain.VisibleChanged += CtlMain_VisibleChanged;

            panelMain.Controls.Add(ctlMain);
            
            if (Program.DatosConfiguracion.isConfigOK)
                ctlMain.Visible = true;
            else
                MostrarConfig(true);
            btnMenu.BringToFront();
        }


        private void CtlMain_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void CtlConfig_VisibleChanged(object sender, EventArgs e)
        {
            if (!((Control)sender).Visible)
                MostrarConfig(false);
        }

        private void MostrarConfig(bool Mostrar)
        {
            if (ctlConfig == null)
                ctlConfig = new ctlConfig();
            if (Mostrar)
            {
                if (!this.Controls.Contains(ctlConfig))
                    this.Controls.Add(ctlConfig);
                ctlConfig.Location = new Point(btnMenu.Left - ctlConfig.Width, btnMenu.Top);
                ctlConfig.Visible = true;
                ctlConfig.BringToFront();
            }
            btnMenu.Visible = !ctlConfig.Visible;
            if (ctlMain != null)
                ctlMain.Visible = btnMenu.Visible;
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (ctlMain != null)
                    {
                       if(ctlMain.Visible) ctlMain.MostrarDatos();
                    }
                    break;
            }

        }
    }
}
