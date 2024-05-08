namespace kss_Verificador_PT
{
    partial class ctlMain
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescrProducto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLabelBuscar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtCodigoBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLabelPrecioIVA = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPrecioBase = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPrecioIVA = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPrecioTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsPpal = new kss_Verificador_PT.dsPpal();
            this.invencBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invencTableAdapter = new kss_Verificador_PT.dsPpalTableAdapters.invencTableAdapter();
            this.tableAdapterManager = new kss_Verificador_PT.dsPpalTableAdapters.TableAdapterManager();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPpal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invencBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 768);
            this.panel2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblDescrProducto, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLabelBuscar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.47917F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01563F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.072917F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.69271F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 768);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblDescrProducto
            // 
            this.lblDescrProducto.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDescrProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescrProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrProducto.ForeColor = System.Drawing.Color.White;
            this.lblDescrProducto.Location = new System.Drawing.Point(221, 309);
            this.lblDescrProducto.Name = "lblDescrProducto";
            this.lblDescrProducto.Size = new System.Drawing.Size(800, 61);
            this.lblDescrProducto.TabIndex = 5;
            this.lblDescrProducto.Text = "DESCRIPCION DEL PRODUCTO";
            this.lblDescrProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLabelBuscar
            // 
            this.lblLabelBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelBuscar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblLabelBuscar.Location = new System.Drawing.Point(3, 187);
            this.lblLabelBuscar.Name = "lblLabelBuscar";
            this.lblLabelBuscar.Size = new System.Drawing.Size(212, 122);
            this.lblLabelBuscar.TabIndex = 4;
            this.lblLabelBuscar.Text = "Indique {0}:";
            this.lblLabelBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.txtCodigoBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(221, 190);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(800, 116);
            this.panel1.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageActive = null;
            this.btnOK.Location = new System.Drawing.Point(719, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 96);
            this.btnOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOK.TabIndex = 1;
            this.btnOK.TabStop = false;
            this.btnOK.Zoom = 10;
            this.btnOK.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txtCodigoBuscar
            // 
            this.txtCodigoBuscar.BackColor = System.Drawing.Color.White;
            this.txtCodigoBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoBuscar.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.txtCodigoBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoBuscar.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigoBuscar.HintText = "";
            this.txtCodigoBuscar.isPassword = false;
            this.txtCodigoBuscar.LineFocusedColor = System.Drawing.Color.DarkSlateBlue;
            this.txtCodigoBuscar.LineIdleColor = System.Drawing.Color.DarkSlateBlue;
            this.txtCodigoBuscar.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtCodigoBuscar.LineThickness = 9;
            this.txtCodigoBuscar.Location = new System.Drawing.Point(10, 10);
            this.txtCodigoBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBuscar.Name = "txtCodigoBuscar";
            this.txtCodigoBuscar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.txtCodigoBuscar.Size = new System.Drawing.Size(780, 96);
            this.txtCodigoBuscar.TabIndex = 2;
            this.txtCodigoBuscar.Text = "0000";
            this.txtCodigoBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoBuscar.Enter += new System.EventHandler(this.txtCodigoBuscar_Enter);
            this.txtCodigoBuscar.Leave += new System.EventHandler(this.txtCodigoBuscar_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(221, 373);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(800, 392);
            this.panel3.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.50633F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.49367F));
            this.tableLayoutPanel2.Controls.Add(this.bunifuCustomLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLabelPrecioIVA, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bunifuCustomLabel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblPrecioBase, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPrecioIVA, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPrecioTotal, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(790, 382);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(235, 114);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Precio Base:";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLabelPrecioIVA
            // 
            this.lblLabelPrecioIVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelPrecioIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelPrecioIVA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblLabelPrecioIVA.Location = new System.Drawing.Point(3, 114);
            this.lblLabelPrecioIVA.Name = "lblLabelPrecioIVA";
            this.lblLabelPrecioIVA.Size = new System.Drawing.Size(235, 114);
            this.lblLabelPrecioIVA.TabIndex = 7;
            this.lblLabelPrecioIVA.Text = "Precio IVA {0}";
            this.lblLabelPrecioIVA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 228);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(235, 154);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Precio TOTAL:";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrecioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioBase.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPrecioBase.Location = new System.Drawing.Point(244, 0);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(543, 114);
            this.lblPrecioBase.TabIndex = 8;
            this.lblPrecioBase.Text = "999.999.999,00";
            this.lblPrecioBase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecioIVA
            // 
            this.lblPrecioIVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrecioIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioIVA.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPrecioIVA.Location = new System.Drawing.Point(244, 114);
            this.lblPrecioIVA.Name = "lblPrecioIVA";
            this.lblPrecioIVA.Size = new System.Drawing.Size(543, 114);
            this.lblPrecioIVA.TabIndex = 9;
            this.lblPrecioIVA.Text = "999.999.999,00";
            this.lblPrecioIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPrecioTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.ForeColor = System.Drawing.Color.White;
            this.lblPrecioTotal.Location = new System.Drawing.Point(241, 228);
            this.lblPrecioTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(549, 154);
            this.lblPrecioTotal.TabIndex = 10;
            this.lblPrecioTotal.Text = "999.999.999,00";
            this.lblPrecioTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(221, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 181);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::kss_Verificador_PT.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(203, 3);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(500, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dsPpal
            // 
            this.dsPpal.DataSetName = "dsPpal";
            this.dsPpal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invencBindingSource
            // 
            this.invencBindingSource.DataMember = "invenc";
            this.invencBindingSource.DataSource = this.dsPpal;
            // 
            // invencTableAdapter
            // 
            this.invencTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.taxTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kss_Verificador_PT.dsPpalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ctlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ctlMain";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.ctlMain_Load);
            this.VisibleChanged += new System.EventHandler(this.ctlMain_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctlMain_KeyDown);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPpal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invencBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLabelBuscar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoBuscar;
        private Bunifu.Framework.UI.BunifuImageButton btnOK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescrProducto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLabelPrecioIVA;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrecioBase;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrecioIVA;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrecioTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private dsPpal dsPpal;
        private System.Windows.Forms.BindingSource invencBindingSource;
        private dsPpalTableAdapters.invencTableAdapter invencTableAdapter;
        private dsPpalTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
