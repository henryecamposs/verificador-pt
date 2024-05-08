namespace kss_Verificador_PT
{
    partial class ctlMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlMessage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMsj = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgMsj = new Bunifu.Framework.UI.BunifuImageButton();
            this.Header = new System.Windows.Forms.Panel();
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnOK = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltimer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMsj)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 280);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.85388F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.14612F));
            this.tableLayoutPanel1.Controls.Add(this.lblMsj, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.imgMsj, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(657, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMsj
            // 
            this.lblMsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsj.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMsj.Location = new System.Drawing.Point(185, 0);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(469, 280);
            this.lblMsj.TabIndex = 4;
            this.lblMsj.Text = "Producto no existe";
            this.lblMsj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgMsj
            // 
            this.imgMsj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imgMsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgMsj.Image = global::kss_Verificador_PT.Properties.Resources.kssLogo;
            this.imgMsj.ImageActive = null;
            this.imgMsj.Location = new System.Drawing.Point(3, 3);
            this.imgMsj.Name = "imgMsj";
            this.imgMsj.Size = new System.Drawing.Size(176, 274);
            this.imgMsj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMsj.TabIndex = 0;
            this.imgMsj.TabStop = false;
            this.imgMsj.Zoom = 10;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Header.Controls.Add(this.lblTitulo);
            this.Header.Controls.Add(this.btnOK);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(5, 5);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(5);
            this.Header.Size = new System.Drawing.Size(657, 38);
            this.Header.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(5, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 28);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Mensaje";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageActive = null;
            this.btnOK.Location = new System.Drawing.Point(625, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(27, 28);
            this.btnOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOK.TabIndex = 3;
            this.btnOK.TabStop = false;
            this.btnOK.Zoom = 10;
            this.btnOK.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltimer
            // 
            this.lbltimer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbltimer.Location = new System.Drawing.Point(614, 295);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(40, 19);
            this.lbltimer.TabIndex = 8;
            this.lbltimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctlMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.Name = "ctlMessage";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(667, 328);
            this.Load += new System.EventHandler(this.ctlMessage_Load);
            this.VisibleChanged += new System.EventHandler(this.ctlMessage_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgMsj)).EndInit();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
        private Bunifu.Framework.UI.BunifuImageButton btnOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuImageButton imgMsj;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMsj;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltimer;
    }
}
