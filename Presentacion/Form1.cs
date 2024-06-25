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
            //Registrar el rol!!!!

            try
            {
                NRol negocio = new NRol();
                negocio.Registrar(txtRol.Text, true);
                MessageBox.Show("Registro Exitoso");
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
