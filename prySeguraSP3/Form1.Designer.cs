namespace prySeguraSP3
{
    partial class Form1
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
            cmbmarca = new ComboBox();
            cmborigen = new ComboBox();
            txtnumero = new TextBox();
            txtdescripcion = new TextBox();
            txtprecio = new TextBox();
            btnguardar = new Button();
            cmbmarcabuscar = new ComboBox();
            cmborigenbuscar = new ComboBox();
            btnbuscar = new Button();
            SuspendLayout();
            // 
            // cmbmarca
            // 
            cmbmarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbmarca.FormattingEnabled = true;
            cmbmarca.Items.AddRange(new object[] { "P", "F", "R\t\t" });
            cmbmarca.Location = new Point(73, 36);
            cmbmarca.Name = "cmbmarca";
            cmbmarca.Size = new Size(121, 23);
            cmbmarca.TabIndex = 0;
            // 
            // cmborigen
            // 
            cmborigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmborigen.FormattingEnabled = true;
            cmborigen.Items.AddRange(new object[] { "N", "I\t" });
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
            txtdescripcion.Location = new Point(254, 65);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(100, 23);
            txtdescripcion.TabIndex = 3;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(254, 94);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(100, 23);
            txtprecio.TabIndex = 4;
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
            // 
            // cmborigenbuscar
            // 
            cmborigenbuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmborigenbuscar.FormattingEnabled = true;
            cmborigenbuscar.Items.AddRange(new object[] { "N", "I\t" });
            cmborigenbuscar.Location = new Point(73, 251);
            cmborigenbuscar.Name = "cmborigenbuscar";
            cmborigenbuscar.Size = new Size(121, 23);
            cmborigenbuscar.TabIndex = 7;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(254, 230);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(75, 23);
            btnbuscar.TabIndex = 8;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 333);
            Controls.Add(btnbuscar);
            Controls.Add(cmborigenbuscar);
            Controls.Add(cmbmarcabuscar);
            Controls.Add(btnguardar);
            Controls.Add(txtprecio);
            Controls.Add(txtdescripcion);
            Controls.Add(txtnumero);
            Controls.Add(cmborigen);
            Controls.Add(cmbmarca);
            Name = "Form1";
            Text = "Form1";
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
    }
}
