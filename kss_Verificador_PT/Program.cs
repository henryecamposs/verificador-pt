using System;
using System.Management;
using System.Windows.Forms;

namespace kss_Verificador_PT
{
    static class Program
    {

        internal static clsConfig DatosConfiguracion;
        internal static DateTime LastDate;
        internal static DateTime LastDateUSe;
        internal static bool isActive;
        internal static string KeyClave;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Cargar configuracion
            DatosConfiguracion = new clsConfig();
            DatosConfiguracion.readConfig();
            //verificar licencia
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            KeyClave = GetHardDiskSerialNo();

            string decryptLastDate = encryptHelper.dencryptus(Properties.Settings.Default.LastDate, KeyClave);
            string decryptLastDateUSe = encryptHelper.dencryptus(Properties.Settings.Default.LastDateUSe, KeyClave);
            string decryptisActive = encryptHelper.dencryptus(Properties.Settings.Default.isActive, KeyClave);
            //verificar que el dato sea el dafault

            LastDate = isDate(decryptLastDate) ? Convert.ToDateTime(decryptLastDate) : new DateTime(2019, 01, 01);
            LastDateUSe = isDate(decryptLastDateUSe) ? Convert.ToDateTime(decryptLastDateUSe) : new DateTime(2019, 01, 01);
            isActive = isBool(decryptisActive) ? Convert.ToBoolean(decryptisActive) : false;

            if (LastDate <= LastDateUSe)
                if (DateTime.Now < new DateTime(2020, 01, 01))
                {
                    if (isActive)
                    {
                        Application.Run(new frmMain());
                    }
                    else
                    {
                        if (new frmSerial() { StartPosition= FormStartPosition.CenterScreen}.ShowDialog() == DialogResult.OK)
                        {
                            Application.Run(new frmMain());
                        }
                    }

                }
        }
        private static bool isDate(string strDate)
        {
            bool blnIsDate = false;
            try
            {
                DateTime myDateTime = DateTime.Parse(strDate);
                blnIsDate = true;
            }
            catch { }
            return (blnIsDate);
        }
        private static bool isBool(string str)
        {
            bool blnIsDate = false;
            try
            {
                bool myDateTime = Convert.ToBoolean(str);
                blnIsDate = true;
            }
            catch { }
            return (blnIsDate);
        }
        public static string GetHardDiskSerialNo()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["VolumeSerialNumber"]);
            }
            return result;
        }
    }
}
