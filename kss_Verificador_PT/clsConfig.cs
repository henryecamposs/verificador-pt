using System;
using System.Configuration;

namespace kss_Verificador_PT
{
    class clsConfig
    {
        private string dirDatosServer;
        private string dirDatosLocal;
        private bool isOnline;
        private bool esPorCodigobarra;
        private bool esPorDescripcion;
        private bool esPorCodigo;
        private bool esLicenciaActiva;
        private string SerialLicencia;
        private string codigoActivacionLicencia;
        private string cnnString;


        public string DirDatosServer { get => dirDatosServer; set => dirDatosServer = value; }
        public bool IsOnline { get => isOnline; set => isOnline = value; }
        public bool EsPorCodigobarra { get => esPorCodigobarra; set => esPorCodigobarra = value; }
        public bool EsPorDescripcion { get => esPorDescripcion; set => esPorDescripcion = value; }
        public bool EsPorCodigo { get => esPorCodigo; set => esPorCodigo = value; }
        public bool EsLicenciaActiva { get => esLicenciaActiva; set => esLicenciaActiva = value; }
        public string SerialLicencia1 { get => SerialLicencia; set => SerialLicencia = value; }
        public string CodigoActivacionLicencia { get => codigoActivacionLicencia; set => codigoActivacionLicencia = value; }

        private string cadenaConexionTemplate = "Provider=VFPOLEDB.1;Data Source={0}";

        public string DirDatosLocal { get => dirDatosLocal; set => dirDatosLocal = value; }
        public string CnnString { get => cnnString; set => cnnString = value; }
        public bool isConfigOK { get; internal set; }

        public clsConfig()
        {

        }

        private void getConnectionStringConfig_cnnstringName(string cnnstringName)
        {
            Configuration appconfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringSettings connStringSettings = appconfig.ConnectionStrings.ConnectionStrings[cnnstringName];
            cnnString = connStringSettings!=null? connStringSettings.ConnectionString:"";
        }

        private void saveConnectionStringConfig(string connectionStringName)
        {
            cnnString = isOnline ? string.Format(cadenaConexionTemplate, DirDatosServer) : string.Format(cadenaConexionTemplate, DirDatosLocal);
            Configuration appconfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            appconfig.ConnectionStrings.ConnectionStrings[connectionStringName].ConnectionString = cnnString;
            appconfig.Save();
        }
        public bool saveConfig()
        {
            try
            {
                Properties.Settings.Default.dirDatosServer = DirDatosServer;
                Properties.Settings.Default.dirDatosLocal = DirDatosLocal;
                Properties.Settings.Default.isOnline = IsOnline;
                Properties.Settings.Default.esPorCodigobarra = EsPorCodigobarra;
                Properties.Settings.Default.esPorDescripcion = EsPorDescripcion;
                Properties.Settings.Default.esPorCodigo = EsPorCodigo;
                Properties.Settings.Default.esLicenciaActiva = EsLicenciaActiva;
                Properties.Settings.Default.SerialLicencia = SerialLicencia;
                Properties.Settings.Default.CodigoActivacionLicencia = CodigoActivacionLicencia;
                Properties.Settings.Default.isConfigOK= isConfigOK= true;
                saveConnectionStringConfig("kss_Verificador_PT.Properties.Settings.ConnectionString");

                Properties.Settings.Default.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool readConfig()
        {
            try
            {
                DirDatosServer = Properties.Settings.Default.dirDatosServer;
                DirDatosLocal = Properties.Settings.Default.dirDatosLocal;
                IsOnline = Properties.Settings.Default.isOnline;
                EsPorCodigobarra = Properties.Settings.Default.esPorCodigobarra;
                EsPorDescripcion = Properties.Settings.Default.esPorDescripcion;
                EsPorCodigo = Properties.Settings.Default.esPorCodigo;
                EsLicenciaActiva = Properties.Settings.Default.esLicenciaActiva;
                SerialLicencia = Properties.Settings.Default.SerialLicencia;
                isConfigOK = Properties.Settings.Default.isConfigOK;
                CodigoActivacionLicencia = Properties.Settings.Default.CodigoActivacionLicencia;
                //cnnString
                getConnectionStringConfig_cnnstringName("kss_Verificador_PT.Properties.Settings.ConnectionString");

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
