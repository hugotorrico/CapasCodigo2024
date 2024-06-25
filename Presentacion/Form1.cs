using Negocio;
using System.DirectoryServices.ActiveDirectory;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {       

            try
            {
                NRol negocio = new NRol();
                string mensaje = string.Empty;                
                mensaje= negocio.Registrar(txtRol.Text);

                if (mensaje==string.Empty)
                    MessageBox.Show("Registro Exitoso");
                else
                    MessageBox.Show(mensaje);

            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Administrador");

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
