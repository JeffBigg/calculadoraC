namespace calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0; 
        double Numero2 = 0;
        char operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (txtResultado.Text == "0")
                txtResultado.Text = "";
            txtResultado.Text += boton.Text;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {

        }
    }
}