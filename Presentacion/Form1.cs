using Negocio;
using System.DirectoryServices.ActiveDirectory;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        NRol negocio = new NRol();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string mensaje = string.Empty;
                mensaje = negocio.Registrar(txtRol.Text);

                if (mensaje == string.Empty)
                {
                    MessageBox.Show("Registro Exitoso");
                    txtBuscar.Text = "";
                    txtRol.Text = "";
                }
                else
                    MessageBox.Show(mensaje);

            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Administrador");

            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvRoles.DataSource = negocio.Listar(txtBuscar.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvRoles.DataSource = negocio.Listar(txtBuscar.Text);
        }
    }
}
