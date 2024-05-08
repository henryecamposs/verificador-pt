namespace kss_Verificador_PT
{
    class clsDatosProducto
    {
        private double precioTotal;
        private double precioIva;
        private double tasaIva;
        private bool esExcento;
        private double precioBase;
        

        public clsDatosProducto(string descripcion, double preciototal, double tasa)
        {
            Descripcion = descripcion;
            precioTotal = preciototal;
            tasaIva = tasa;
            esExcento = TasaIva==0?true:false;
            if (!esExcento)
            {
                precioBase = precioTotal / (1 + (tasa / 100));
                PrecioIva = precioTotal - precioBase;
            }
            else
            {
                precioIva = 0;
                PrecioBase = precioTotal;
            }
        }
        public double PrecioIva { get => precioIva; set => precioIva = value; }
        public double TasaIva { get => tasaIva; set => tasaIva = value; }
        public bool EsExcento { get => esExcento; set => esExcento = value; }
        public double PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public double PrecioBase { get => precioBase; set => precioBase = value; }
        public string Descripcion { get; internal set; }
    }
}
