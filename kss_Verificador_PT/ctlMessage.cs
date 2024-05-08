using System;
using System.Drawing;
using System.Windows.Forms;

namespace kss_Verificador_PT
{
    public partial class ctlMessage : UserControl
    {
        private int SegundosTransc;
        private int SegundoMaximo = 1;
        private bool isModal;

        public enum enuTipoMsj
        {
            Default = 0,
            Help,
            Informacion,
            Cuidado,
            Error
        }

        public ctlMessage(string Message, enuTipoMsj tipoMsj, string titulo = "Mensaje Aplicación")
        {
            InitializeComponent();
            this.Message = Message;
            this.TipoMsj = tipoMsj;
            this.Titulo = titulo;
        }
        private string Message { get; set; }
        private string Titulo { get; set; }
        private enuTipoMsj TipoMsj
        {
            set
            {
                switch (value)
                {
                    case enuTipoMsj.Cuidado:
                        this.imgMsj.Image = global::kss_Verificador_PT.Properties.Resources.messagebox_warning;
                        this.BackColor = Color.DarkOrange;
                        break;
                    case enuTipoMsj.Default:
                        this.imgMsj.Image = global::kss_Verificador_PT.Properties.Resources.kssLogo;
                        this.BackColor = Color.DarkSlateGray;
                        break;
                    case enuTipoMsj.Error:
                        this.imgMsj.Image = global::kss_Verificador_PT.Properties.Resources.messagebox_critical;
                        this.BackColor = Color.DarkRed;
                        break;
                    case enuTipoMsj.Help:
                        this.imgMsj.Image = global::kss_Verificador_PT.Properties.Resources.messagebox_help;
                        this.BackColor = Color.DarkSlateBlue;
                        break;
                    case enuTipoMsj.Informacion:
                        this.imgMsj.Image = global::kss_Verificador_PT.Properties.Resources.messagebox_info;
                        this.BackColor = Color.DarkGreen;
                        break;
                }
                Header.BackColor = this.BackColor;
            }
        }

        public Form FrmContext { get; private set; }
        public Control Contenedor { get; private set; }

        private void ctlMessage_Load(object sender, EventArgs e)
        {
            lblMsj.Text = Message;
            lblTitulo.Text = Titulo;
            timer1.Start();
            btnOK.BackColor = this.BackColor;

        }


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        public void Show(Form frmContext, Control contenedor, bool esModal = true)
        {
            this.FrmContext = frmContext;
            this.Contenedor = contenedor != null ? contenedor : frmContext;
            this.isModal = esModal;
            Location = frmContext != null ? new Point((frmContext.Width / 2) - (this.Width / 2), (frmContext.Height / 2) - (this.Height / 2)) :
                   (Contenedor != null ? new Point((Contenedor.Width / 2) - (this.Width / 2), (Contenedor.Height / 2) - (this.Height / 2)) : new Point(0, 0));
            if (Contenedor != null && esModal)
                Contenedor.Visible = false;

            if (frmContext != null)
                frmContext.Controls.Add(this);
            else
                Contenedor.Controls.Add(this);
            this.Visible = true;

            BringToFront();

        }
        private void ctlMessage_VisibleChanged(object sender, EventArgs e)
        {
            if (Contenedor != null && isModal)
                Contenedor.Visible = !this.Visible;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SegundosTransc == SegundoMaximo)
            {
                this.Visible = false;
                timer1.Stop();
            }
            else
            {
                SegundosTransc++;
                lbltimer.Text = (SegundoMaximo - SegundosTransc).ToString();
            }
        }
    }
}
