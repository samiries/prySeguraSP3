namespace prySeguraSP3
{
    partial class SistemaRepuestos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaRepuestos));
            cmbmarca = new ComboBox();
            cmborigen = new ComboBox();
            txtnumero = new TextBox();
            txtdescripcion = new TextBox();
            txtprecio = new TextBox();
            btnguardar = new Button();
            cmbmarcabuscar = new ComboBox();
            cmborigenbuscar = new ComboBox();
            btnbuscar = new Button();
            lblmarcaguardar = new Label();
            lblorigenguardar = new Label();
            lblmarcabuscar = new Label();
            lblorigenbuscar = new Label();
            lblnum = new Label();
            lbldesc = new Label();
            lblprecio = new Label();
            Lstresultado = new ListBox();
            SuspendLayout();
            // 
            // cmbmarca
            // 
            cmbmarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbmarca.FormattingEnabled = true;
            cmbmarca.Items.AddRange(new object[] { "P", "F", "R" });
            cmbmarca.Location = new Point(73, 36);
            cmbmarca.Name = "cmbmarca";
            cmbmarca.Size = new Size(121, 23);
            cmbmarca.TabIndex = 0;
            // 
            // cmborigen
            // 
            cmborigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmborigen.FormattingEnabled = true;
            cmborigen.Items.AddRange(new object[] { "N", "I" });
            cmborigen.Location = new Point(73, 91);
            cmborigen.Name = "cmborigen";
            cmborigen.Size = new Size(121, 23);
            cmborigen.TabIndex = 1;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(254, 36);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(100, 23);
            txtnumero.TabIndex = 2;
            txtnumero.TextChanged += txtnumero_TextChanged;
            txtnumero.KeyPress += txtnumero_KeyPress;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(254, 81);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(100, 23);
            txtdescripcion.TabIndex = 3;
            txtdescripcion.TextChanged += txtdescripcion_TextChanged;
            txtdescripcion.KeyPress += txtdescripcion_KeyPress;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(254, 133);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(100, 23);
            txtprecio.TabIndex = 4;
            txtprecio.TextChanged += txtprecio_TextChanged;
            txtprecio.KeyPress += txtprecio_KeyPress;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(414, 64);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 5;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // cmbmarcabuscar
            // 
            cmbmarcabuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbmarcabuscar.FormattingEnabled = true;
            cmbmarcabuscar.Items.AddRange(new object[] { "P", "F", "R\t\t" });
            cmbmarcabuscar.Location = new Point(73, 209);
            cmbmarcabuscar.Name = "cmbmarcabuscar";
            cmbmarcabuscar.Size = new Size(121, 23);
            cmbmarcabuscar.TabIndex = 6;
            cmbmarcabuscar.SelectedIndexChanged += cmbmarcabuscar_SelectedIndexChanged;
            // 
            // cmborigenbuscar
            // 
            cmborigenbuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmborigenbuscar.FormattingEnabled = true;
            cmborigenbuscar.Items.AddRange(new object[] { "N", "I\t" });
            cmborigenbuscar.Location = new Point(73, 267);
            cmborigenbuscar.Name = "cmborigenbuscar";
            cmborigenbuscar.Size = new Size(121, 23);
            cmborigenbuscar.TabIndex = 7;
            cmborigenbuscar.SelectedIndexChanged += cmborigenbuscar_SelectedIndexChanged;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(254, 230);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(75, 23);
            btnbuscar.TabIndex = 8;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // lblmarcaguardar
            // 
            lblmarcaguardar.AutoSize = true;
            lblmarcaguardar.Location = new Point(114, 9);
            lblmarcaguardar.Name = "lblmarcaguardar";
            lblmarcaguardar.Size = new Size(40, 15);
            lblmarcaguardar.TabIndex = 9;
            lblmarcaguardar.Text = "Marca";
            // 
            // lblorigenguardar
            // 
            lblorigenguardar.AutoSize = true;
            lblorigenguardar.Location = new Point(111, 72);
            lblorigenguardar.Name = "lblorigenguardar";
            lblorigenguardar.Size = new Size(43, 15);
            lblorigenguardar.TabIndex = 10;
            lblorigenguardar.Text = "Origen";
            // 
            // lblmarcabuscar
            // 
            lblmarcabuscar.AutoSize = true;
            lblmarcabuscar.Location = new Point(114, 180);
            lblmarcabuscar.Name = "lblmarcabuscar";
            lblmarcabuscar.Size = new Size(40, 15);
            lblmarcabuscar.TabIndex = 11;
            lblmarcabuscar.Text = "Marca";
            // 
            // lblorigenbuscar
            // 
            lblorigenbuscar.AutoSize = true;
            lblorigenbuscar.Location = new Point(114, 238);
            lblorigenbuscar.Name = "lblorigenbuscar";
            lblorigenbuscar.Size = new Size(43, 15);
            lblorigenbuscar.TabIndex = 12;
            lblorigenbuscar.Text = "Origen";
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Location = new Point(280, 9);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(51, 15);
            lblnum.TabIndex = 13;
            lblnum.Text = "Numero";
            // 
            // lbldesc
            // 
            lbldesc.AutoSize = true;
            lbldesc.Location = new Point(271, 62);
            lbldesc.Name = "lbldesc";
            lbldesc.Size = new Size(69, 15);
            lbldesc.TabIndex = 14;
            lbldesc.Text = "Descripción";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(280, 115);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(40, 15);
            lblprecio.TabIndex = 15;
            lblprecio.Text = "Precio";
            // 
            // Lstresultado
            // 
            Lstresultado.FormattingEnabled = true;
            Lstresultado.Location = new Point(73, 331);
            Lstresultado.Name = "Lstresultado";
            Lstresultado.Size = new Size(281, 124);
            Lstresultado.TabIndex = 16;
            // 
            // SistemaRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(561, 496);
            Controls.Add(Lstresultado);
            Controls.Add(lblprecio);
            Controls.Add(lbldesc);
            Controls.Add(lblnum);
            Controls.Add(lblorigenbuscar);
            Controls.Add(lblmarcabuscar);
            Controls.Add(lblorigenguardar);
            Controls.Add(lblmarcaguardar);
            Controls.Add(btnbuscar);
            Controls.Add(cmborigenbuscar);
            Controls.Add(cmbmarcabuscar);
            Controls.Add(btnguardar);
            Controls.Add(txtprecio);
            Controls.Add(txtdescripcion);
            Controls.Add(txtnumero);
            Controls.Add(cmborigen);
            Controls.Add(cmbmarca);
            Name = "SistemaRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repuestos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbmarca;
        private ComboBox cmborigen;
        private TextBox txtnumero;
        private TextBox txtdescripcion;
        private TextBox txtprecio;
        private Button btnguardar;
        private ComboBox cmbmarcabuscar;
        private ComboBox cmborigenbuscar;
        private Button btnbuscar;
        private Label lblmarcaguardar;
        private Label lblorigenguardar;
        private Label lblmarcabuscar;
        private Label lblorigenbuscar;
        private Label lblnum;
        private Label lbldesc;
        private Label lblprecio;
        private ListBox Lstresultado;
    }
}
