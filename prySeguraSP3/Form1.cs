namespace prySeguraSP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnguardar.Enabled = false;
            cmborigen.SelectedIndexChanged += validarbtn;
            cmbmarca.SelectedIndexChanged += validarbtn;
            txtdescripcion.TextChanged += validarbtn;
            txtnumero.TextChanged += validarbtn;
            txtprecio.TextChanged += validarbtn;
        }



        private void btnguardar_Click(object sender, EventArgs e)
        {

        }


        private void validarbtn(object sender, EventArgs e)
        {
            if (cmbmarca.SelectedIndex > -1 &&
                cmborigen.SelectedIndex > -1 &&
                txtdescripcion.Text != "" &&
                txtnumero.Text != "" &&
                txtprecio.Text != "")
            {
                btnguardar.Enabled = true;
            }
            else
            {
                btnguardar.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            string textolimpio = "";
            bool comausada = false;

            
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
