using System;
using System.Windows.Forms;

namespace kss_Verificador_PT
{
    public partial class frmSerial : Form
    {
        private string codigoActivacion;
        private string _Serial;
        private string Serial
        {
            get
            {
                _Serial =
                       ((DateTime.Now.Ticks * DateTime.Now.Millisecond / 2) * (-1)).ToString().Substring(0, 5) + "-" +
                       ((DateTime.Now.Ticks * DateTime.Now.Second / 4) * (-1)).ToString().Substring(3, 5) + "-" +
                       ((DateTime.Now.Ticks * DateTime.Now.Minute / 6) * (-1)).ToString().Substring(4, 5);
                if (_Serial.Length < 17 || _Serial.StartsWith("-"))
                    return Serial;
                
                return _Serial;
            }

        }

        public frmSerial()
        {
            InitializeComponent();

            //this.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //posicion 1-2  digitos
            //posicion 8-2  digitos
            //posicion 13-2 digitos
            codigoActivacion = (_Serial.ToString().Substring(1, 2) + _Serial.ToString().Substring(8, 2) + _Serial.ToString().Substring(13, 2));
            if (textBox1.Text.Equals(codigoActivacion))
            {
                DialogResult = DialogResult.OK;
                //crear archivo
                kss_Verificador_PT.Properties.Settings.Default.isActive =encryptHelper.encryptus( true.ToString(),Program.KeyClave);
                kss_Verificador_PT.Properties.Settings.Default.LastDate = encryptHelper.encryptus(DateTime.Now.ToString(), Program.KeyClave);
                kss_Verificador_PT.Properties.Settings.Default.LastDateUSe = encryptHelper.encryptus(DateTime.Now.ToString(), Program.KeyClave);
                kss_Verificador_PT.Properties.Settings.Default.serialActivacion = encryptHelper.encryptus(_Serial, Program.KeyClave);
                kss_Verificador_PT.Properties.Settings.Default.KeyClave = encryptHelper.encryptus(Program.KeyClave, Program.KeyClave);

            }
            else
            {
                MessageBox.Show("Codigo Inválido");
                DialogResult = DialogResult.Cancel;
                kss_Verificador_PT.Properties.Settings.Default.isActive = encryptHelper.encryptus(false.ToString(),Properties.Settings.Default.serialActivacion);
            }
            kss_Verificador_PT.Properties.Settings.Default.Save();
        }

        private void frmSerial_Load(object sender, EventArgs e)
        {
            //ksslib.clsUtilForms _clsUtilForm = new ksslib.clsUtilForms(this);
            //base.MouseMove += _clsUtilForm.Me_MouseMove;
            //base.MouseDown += _clsUtilForm.Me_MouseDown;
            //this.label1.MouseMove += _clsUtilForm.Me_MouseMove;
            //this.label1.MouseDown += _clsUtilForm.Me_MouseDown;
            label1.Text = Serial;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
