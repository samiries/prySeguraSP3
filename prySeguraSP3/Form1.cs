using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prySeguraSP3
{
    public partial class SistemaRepuestos : Form
    {
        public SistemaRepuestos()
        {
            InitializeComponent();
            btnguardar.Enabled = false;
            btnbuscar.Enabled = false;
            Lstresultado.Visible = false;
            cmborigen.SelectedIndexChanged += validarbtnguardar;
            cmbmarca.SelectedIndexChanged += validarbtnguardar;
            txtdescripcion.TextChanged += validarbtnguardar;
            txtnumero.TextChanged += txtnumero_TextChanged;
            txtprecio.TextChanged += txtprecio_TextChanged;
        }

        string[] reps = new string[100];
        int[] numerosUsados = new int[100];
        int repsidx = 0;




        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (repsidx >= 100)
            {
                MessageBox.Show("Ya cargaste 100 repuestos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnguardar.Enabled = false;
                return;
            }

            string marca = cmbmarca.Text;
            string origen = cmborigen.Text;
            string num = txtnumero.Text;
            string desc = txtdescripcion.Text;
            string precio = txtprecio.Text;

            int num2;
            int.TryParse(num, out num2);


            bool repetido = false;
            for (int i = 0; i < repsidx; i++)
            {
                if (numerosUsados[i] == num2)
                {
                    repetido = true;
                    break;
                }
            }

            if (repetido)
            {
                MessageBox.Show("Ya existe un repuesto con ese número.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string repuestolinea = marca + "|" + origen + "|" + num + "|" + desc + "|" + precio;

            reps[repsidx] = repuestolinea;
            numerosUsados[repsidx] = num2;
            repsidx++;

            if (repsidx == 100)
            {
                MessageBox.Show("Se completó la carga de los 100 repuestos. No se permiten más ingresos.",
                    "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnguardar.Enabled = false;
            }

            cmbmarca.SelectedIndex = -1;
            cmborigen.SelectedIndex = -1;
            txtnumero.Clear();
            txtdescripcion.Clear();
            txtprecio.Clear();
            cmbmarca.Focus();
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Lstresultado.Visible = true;
            Lstresultado.Items.Clear();

            string marcabusqueda = cmbmarcabuscar.Text;
            string origenbusqueda = cmborigenbuscar.Text;

            int encontrados = 0;

            for (int i = 0; i < repsidx; i++)
            {
                string[] partes = reps[i].Split('|');
                string marca = partes[0];
                string origen = partes[1];
                string num = partes[2];
                string desc = partes[3];
                string precio = partes[4];

                if (marca == marcabusqueda && origen == origenbusqueda)
                {
                    string lineaMostrar = num + " - " + desc + " - $" + precio;
                    Lstresultado.Items.Add(lineaMostrar);
                    encontrados++;
                }
            }

            if (encontrados == 0)
            {
                Lstresultado.Items.Add("NO HUBO RESULTADOS EN LA BÚSQUEDA");
            }

            cmbmarcabuscar.Focus();
        }



        private void validarbtnguardar(object sender, EventArgs e)
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

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            string textoLimpio = "";
            bool comaUsada = false;
            txtprecio.MaxLength = 15;

            foreach (char c in txtprecio.Text)
            {
                if (char.IsDigit(c))
                {
                    textoLimpio += c;
                }
                else if (c == ',' && !comaUsada && textoLimpio.Length > 0)
                {
                    textoLimpio += c;
                    comaUsada = true;
                }
            }

            if (txtprecio.Text != textoLimpio)
            {
                int cursorPos = txtprecio.SelectionStart;
                txtprecio.Text = textoLimpio;
                txtprecio.SelectionStart = Math.Min(cursorPos, txtprecio.Text.Length);
                return;
            }

            validarbtnguardar(sender, e);

        }
        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.MaxLength = 10;
            string textoLimpio = "";

            foreach (char c in txt.Text)
            {
                if (char.IsDigit(c))
                {
                    textoLimpio += c;
                }
            }

            if (txt.Text != textoLimpio)
            {
                int cursorPos = txt.SelectionStart;
                txt.Text = textoLimpio;
                txt.SelectionStart = Math.Min(cursorPos, txt.Text.Length);
                return;
            }

            validarbtnguardar(sender, e);
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            string textoLimpio = "";

            foreach (char c in txtprecio.Text)
            {
                if (char.IsDigit(c))
                {
                    textoLimpio += c;
                }
                else if (c != '|')
                {
                    textoLimpio += c;

                }
            }
            txtdescripcion.MaxLength = 25;
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '|')
            {
                e.Handled = true;
            }
        }


        private void cmbmarcabuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmarcabuscar.SelectedIndex != -1 && cmborigenbuscar.SelectedIndex != -1 && repsidx > 0)
            {
                btnbuscar.Enabled = true;
            }
            else
            {
                btnbuscar.Enabled = false;
            }
        }



        private void cmborigenbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmarcabuscar.SelectedIndex != -1 && cmborigenbuscar.SelectedIndex != -1 && repsidx > 0)
            {
                btnbuscar.Enabled = true;
            }
            else
            {
                btnbuscar.Enabled = false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
